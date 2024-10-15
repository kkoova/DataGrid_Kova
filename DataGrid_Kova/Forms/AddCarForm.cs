using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataGrid_Kova.Models;
using BindingLibraryKova;
using DataGrid_Kova.Logic;


namespace DataGrid_Kova.Forms
{
    public partial class AddCarForm : Form
    {
        public readonly Car car;

        public AddCarForm(Car? car = null)
        {
            this.car = car == null
            ? CreateCar.Create (x =>
            { })
            : new Car
            {
                Id = car.Id,
                Carbrand = car.Carbrand,
                Number = car.Number,
                Mileage = car.Mileage,
                AverageFuelConsumption = car.AverageFuelConsumption,
                FuelVolume = car.FuelVolume,
                CostRent = car.CostRent,
            };

            InitializeComponent();
            SetButtonStyles();

            foreach (var item in Enum.GetValues(typeof(Brand)))
            {
                brandcomboBox.Items.Add(item);
            }

            brandcomboBox.AddBinding(x => x.SelectedItem, this.car, x => x.Carbrand, errorProvider);
            StateNumberText.AddBinding(x => x.Text, this.car, x => x.Number, errorProvider);
            MillText.AddBinding(x => x.Text, this.car, x => x.Mileage, errorProvider);
            CurrentFuelVolumeText.AddBinding(x => x.Text, this.car, x => x.FuelVolume, errorProvider);
            RentalPriceText.AddBinding(x => x.Text, this.car, x => x.CostRent, errorProvider);
        }

        private void SetButtonStyles()
        {
            foreach (Control control in Controls)
            {
                if (control is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.BackColor = Color.Transparent;
                    btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
                    btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
                }
            }
        }
    }
}
