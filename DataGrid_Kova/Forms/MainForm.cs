using DataGrid.CarManager;
using DataGrid.Memory;
using DataGrid_Kova.Forms;
using System.Windows.Forms;

namespace DataGrid_Kova
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
            var storage = new MemoryCarStorage();
            var manager = new CarManager(storage);

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
