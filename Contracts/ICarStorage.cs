using Contracts.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Contracts
{
    /// <summary>
    /// Интерфейс <see cref="ICarStorage"/> определяет контракт для хранения
    /// и управления данными автомобилей, включая операции получения,
    /// добавления, редактирования и удаления автомобилей.
    /// </summary>
    public interface ICarStorage
    {
        /// <summary>
        /// Асинхронное получение всех автомобилей
        /// </summary>
        /// <returns>Список всех автомобилей в виде только для чтения</returns>
        Task<IReadOnlyCollection<Car>> GetAllAsync();

        /// <summary>
        /// Асинхронное добавление нового автомобиля
        /// </summary>
        /// <param name="car">Автомобиль для добавления</param>
        /// <returns>Добавленный автомобиль</returns>
        Task<Car> AddAsync(Car car);

        /// <summary>
        /// Асинхронное редактирование существующего автомобиля
        /// </summary>
        /// <param name="car">Автомобиль с обновленными данными</param>
        /// <returns>Редактированный автомобиль</returns>
        Task EditAsync(Car car);

        /// <summary>
        /// Асинхронное удаление автомобиля по его идентификатору
        /// </summary>
        /// <param name="id">Идентификатор автомобиля, который нужно удалить</param>
        /// <returns>Истина, если удаление прошло успешно иначе ложь</returns>
        Task<bool> DeleteAsync(Guid id);
    }
}
