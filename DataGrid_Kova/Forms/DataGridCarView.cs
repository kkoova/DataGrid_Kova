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
            SetButtonStyles();
        }

        private void CreateCarCard(string carbrand, string carNumber, string Mileage, Image carImage)
        {

            CarCard carCard = new()
            {
                //Carbrand = carbrand,
                //Number = carNumber,
                //Mileage = Mileage,
                //CarImage = carImage
            };

            flowLayoutPanel.Controls.Add(carCard);
        }

        private void SetButtonStyles()
        {
            foreach (Control control in this.Controls)
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

        private void button1_Click(object sender, EventArgs e)
        {
            var addCar = new AddCarForm();
            if (addCar.ShowDialog() == DialogResult.Cancel)
            {
                CreateCarCard("Koenigsegg", "Sport", "$99.00/day", Properties.Resources.car_1);
            }
        }

        private void ExitBtn_Click_1(object sender, EventArgs e)
        {
            var main = new MainForm();
            main.Show();
            Close();
        }
    }
}
