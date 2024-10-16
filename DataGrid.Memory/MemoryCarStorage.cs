using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataGrid.Contracts.Models;
using DataGrid.Framework.Contracts;

namespace DataGrid.Memory
{
    public class MemoryCarStorage : ICarStorage
    {
        private readonly List<Car> cars;

        public MemoryCarStorage()
        {
            cars = new List<Car>();
        }
        public Task<Car> AddAsync(Car car)
        {
            cars.Add(car);
            return Task.FromResult(car);
        }
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
        public Task<IReadOnlyCollection<Car>> GetAllAsync()
            => Task.FromResult<IReadOnlyCollection<Car>>(cars);
    }
}
