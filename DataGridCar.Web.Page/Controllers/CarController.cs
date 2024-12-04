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

        [HttpGet]
        public IActionResult Add()
        {
            return PartialView("_AddCarForm");
        }

        /// <summary>
        /// Обрабатывает создание новой машины.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> Add(Car car)
        {
            if (!ModelState.IsValid)
            {
                return PartialView("_getCarForm", car);
            }

            car.Id = Guid.NewGuid();
            await carManager.AddAsync(car);
            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// Отображает форму редактирования машины по ее идентификатору.
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
        /// Обрабатывает редактирование существующей машины.
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
        /// Обрабатывает удаление машины по ее идентификатору.
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

        [HttpGet]
        public async Task<IActionResult> GetCar(Guid id)
        {
            var car = (await carManager.GetAllAsync()).FirstOrDefault(c => c.Id == id);
            if (car == null)
            {
                return NotFound();
            }
            return Json(car);
        }
    }
}
