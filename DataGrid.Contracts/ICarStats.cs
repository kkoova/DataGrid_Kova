using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGrid.Contracts
{
    public interface ICarStats
    {
        int CountCar { get; }

        int CarLowFlue { get; }
    }
}
