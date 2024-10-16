using DataGrid.CarManager;
using DataGrid.Memory;
using DataGrid_Kova.Forms;
using System.Windows.Forms;

namespace DataGrid_Kova
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ViewAllCarsBtn_Click(object sender, EventArgs e)
        {
            var storage = new MemoryCarStorage();
            var manager = new CarManager(storage);

            var viewCarForm = new DataGridCarView(manager);
            Hide();
            viewCarForm.ShowDialog();
        }

        private void ExitBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
