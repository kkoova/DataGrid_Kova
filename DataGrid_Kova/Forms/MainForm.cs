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

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ViewAllCarsBtn_Click(object sender, EventArgs e)
        {
            var viewCarForm = new DataGridCarView();
            Hide();
            viewCarForm.ShowDialog();
        }

        private void ExitBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
