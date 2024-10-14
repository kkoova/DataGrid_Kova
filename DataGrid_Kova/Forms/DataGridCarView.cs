using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGrid_Kova.Forms
{
    public partial class DataGridCarView : Form
    {
        public DataGridCarView()
        {
            InitializeComponent();

            CreateCarCard("Koenigsegg", "Sport", "$99.00/day", Properties.Resources.car_1);
            CreateCarCard("Nissan GT-R", "Sport", "$99.00/day", Properties.Resources.car_1);
            CreateCarCard("Rolls-Royce", "Sedan", "$99.00/day", Properties.Resources.car_1);

            ExitBtn.FlatStyle = FlatStyle.Flat;
            ExitBtn.BackColor = Color.Transparent;
            ExitBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            ExitBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void CreateCarCard(string carbrand, string carNumber, string Mileage, Image carImage)
        {
            CarCard carCard = new()
            {
                Carbrand = carbrand,
                Number = carNumber,
                Mileage = Mileage,
                CarImage = carImage
            };

            flowLayoutPanel.Controls.Add(carCard);
        }

    }
}
