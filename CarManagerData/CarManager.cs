using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CarManagerData.Models;
using Contracts;
using Contracts.Models;
using Microsoft.Extensions.Logging;

namespace CarManagerData
{
    /// <summary>
    /// Класс <see cref="CarManager"/> реализует интерфейс <see cref="ICarManager"/> 
    /// и предоставляет методы для управления автомобилями, включая добавление, 
    /// удаление, редактирование и получение статистики автомобилей.
    /// </summary>
    public class CarManager : ICarManager
    {
        private readonly ICarStorage carStorage;
        private readonly ILogger logger;
        private readonly Stopwatch stopwatch;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="CarManager"/>
        /// </summary>
        /// <param name="carStorage">Интерфейс хранилища автомобилей</param>
        public CarManager(ICarStorage carStorage, ILogger logger)
        {
            stopwatch = new Stopwatch();
            this.carStorage = carStorage;
            this.logger = logger;
        }

        /// <inheritdoc />
        public async Task<Car> AddAsync(Car car)
        {
            stopwatch.Restart();

            var result = await carStorage.AddAsync(car);

            stopwatch.Stop();
            logger.LogInformation("Добавление машины в прокат: {1} мс", stopwatch.ElapsedMilliseconds);

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
                logger.LogInformation("Удаление машины с индетификаторм {0}: {1} мс - успешно", id, stopwatch.ElapsedMilliseconds);
            }
            else
            {
                logger.LogInformation("Удаление машины с индетификаторм {0}: {1} мс - ошибка удаления", id, stopwatch.ElapsedMilliseconds);
            }

            return result;
        }


        /// <inheritdoc />
        public Task EditAsync(Car car)
        {
            stopwatch.Restart();

            var result = carStorage.EditAsync(car);

            stopwatch.Stop();
            logger.LogInformation("Изменение машины с индетификаторм {0}: {1} мс", car.Id, stopwatch.ElapsedMilliseconds);

            return result;
        }

        /// <inheritdoc />
        public Task<IReadOnlyCollection<Car>> GetAllAsync()
        {
            stopwatch.Restart();

            var result = carStorage.GetAllAsync();

            stopwatch.Stop();
            logger.LogInformation("Получения всех машин в прокате: {1} мс", stopwatch.ElapsedMilliseconds);

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
