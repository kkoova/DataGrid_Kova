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
        private const string StopWatch = "{} выполняется {}";

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="CarManager"/>
        /// </summary>
        /// <param name="carStorage">Интерфейс хранилища автомобилей</param>
        public CarManager(ICarStorage carStorage, ILogger logger)
        {
            this.logger = logger;
            this.carStorage = carStorage;
        }

        /// <summary>
        /// Добавление нового автомобиля
        /// </summary>
        /// <param name="car">Автомобиль для добавления</param>
        /// <returns>Асинхронная задача с результатом добавленного автомобиля</returns>
        public async Task<Car> AddAsync(Car car)
        {

            var stopWathc = new Stopwatch();
            stopWathc.Start();

            var result = await carStorage.AddAsync(car);

            stopWathc.Stop();

            logger.LogInformation(string.Format(StopWatch, nameof(AddAsync), stopWathc.ElapsedMilliseconds));
            return result;
        }

        /// <summary>
        /// Удаление автомобиля по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор автомобиля</param>
        /// <returns>Асинхронная задача, возвращающая результат операции удаления</returns>
        public async Task<bool> DeleteAsync(Guid id)
        {
            var result = await carStorage.DeleteAsync(id);

            if (result)
            {
                logger.LogInformation("Польхователь с индитивикатором {id} удален");
            }
            return result;
        }


        /// <summary>
        /// Редактирование информации об автомобиле
        /// </summary>
        /// <param name="car">Автомобиль с обновленными данными</param>
        /// <returns>Асинхронная задача, обновление информации и машине</returns>
        public Task EditAsync(Car car)
            => carStorage.EditAsync(car);

        /// <summary>
        /// Получение всех автомобилей
        /// </summary>
        /// <returns>Асинхронная задача с коллекцией автомобилей</returns>
        public Task<IReadOnlyCollection<Car>> GetAllAsync()
            => carStorage.GetAllAsync();

        /// <summary>
        /// Получение статистики по автомобилям
        /// </summary>
        /// <returns>Асинхронная задача с данными о статистике автомобилей</returns>
        public async Task<ICarStats> GetStatsAsync()
        {
            var result = await carStorage.GetAllAsync();
            return new CarStatsModel
            {
                CountCar = result.Count,
                CarLowFlue = result.Where(x => Convert.ToDecimal(x.FuelVolume) < 7).Count(),
            };
        }
    }
}
