using System.Data.Entity;
using Contracts.Models;

namespace MemoryStorage.Entiti
{
    public class DataGridContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
    }
}
