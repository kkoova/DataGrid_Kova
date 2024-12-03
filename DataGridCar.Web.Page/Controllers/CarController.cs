using Microsoft.AspNetCore.Mvc;
using DataGridCar.Contracts;
using DataGridCar.Contracts.Models;

namespace DataGridCar.Web.Page
{
    public class CarController : Controller
    {
        private readonly ICarManager carManager;

        public CarController(ICarManager carManager)
        {
            this.carManager = carManager;
        }

        /// <summary>
        /// Отображает список всех машин.
        /// </summary>
        public async Task<IActionResult> Index()
        {
            var cars = carManager.GetAllAsync();
            var stats = carManager.GetStatsAsync();
            await Task.WhenAll(cars, stats);

            ViewData[nameof(ICarStats)] = stats.Result;
            return View(cars.Result);
        }


        /// <summary>
        /// Обрабатывает создание нового продукта.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> Create(Car car)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            car.Id = Guid.NewGuid();
            await carManager.AddAsync(car);
            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// Отображает страницу редактирования продукта по его идентификатору.
        /// </summary>
        public async Task<IActionResult> Edit(Guid id)
        {
            var cars = await carManager.GetAllAsync();
            var car = cars.FirstOrDefault(p => p.Id == id);
            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }

        /// <summary>
        /// Обрабатывает редактирование существующего продукта.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> Edit(Car car)
        {
            if (!ModelState.IsValid)
            {
                return View(car);
            }

            var cars = await carManager.GetAllAsync();
            var existingCar = cars.FirstOrDefault(p => p.Id == car.Id);
            if (existingCar == null)
            {
                return NotFound();
            }

            await carManager.EditAsync(car);
            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// Обрабатывает удаление продукта по его идентификатору.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await carManager.DeleteAsync(id);
            if (result == false)
            {
                return NotFound();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
