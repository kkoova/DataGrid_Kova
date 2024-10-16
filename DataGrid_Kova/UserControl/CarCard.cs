using DataGrid.Contracts.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGrid_Kova
{
    public partial class CarCard : UserControl
    {
        public event EventHandler EditButtonClicked;
        public event EventHandler DeleteButtonClicked;

        public CarCard()
        {
            InitializeComponent();
            SetRandomBackColor();

            dellbtn.Click += (s, e) => DeleteButtonClicked?.Invoke(this, EventArgs.Empty);
            editButton.Click += (s, e) => EditButtonClicked?.Invoke(this, EventArgs.Empty);
        }

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

            return brand switch
            {
                Brand.HyundaiCross => Properties.Resources.HyundaiCrossImage,
                Brand.Ladavesta => Properties.Resources.LadavestaImage,
                Brand.MitsubishiOutlander => Properties.Resources.MitsubishiOutlanderImage,
                _ => Properties.Resources.car_1,
            };
        }

        private void SetRandomBackColor()
        {
            string[] colors = { "#dfe5f6", "#dbeaff", "#ffdbea" };

            Random random = new();

            var randomIndex = random.Next(colors.Length);

            Color randomColor = ColorTranslator.FromHtml(colors[randomIndex]);

            BackColor = randomColor;
        }
    }
}
