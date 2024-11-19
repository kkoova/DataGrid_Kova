using System.Data.Entity;
using Contracts.Models;

namespace DataGridCar.DataStorage.Entity
{
    /// <summary>
    /// Контекст базы данных
    /// </summary>
    public class DataGridContext : DbContext
    {
        /// <summary>
        /// Конструктор контекста базы данных
        /// </summary>
        public DataGridContext() : base("CarDataGridDB")
        { }

        /// <summary>
        /// Таблица <see cref="Cars"/> в базе данных
        /// </summary>
        public DbSet<Car> Cars { get; set; }
    }
}
