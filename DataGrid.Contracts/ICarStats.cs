namespace DataGrid.Contracts
{
    /// <summary>
    /// Интерфейс <see cref="ICarStats"/> определяет контракт для представления 
    /// статистики автомобилей, включая общее количество автомобилей и количество 
    /// автомобилей с низким уровнем топлива
    /// </summary>
    public interface ICarStats
    {
        /// <summary>
        /// Получение общее количество автомобилей
        /// </summary>
        int CountCar { get; }

        /// <summary>
        /// Получение количество автомобилей с низким уровнем топлива
        /// </summary>
        int CarLowFlue { get; }
    }
}
