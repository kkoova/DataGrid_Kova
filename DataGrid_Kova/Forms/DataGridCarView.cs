using DataGrid.Contracts;

namespace DataGrid_Kova.Forms
{
    public partial class DataGridCarView : Form
    {
        private readonly ICarManager carManager;

        /// <summary>
        /// Инициализация нового экземпляра <see cref="DataGridCarView" />
        /// </summary>
        /// <param name="carManager"></param>
        public DataGridCarView(ICarManager carManager)
        {
            this.carManager = carManager;

            InitializeComponent();
            SetButtonStyles();
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
                await LoadCarCardsAsync();
            }
        }

        private async Task LoadCarCardsAsync()
        {
            try
            {
                var cars = await carManager.GetAllAsync();

                flowLayoutPanel.Controls.Clear();

                foreach (var car in cars)
                {
                    var carCard = new CarCard();

                    carCard.SetCar(car);

                    flowLayoutPanel.Controls.Add(carCard);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных автомобилей: {ex.Message}");
            }
        }
    }
}
