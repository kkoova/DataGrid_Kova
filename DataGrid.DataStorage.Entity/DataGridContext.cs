using System.Data.Entity;
using Contracts.Models;

namespace DataGrid.DataStorage.Entity
{
    public class DataGridContext : DbContext
    {
        public DataGridContext() : base("DBConnectionString")
        {

        }
        public DbSet<Car> Cars { get; set; }
    }
}
