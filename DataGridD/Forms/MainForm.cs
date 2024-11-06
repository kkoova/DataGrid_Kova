using DataGridD.Forms;
using CarManagerData;
using Microsoft.Extensions.Logging;
using MemoryStorage;

namespace DataGridD
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// ������������� ������ ���������� <see cref="MainForm" />.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ���������� ������� ����� �� ������ "����������� ��� ����������".
        /// ������� ��������� <see cref="MemoryCarStorage"/> � <see cref="CarManager"/>,
        /// ����� ��������� ����� ��� ����������� ���� �����������.
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
        /// ���������� ������� ����� �� ������ "�����".
        /// ��������� ������ ����������.
        /// </summary>
        private void ExitBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
