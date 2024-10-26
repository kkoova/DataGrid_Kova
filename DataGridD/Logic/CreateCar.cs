using Contracts.Models;

namespace DataGridD.Logic
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
