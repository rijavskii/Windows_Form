using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class CoreForm : Form
    {
        public CoreForm()
        {
            InitializeComponent();
        }

        private void ShowDate_Click(object sender, EventArgs e)
        {
            var date = dtpDateNow.Value;
            MessageBox.Show(date.ToString("yy-MM-d dddd"), "Information",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void Data_MouseHover(object sender, EventArgs e)
        {
            this.Data.ForeColor = Color.Blue;
        }

        private void Data_MouseLeave(object sender, EventArgs e)
        {
            this.Data.ForeColor = Color.Black;
        }
    }
}
