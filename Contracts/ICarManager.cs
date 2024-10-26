using Contracts.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Contracts
{
    /// <summary>
    /// Интерфейс <see cref="ICarManager"/> определяет Task для управления 
    /// операциями с автомобилями, включая добавление, удаление, редактирование 
    /// и получение статистики автомобилей.
    /// </summary>
    public interface ICarManager
    {
        /// <summary>
        /// Получение все автомобили в виде неизменяемой коллекции
        /// </summary>
        /// <returns>Возвращает коллекцию автомобилей</returns>
        Task<IReadOnlyCollection<Car>> GetAllAsync();

        /// <summary>
        /// Добавление нового автомобиля
        /// </summary>
        /// <param name="car">Автомобиль, который необходимо добавить</param>
        /// <returns>Возвращает добавленный автомобиль</returns>
        Task<Car> AddAsync(Car car);

        /// <summary>
        /// Редактирование существующего автомобиля
        /// </summary>
        /// <param name="car">Автомобиль с обновленными данными</param>
        /// <returns>Возвращает новую версию автомобиля</returns>
        Task EditAsync(Car car);

        /// <summary>
        /// Удаление автомобиля по заданному идентификатору
        /// </summary>
        /// <param name="id">Идентификатор автомобиля, который необходимо удалить</param>
        /// <returns>Возвращает true, если удаление прошло успешно иначе false</returns>
        Task<bool> DeleteAsync(Guid id);

        /// <summary>
        /// Получение статистики автомобилей
        /// </summary>
        /// <returns>Возвращает статистику автомобилей</returns>
        Task<ICarStats> GetStatsAsync();
    }
}
