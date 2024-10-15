using DataGrid.Contracts;

namespace DataGrid_Kova.Forms
{
    public partial class DataGridCarView : Form
    {
        private readonly ICarManager carManager;

        public DataGridCarView(ICarManager carManager)
        {
            this.carManager = carManager;
            bindingSource = [];

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

        private async void AddBtn_Click(object sender, EventArgs e)
        {
            var addCar = new AddCarForm();
            if (addCar.ShowDialog(this) == DialogResult.OK)
            {
                await carManager.AddAsync(addCar.Car);
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
