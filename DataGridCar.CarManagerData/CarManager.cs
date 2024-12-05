using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DataGridCar.CarManagerData.Models;
using DataGridCar.Contracts;
using DataGridCar.Contracts.Models;
using Microsoft.Extensions.Logging;

namespace DataGridCar.CarManagerData
{
    /// <summary>
    /// Класс <see cref="CarManager"/> реализует интерфейс <see cref="ICarManager"/> 
    /// и предоставляет методы для управления автомобилями, включая добавление, 
    /// удаление, редактирование и получение статистики автомобилей.
    /// </summary>
    public class CarManager : ICarManager
    {
        private readonly ICarStorage carStorage;
        private readonly ILogger<CarManager> logger;
        private readonly Stopwatch stopwatch;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="CarManager"/>
        /// </summary>
        /// <param name="carStorage">Интерфейс хранилища автомобилей</param>
        public CarManager(ICarStorage carStorage, ILogger<CarManager> logger)
        {
            stopwatch = new Stopwatch();
            this.carStorage = carStorage;
            this.logger = logger;
        }
        /// <inheritdoc />
        public async Task<Car> AddAsync(Car car)
        {
            stopwatch.Start();

            Car result;
            try
            {
                result = await carStorage.AddAsync(car);
            }
            catch
            {
                stopwatch.Stop();
                logger.LogInformation(
                    "Действие {0}, c id {1} не было выполненно",
                    nameof(ICarManager.AddAsync),
                    car.Id);
                return null;
            }

            stopwatch.Stop();
            logger.LogInformation(
                "Действие {0} {1}, выполненно за {2} мс",
                nameof(ICarManager.AddAsync),
                car.Id,
                stopwatch.ElapsedMilliseconds);

            return result;
        }

        /// <inheritdoc />
        public async Task<bool> DeleteAsync(Guid id)
        {
            stopwatch.Restart();

            var result = await carStorage.DeleteAsync(id);

            stopwatch.Stop();

            if (result)
            {
                logger.LogInformation(
                    "Действие {0} машины с индетификаторм {1}: {2} мс - успешно",
                    nameof(ICarManager.DeleteAsync),
                    id,
                    stopwatch.ElapsedMilliseconds);
            }
            else
            {
                logger.LogInformation(
                    "Действие {0} машины с индетификаторм {1}: {2} мс - ошибка удаления",
                    nameof(ICarManager.DeleteAsync),
                    id,
                    stopwatch.ElapsedMilliseconds);
            }

            return result;
        }


        /// <inheritdoc />
        public Task EditAsync(Car car)
        {
            stopwatch.Restart();

            var result = carStorage.EditAsync(car);

            stopwatch.Stop();
            logger.LogInformation(
                "Действие {0} машины с индетификаторм {1}: {2} мс",
                nameof(ICarManager.EditAsync),
                car.Id,
                stopwatch.ElapsedMilliseconds);

            return result;
        }

        /// <inheritdoc />
        public Task<IReadOnlyCollection<Car>> GetAllAsync()
        {
            stopwatch.Restart();

            var result = carStorage.GetAllAsync();

            stopwatch.Stop();
            logger.LogInformation(
                "Получения всех машин в прокате: {1} мс", stopwatch.ElapsedMilliseconds);

            return result;
        }

        /// <inheritdoc />
        public async Task<ICarStats> GetStatsAsync()
        {
            stopwatch.Restart();

            var result = await carStorage.GetAllAsync();

            stopwatch.Stop();
            logger.LogInformation("Получение всей статистики: {1} мс", stopwatch.ElapsedMilliseconds);

            return new CarStatsModel
            {
                CountCar = result.Count,
                CarLowFlue = result.Where(x => Convert.ToDecimal(x.FuelVolume) < 7).Count(),
            };
        }
    }
}
