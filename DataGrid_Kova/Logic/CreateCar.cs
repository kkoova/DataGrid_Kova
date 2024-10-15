using DataGrid_Kova.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGrid_Kova.Logic
{
    internal class CreateCar
    {
        public static Car Create(Action<Car> sett = null)
        {
            var result = new Car
            {
                Id = Guid.NewGuid(),
            };

            sett?.Invoke(result);

            return result;
        }
    }
}
