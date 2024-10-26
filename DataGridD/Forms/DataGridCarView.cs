using Contracts;

namespace DataGridD.Forms
{
    public partial class DataGridCarView : Form
    {
        private readonly ICarManager carManager;

        /// <summary>
        /// Инициализация нового экземпляра <see cref="DataGridCarView" />
        /// </summary>
        /// <param name="carManager">Менеджер автомобилей для управления данными автомобилей</param>
        public DataGridCarView(ICarManager carManager)
        {
            this.carManager = carManager;

            InitializeComponent();
        }

        /// <summary>
        /// Обработчик события клика по кнопке добавления автомобиля
        /// Открывает форму добавления нового автомобиля и обновляет список автомобилей
        /// </summary>
        private async void AddBtn_Click(object sender, EventArgs e)
        {
            var addCarForm = new AddCarForm();
            if (addCarForm.ShowDialog(this) == DialogResult.OK)
            {
                await carManager.AddAsync(addCarForm.Car);
                await LoadCarCardsAsync();
            }
        }

        /// <summary>
        /// Загружает карточки автомобилей и отображает их в элементе управления
        /// </summary>
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

                    carCard.DeleteButtonClicked += async (s, e) =>
                    {
                        var result = MessageBox.Show($"Вы уверены, что хотите удалить {car.Carbrand}?",
                            "Удаление", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            await carManager.DeleteAsync(car.Id);
                            await LoadCarCardsAsync();
                        }
                    };

                    carCard.EditButtonClicked += async (s, e) =>
                    {
                        var editCarForm = new AddCarForm(car);

                        if (editCarForm.ShowDialog(this) == DialogResult.OK)
                        {
                            await carManager.EditAsync(editCarForm.Car);
                            await LoadCarCardsAsync();
                        }
                    };

                    flowLayoutPanel.Controls.Add(carCard);
                }
                await SetStats();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных автомобилей: {ex.Message}");
            }
        }

        /// <summary>
        /// Устанавливает статистику автомобилей и отображает ее на форме
        /// </summary>
        public async Task SetStats()
        {
            var result = await carManager.GetStatsAsync();
            AllAvto.Text = $"Всего машин: {result.CountCar}";
            FluelLow.Text = $"Машин с критическим уровнем топлива (<7): {result.CarLowFlue}";
        }

        /// <summary>
        /// Обработчик события загрузки формы. Устанавливает статистику автомобилей
        /// </summary>
        private async void DataGridCarView_Load(object sender, EventArgs e)
        {
            await SetStats();
        }
    }
}
