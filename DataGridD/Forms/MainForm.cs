using DataGridD.Forms;
using CarManagerData;
using Microsoft.Extensions.Logging;
using MemoryStorage;

namespace DataGridD
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Инициализация нового экземпляра <see cref="MainForm" />.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик события клика по кнопке "Просмотреть все автомобили".
        /// Создает экземпляр <see cref="MemoryCarStorage"/> и <see cref="CarManager"/>,
        /// затем открывает форму для отображения всех автомобилей.
        /// </summary>
        private void ViewAllCarsBtn_Click(object sender, EventArgs e)
        {
            var factory = LoggerFactory.Create(bilder => bilder.AddDebug());
            var logger = factory.CreateLogger(typeof(MainForm));

            var storage = new MemoryCarStorage();
            var manager = new CarManager(storage, logger);

            var viewCarForm = new DataGridCarView(manager);
            Hide();
            viewCarForm.ShowDialog();
        }

        /// <summary>
        /// Обработчик события клика по кнопке "Выход".
        /// Завершает работу приложения.
        /// </summary>
        private void ExitBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
