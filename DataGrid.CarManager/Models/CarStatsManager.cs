using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataGrid.Contracts;

namespace DataGrid.CarManager.Models
{
    public class CarStatsModel : ICarStats
    {
        public int CountCar { get; set; }

        public int CarLowFlue { get; set; }
    }
}
