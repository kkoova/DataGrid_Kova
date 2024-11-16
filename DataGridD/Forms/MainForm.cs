using DataGridD.Forms;
using CarManagerData;
using Microsoft.Extensions.Logging;
using MemoryStorage;
using Serilog;
using Serilog.Extensions.Logging;

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
            var seriloglogger = new LoggerConfiguration()
            .MinimumLevel.Verbose()
            .WriteTo.Seq("", apiKey: "") //seq
            .CreateLogger();

            var logger = new SerilogLoggerFactory(seriloglogger)
                .CreateLogger("DataGridD");

            var storage = new DataBaseCarStorage();
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
