using DataGridCar.Contracts;

namespace DataGridCar.CarManagerData.Models
{
    /// <summary>
    /// Статистика по автомобилям
    /// </summary>
    public class CarStatsModel : ICarStats
    {
        /// <summary>
        /// Общее количество автомобилей
        /// </summary>
        public int CountCar { get; set; }

        /// <summary>
        /// Количество автомобилей с низким уровнем топлива
        /// </summary>
        public int CarLowFlue { get; set; }
    }
}
