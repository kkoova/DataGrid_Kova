using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGrid_Kova.Models
{

    public class Car
    {
        /// <summary>
        /// Название автомобиля
        /// </summary>
        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Carbrand { get; set; }

        /// <summary>
        /// Номер автомобиля (гос. номер)
        /// </summary>
        [Required]
        [StringLength(10, MinimumLength = 1, ErrorMessage = "Номер должен быть длиной от 1 до 10 символов.")]
        public string Number { get; set; }

        /// <summary>
        /// Пробег автомобиля
        /// </summary>
        [Required]
        [RegularExpression(@"^\d+ $", ErrorMessage = "Пробег должен быть в формате: 'число'.")]
        public string Mileage { get; set; }

        /// <summary>
        /// Средний расход топлива
        /// </summary>
        [Required]
        [RegularExpression(@"^\d+ $", ErrorMessage = "Средний расход должен быть в формате: 'число'.")]
        public string AverageFuelConsumption { get; set; }

        /// <summary>
        /// Объем топливного бака
        /// </summary>
        [Required]
        [RegularExpression(@"^\d+ $", ErrorMessage = "Объем топлива должен быть в формате: 'число'.")]
        public string FuelVolume { get; set; }

        /// <summary>
        /// Стоимость аренды
        /// </summary>
        [Required]
        [RegularExpression(@"^\$\d+\.?\d{0,2}$", ErrorMessage = "Стоимость должна быть в формате: '$число'.")]
        public string CostRent { get; set; }

        /// <summary>
        /// Запас топлива
        /// </summary>
        [Required]
        [RegularExpression(@"^\d+ $", ErrorMessage = "Запас топлива должен быть в формате: 'число '.")]
        public string FuelReserve { get; set; }

        /// <summary>
        /// Сумма аренды
        /// </summary>
        [Required]
        [RegularExpression(@"^\$\d+\.?\d{0,2}$", ErrorMessage = "Сумма аренды должна быть в формате: '$число'.")]
        public string RentalAmount { get; set; }

        /// <summary>
        /// Изображение автомобиля
        /// </summary>
        [Required(ErrorMessage = "Изображение автомобиля обязательно.")]
        public Image CarImage { get; set; }

        public Car(string carbrand, string number, string mileage, string averageFuelConsumption,
                   string fuelVolume, string costRent, string fuelReserve, string rentalAmount, Image carImage)
        {
            Carbrand = carbrand;
            Number = number;
            Mileage = mileage;
            AverageFuelConsumption = averageFuelConsumption;
            FuelVolume = fuelVolume;
            CostRent = costRent;
            FuelReserve = fuelReserve;
            RentalAmount = rentalAmount;
            CarImage = carImage;
        }
    }
}
