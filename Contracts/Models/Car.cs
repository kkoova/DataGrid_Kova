using System;

namespace DataGridCar.Contracts.Models
{
    /// <summary>
    /// Машина
    /// </summary>
    public class Car
    {
        public Guid Id { get; set; }
        /// <summary>
        /// <inheritdoc cref="DataGrid_Kova.Models.Brand"/>
        /// </summary>
        public string Carbrand { get; set; }

        /// <summary>
        /// Гос номер
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Пробег
        /// </summary>
        public decimal Mileage { get; set; }

        /// <summary>
        /// Средний расход топлива за час
        /// </summary>
        public decimal AverageFuelConsumption { get; set; }

        /// <summary>
        /// Текущий объем топлива
        /// </summary>
        public decimal FuelVolume { get; set; }

        /// <summary>
        /// Стоимость аренды (за минуту)
        /// </summary>
        public decimal CostRent { get; set; }

        /// <summary>
        /// Запас хода топлива
        /// </summary>
        public decimal FuelReserve => FuelVolume / AverageFuelConsumption;

        /// <summary>
        /// Сумма аренды
        /// </summary>
        public decimal RentalAmount => (FuelVolume / AverageFuelConsumption) * CostRent;
    }
}
