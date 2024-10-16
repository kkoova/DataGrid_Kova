﻿using DataGrid.Framework.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGrid.Framework.Contracts
{
    /// <summary>
    /// Возвращает список
    /// </summary>
    public interface ICarManager
    {
        Task<IReadOnlyCollection<Car>> GetAll();

        Task<Car> AddAsync(Car car);

        Task EditAsync(Car car);

        Task<bool> DeleteAsync(Guid id);

        Task<ICarManager> GetAllAsync();
    }
}
