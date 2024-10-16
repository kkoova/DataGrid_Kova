using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataGrid.Contracts.Models;
using DataGrid.Framework.Contracts;

namespace DataGrid.Memory
{
    public class MemoryCarStorage : ICarStorage
    {
        private readonly List<Car> cars;

        /// <summary>
        /// Создание нового экземпляра <see cref="MemoryCarStorage"/>
        /// </summary>
        public MemoryCarStorage()
        {
            cars = new List<Car>();
        }

        /// <summary>
        /// Асинхронное добавление нового автомобиля
        /// </summary>
        /// <param name="car">Автомобиль для добавления</param>
        /// <returns>Добавленный автомобиль</returns>
        public Task<Car> AddAsync(Car car)
        {
            cars.Add(car);
            return Task.FromResult(car);
        }

        /// <summary>
        /// Асинхронное удаление автомобиля по его идентификатору
        /// </summary>
        /// <param name="id">Идентификатор автомобиля, который нужно удалить</param>
        /// <returns>Истина, если удаление прошло успешно иначе ложь</returns>
        public Task<bool> DeleteAsync(Guid id)
        {
            var car = cars.FirstOrDefault(x => x.Id == id);
            if (car != null)
            {
                cars.Remove(car);
                return Task.FromResult(true);
            }
            return Task.FromResult(false);
        }

        /// <summary>
        /// Асинхронное редактирование существующего автомобиля
        /// </summary>
        /// <param name="car">Автомобиль с обновленными данными</param>
        /// <returns>Редактируемый автомобиль</returns>
        public Task EditAsync(Car car)
        {
            var target = cars.FirstOrDefault(x => x.Id == car.Id);
            if (car != null)
            {
                target.Carbrand = car.Carbrand;
                target.Number = car.Number;
                target.Mileage = car.Mileage;
                target.AverageFuelConsumption = car.AverageFuelConsumption;
                target.FuelVolume = car.FuelVolume;
                target.CostRent = car.CostRent;
            }
            return Task.CompletedTask;
        }

        /// <summary>
        /// Асинхронное получение всех автомобилей
        /// </summary>
        /// <returns>Список всех автомобилей в виде только для чтения</returns>
        public Task<IReadOnlyCollection<Car>> GetAllAsync()
            => Task.FromResult<IReadOnlyCollection<Car>>(cars);
    }
}
