using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BindingLibraryKova;
using DataGrid.Contracts.Models;
using DataGrid_Kova.Logic;

namespace DataGrid_Kova.Forms
{
    public partial class AddCarForm : Form
    {
        private readonly Car car;

        public AddCarForm(Car? car = null)
        {
            this.car = car == null
            ? CreateCar.Create(x =>
            {
                x.Id = Guid.NewGuid();
            })
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
            if (brandcomboBox.Items.Count > 0)
            {
                brandcomboBox.SelectedIndex = 0;
            }

            brandcomboBox.AddBinding(x => x.SelectedItem, this.car, x => x.Carbrand);
            StateNumberText.AddBinding(x => x.Text, this.car, x => x.Number, errorProvider);
            MillText.AddBinding(x => x.Text, this.car, x => x.Mileage, errorProvider);
            CurrentFuelVolumeText.AddBinding(x => x.Text, this.car, x => x.FuelVolume, errorProvider);
            RentalPriceText.AddBinding(x => x.Text, this.car, x => x.CostRent, errorProvider);
        }

        public Car Car => car;

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
