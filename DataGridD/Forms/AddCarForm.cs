using BindingLibraryKova;
using Contracts.Models;
using DataGridD.Logic;

namespace DataGridD.Forms
{
    public partial class AddCarForm : Form
    {
        private readonly Car car;

        /// <summary>
        /// Создает новый экземпляр формы добавления или редактирования автомобиля
        /// </summary>
        /// <param name="car">Автомобиль для редактирования. Если null, создается новый автомобиль</param>
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
            addBtn.DialogResult = DialogResult.OK;

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
            RentalPriceText.AddBinding(x => x.Text, this.car, x => x.AverageFuelConsumption, errorProvider);
            CostRentText.AddBinding(x => x.Text, this.car, x => x.CostRent, errorProvider);
        }

        /// <summary>
        /// Возвращает автомобиль, связанный с данной формой
        /// </summary>
        public Car Car => car;
    }
}
