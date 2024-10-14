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
            if (viewCarForm.ShowDialog(this) == DialogResult.OK)
            {
                //await peopleManager.AddAsync(personForm.Person);
                //bindingSource.ResetBindings(false);
                //SetStast();
            }
        }
    }
}
