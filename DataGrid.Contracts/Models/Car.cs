using System;
using System.ComponentModel.DataAnnotations;

namespace DataGrid.Contracts.Models
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
        [Required(ErrorMessage = "Заполните поля!")]
        public string Carbrand { get; set; }

        /// <summary>
        /// Гос номер
        /// </summary>
        [Required(ErrorMessage = "Заполните поля!")]
        [StringLength(10, MinimumLength = 1, ErrorMessage = "Номер должен быть длиной от 1 до 10 символов.")]
        public string Number { get; set; }

        /// <summary>
        /// Пробег
        /// </summary>
        [Required(ErrorMessage = "Заполните поля!")]
        [Range(1, int.MaxValue, ErrorMessage = "Пробег должен быть положительным числом.")]
        public decimal Mileage { get; set; }

        /// <summary>
        /// Средний расход топлива за час
        /// </summary>
        [Required(ErrorMessage = "Заполните поля!")]
        [Range(1, 10, ErrorMessage = "Расход топлива должен быть в диапазоне от 0 до 10 литров.")]
        public decimal AverageFuelConsumption { get; set; }

        /// <summary>
        /// Текущий объем топлива
        /// </summary>
        [Required(ErrorMessage = "Заполните поля!")]
        [Range(1, 100, ErrorMessage = "Объем топлива должен быть в диапазоне от 0 до 100 литров.")]
        public decimal FuelVolume { get; set; }

        /// <summary>
        /// Стоимость аренды (за минуту)
        /// </summary>
        [Required(ErrorMessage = "Заполните поля!")]
        [Range(1, 5000, ErrorMessage = "Стоимость арегды должна быть в диапазоне от 0 до 1000 руб.")]
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
