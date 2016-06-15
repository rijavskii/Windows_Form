using System;
using System.Windows.Forms;

namespace WF2
{
    public partial class CoreForm : Form
    {
        public CoreForm()
        {
            InitializeComponent();
            //scContent.Panel2.Controls.Add(new ucCross());
           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBike ab = new AddBike();
            if (ab.ShowDialog() == DialogResult.OK)
            {
                lvBikes.Items.Add(ab.GetCreatedBike().ToString());
                lvBikes.Items.Add(ab.GetCreatedBike().Color );
                
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openSavedToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CoreForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Good bye!", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
