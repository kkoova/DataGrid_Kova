using System;
using System.Linq;
using DataGridCar.Contracts;
using DataGridCar.Contracts.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DataGridCar.MemoryStorage
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

        /// <inheritdoc />
        public Task<Car> AddAsync(Car car)
        {
            cars.Add(car);
            return Task.FromResult(car);
        }

        /// <inheritdoc />
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

        /// <inheritdoc />
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

        /// <inheritdoc />
        public Task<IReadOnlyCollection<Car>> GetAllAsync()
            => Task.FromResult<IReadOnlyCollection<Car>>(cars);
    }
}
