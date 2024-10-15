using DataGrid.Framework.Contracts.Models;
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
        public CarCard()
        {
            InitializeComponent();
            SetRandomBackColor();
            SetButtonStyles();
        }

        public void SetCar(Car car)
        {
            CarbrandText.Text = car.Carbrand;
            NomerText.Text = car.Number;
            MileageText.Text = car.Mileage;
            AverageFuelConsumptionText.Text = car.AverageFuelConsumption;
            FuelVolumeText.Text = car.FuelVolume;
            CostRentText.Text = car.CostRent;
            FuelReserveText.Text = car.FuelReserve;
            RentalAmountText.Text = car.RentalAmount;
            CarPictBox.Image = car.Image;
        }

        private void SetRandomBackColor()
        {
            string[] colors = { "#dfe5f6", "#dbeaff", "#ffdbea" };

            Random random = new();

            int randomIndex = random.Next(colors.Length);

            Color randomColor = ColorTranslator.FromHtml(colors[randomIndex]);

            BackColor = randomColor;
        }

        private void SetButtonStyles()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    Button btn = (Button)control;

                    btn.FlatStyle = FlatStyle.Flat;
                    btn.BackColor = Color.Transparent;
                    btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
                    btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
                }
            }
        }
    }
}
