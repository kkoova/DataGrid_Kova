using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Contracts;
using Contracts.Models;

namespace MemoryStorage.Entiti
{
    public class DataBaseCarStorage : ICarStorage
    {
        public async Task<Car> AddAsync(Car car)
        {
            using (var context = new DataGridContext())
            {
                var cts = new CancellationTokenSource();
                context.Cars.Add(car);
                cts.Cancel();
                await context.SaveChangesAsync(cts.Token);
            }

            return car;
        }

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

        public async Task<IReadOnlyCollection<Car>> GetAllAsync()
        {
            using (var context = new DataGridContext())
            {
                var items = await context.Cars
                    .OrderBy(x => x.Carbrand)
                    .OrderBy(x => x.FuelReserve)
                    .ToListAsync();
                return items;
            }
        }
    }
}
