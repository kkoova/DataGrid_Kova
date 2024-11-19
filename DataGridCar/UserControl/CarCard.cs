using System;
using System.Drawing;
using System.Windows.Forms;
using Contracts.Models;

namespace DataGridD
{
    /// <summary>
    /// Представляет карточку автомобиля, отображая его информацию и предоставляя кнопки для редактирования и удаления
    /// </summary>
    public partial class CarCard : UserControl
    {
        /// <summary>
        /// Событие, возникающее при нажатии кнопки редактирования
        /// </summary>
        public event EventHandler EditButtonClicked = null;

        /// <summary>
        /// Событие, возникающее при нажатии кнопки удаления
        /// </summary>
        public event EventHandler DeleteButtonClicked = null;

        /// <summary>
        /// Инициализирует новый экземпляр <see cref="CarCard"/> и настраивает события кнопок
        /// </summary>
        public CarCard()
        {
            InitializeComponent();
            SetRandomBackColor();

            dellbtn.Click += (s, e) => DeleteButtonClicked?.Invoke(this, EventArgs.Empty);
            editButton.Click += (s, e) => EditButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Устанавливает информацию о автомобиле в карточке
        /// </summary>
        /// <param name="car">Экземпляр автомобиля, информация о котором будет отображена</param>
        public void SetCar(Car car)
        {
            CarbrandText.Text = car.Carbrand;
            NomerText.Text = car.Number;
            MileageText.Text = car.Mileage.ToString();
            AverageFueText.Text = car.AverageFuelConsumption.ToString();
            FuelVolumeText.Text = car.FuelVolume.ToString();
            CostRentText.Text = car.CostRent.ToString();

            FuelReserveText.Text = car.FuelReserve.ToString("F2") + " ч.";
            RentalAmountText.Text = "$" + car.RentalAmount.ToString("F2");
            CarPictBox.Image = GetCarImageByBrand(car.Carbrand);
        }

        /// <summary>
        /// Получает изображение автомобиля по его марке
        /// </summary>
        /// <param name="brandName">Название марки автомобиля</param>
        /// <returns>Изображение автомобиля</returns>
        public static Image GetCarImageByBrand(string brandName)
        {
            Brand? brand = null;

            foreach (var b in Enum.GetValues(typeof(Brand)))
            {
                if (string.Equals(b.ToString(), brandName, StringComparison.OrdinalIgnoreCase))
                {
                    brand = (Brand)b;
                    break;
                }
            }

            switch (brand)
            {
                case Brand.HyundaiCross:
                    return global::DataGridCar.Properties.Resources.HyundaiCrossImage;
                case Brand.Ladavesta:
                    return global::DataGridCar.Properties.Resources.LadavestaImage;
                case Brand.MitsubishiOutlander:
                    return global::DataGridCar.Properties.Resources.MitsubishiOutlanderImage;
                default:
                    return global::DataGridCar.Properties.Resources.car_1;
            }
        }

        /// <summary>
        /// Устанавливает случайный цвет фона для карточки автомобиля
        /// </summary>
        private void SetRandomBackColor()
        {
            string[] colors = { "#dfe5f6", "#dbeaff", "#ffdbea" };

            Random random = new Random();

            var randomIndex = random.Next(colors.Length);

            Color randomColor = ColorTranslator.FromHtml(colors[randomIndex]);

            BackColor = randomColor;
        }
    }
}
