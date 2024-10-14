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

        public string Carbrand
        {
            get { return CarbrandText.Text; }
            set { CarbrandText.Text = value; }
        }

        public string Number
        {
            get { return NomerText.Text; }
            set { NomerText.Text = value; }
        }

        public string Mileage
        {
            get { return MileageText.Text; }
            set { MileageText.Text = value; }
        }

        public string AverageFuelConsumption
        {
            get { return AverageFuelConsumptionText.Text; }
            set { AverageFuelConsumptionText.Text = value; }
        }

        public string FuelVolume
        {
            get { return FuelVolumeText.Text; }
            set { FuelVolumeText.Text = value; }
        }

        public string CostRent
        {
            get { return CostRentText.Text; }
            set { CostRentText.Text = value; }
        }

        public string FuelReserve
        {
            get { return FuelReserveText.Text; }
            set { FuelReserveText.Text = value; }
        }

        public string RentalAmount
        {
            get { return RentalAmountText.Text; }
            set { RentalAmountText.Text = value; }
        }

        public Image CarImage
        {
            get { return CarPictBox.Image; }
            set { CarPictBox.Image = value; }
        }

        private void SetRandomBackColor()
        {
            string[] colors = { "#dfe5f6", "#dbeaff", "#ffdbea" };

            Random random = new Random();

            int randomIndex = random.Next(colors.Length);

            Color randomColor = ColorTranslator.FromHtml(colors[randomIndex]);

            this.BackColor = randomColor;
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
