using DataGrid.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGrid_Kova.Logic
{
    /// <summary>
    /// Класс для создания экземпляров автомобилей
    /// </summary>
    internal class CreateCar
    {
        /// <summary>
        /// Создает новый экземпляр <see cref="Car"/> с уникальным идентификатором.
        /// </summary>
        /// <param name="sett">Функция настройки свойств автомобиля</param>
        /// <returns>Созданный экземпляр автомобиля</returns>
        public static Car Create(Action<Car>? sett = null)
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
