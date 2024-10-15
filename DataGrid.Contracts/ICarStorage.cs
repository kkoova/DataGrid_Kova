using DataGrid.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataGrid.Framework.Contracts
{
    public interface ICarStorage
    {
        Task<IReadOnlyCollection<Car>> GetAllAsync();

        Task<Car> AddAsync(Car person);

        Task EditAsync(Car person);

        Task<bool> DeleteAsync(Guid id);
    }
}
