using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        [StringLength(10, MinimumLength = 1, ErrorMessage = "Длина  от 1 до 10 символов.")]
        public string Mileage { get; set; }

        /// <summary>
        /// Средний расход топлива за час
        /// </summary>
        [Required(ErrorMessage = "Заполните поля!")]
        [StringLength(10, MinimumLength = 1, ErrorMessage = "Длина  от 1 до 10 символов.")]
        public string AverageFuelConsumption { get; set; }

        /// <summary>
        /// Текущий объем топлива
        /// </summary>
        [Required(ErrorMessage = "Заполните поля!")]
        [StringLength(10, MinimumLength = 1, ErrorMessage = "Длина  от 1 до 10 символов.")]
        public string FuelVolume { get; set; }

        /// <summary>
        /// Стоимость аренды (за минуту)
        /// </summary>
        [Required(ErrorMessage = "Заполните поля!")]
        [StringLength(10, MinimumLength = 1, ErrorMessage = "Длина  от 1 до 10 символов.")]
        public string CostRent { get; set; }

        ///// <summary>
        ///// Запас хода топлива
        ///// </summary>
        //public string FuelReserve { get; set; }

        ///// <summary>
        ///// Сумма аренды
        ///// </summary>
        //public string RentalAmount { get; set; }
    }
}
