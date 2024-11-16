using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts.Models;

namespace DataGrid.DataStorage
{
    public class DataGridContext : DbContext
    {
        public DataGridContext() : base("DBConnectionString")
        {

        }
        public DbSet<Car> Cars { get; set; }
    }
}
