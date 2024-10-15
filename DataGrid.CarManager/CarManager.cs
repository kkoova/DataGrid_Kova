using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataGrid.CarManager.Models;
using DataGrid.Contracts;
using DataGrid.Contracts.Models;
using DataGrid.Framework.Contracts;

namespace DataGrid.CarManager
{
    public class CarManager : ICarManager
    {
        private readonly ICarStorage carStorage;

        public CarManager(ICarStorage carStorage)
        {
            this.carStorage = carStorage;
        }

        public async Task<Car> AddAsync(Car car)
        {
            var result = await carStorage.AddAsync(car);
            return result;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var result = await carStorage.DeleteAsync(id);
            return result;
        }

        public Task EditAsync(Car car)
            => carStorage.EditAsync(car);

        public Task<IReadOnlyCollection<Car>> GetAllAsync()
            => carStorage.GetAllAsync();

        public async Task<ICarStats> GetStatsAsync()
        {
            var result = await carStorage.GetAllAsync();
            return new CarStatsModel
            {
                CountCar = result.Count,
                CarLowFlue = result.Where(x => Convert.ToInt16(x.FuelVolume) < 7).Count(),
            };
        }
    }
}
