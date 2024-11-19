using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using DataGridCar.Contracts;
using DataGridCar.Contracts.Models;

namespace DataGridCar.DataStorage.Entity
{
    /// <summary>
    /// Работа с контекстом базы данных
    /// </summary>
    public class DataBaseCarStorage : ICarStorage
    {
        /// <summary>
        /// Добавление машины в базу данных
        /// </summary>
        public async Task<Car> AddAsync(Car car)
        {
            using (var context = new DataGridContext())
            {
                context.Cars.Add(car);
                await context.SaveChangesAsync();
            }

            return car;
        }

        /// <summary>
        /// Удаление машины из базы данных
        /// </summary>
        public async Task<bool> DeleteAsync(Guid id)
        {
            using (var context = new DataGridContext())
            {
                var item = await context.Cars.FirstOrDefaultAsync(x => x.Id == id);
                if (item != null)
                {
                    context.Cars.Remove(item);
                    await context.SaveChangesAsync();
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Редактирование машины в базе данных
        /// </summary>
        public async Task EditAsync(Car car)
        {
            using (var context = new DataGridContext())
            {
                var target = await context.Cars.FirstOrDefaultAsync(x => x.Id == car.Id);
                if (target != null)
                {
                    target.Carbrand = car.Carbrand;
                    target.Number = car.Number;
                    target.Mileage = car.Mileage;
                    target.AverageFuelConsumption = car.AverageFuelConsumption;
                    target.FuelVolume = car.FuelVolume;
                    target.CostRent = car.CostRent;
                }
                await context.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Получение информации из базы данных
        /// </summary>
        public async Task<IReadOnlyCollection<Car>> GetAllAsync()
        {
            using (var context = new DataGridContext())
            {
                var items = await context.Cars
                    .OrderBy(x => x.Carbrand)
                    .ToListAsync();
                return items;
            }
        }
    }
}
