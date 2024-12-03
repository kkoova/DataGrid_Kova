using Microsoft.AspNetCore.Mvc;
using DataGridCar.Contracts;
using DataGridCar.Contracts.Models;

namespace DataGridCar.Web.Page
{
    public class CarController(ICarManager carManager) : Controller
    {
        private readonly ICarManager carManager = carManager;

        /// <summary>
        /// ���������� ������ ���� �����.
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
        /// ������������ �������� ������ ��������.
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
        /// ���������� �������� �������������� �������� �� ��� ��������������.
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
        /// ������������ �������������� ������������� ��������.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, Car car)
        {
            if (!ModelState.IsValid)
            {
                return View(car);
            }

            var cars = await carManager.GetAllAsync();
            var exCar = cars.FirstOrDefault(p => p.Id == id);
            if (exCar == null)
            {
                return NotFound();
            }

            await carManager.EditAsync(car);
            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// ������������ �������� �������� �� ��� ��������������.
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
