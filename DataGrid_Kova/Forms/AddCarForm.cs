using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataGrid_Kova.Models;

namespace DataGrid_Kova.Forms
{
    public partial class AddCarForm : Form
    {
        public AddCarForm()
        {
            InitializeComponent();
            SetButtonStyles();

            foreach (var item in Enum.GetValues(typeof(Brand)))
            {
                brandcomboBox.Items.Add(item);
            }
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
    }
}
