using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CrossBike;
using HardTeilBike;
using MountainBike;
using WF2.BikeClasess;

namespace WF2
{
    public partial class CoreForm : Form
    {
        private int _bikeId = 1;
        private List<Bike> _bikes = new List<Bike>();
     
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
            AddBike ab = new AddBike(_bikeId);

            if (ab.ShowDialog() == DialogResult.OK)
            {
                var bike = ab.GetCreatedBike();
                _bikes.Add(bike);

                var item = new ListViewItem(bike.Name);
                item.SubItems.Add(bike.Size.ToString());
                item.SubItems.Add(_bikeId.ToString());

                lvBikes.Items.Add(item);

                _bikeId++;


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

        private void lvBikes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listView = (ListView)sender;
            if (listView.SelectedItems.Count > 0)
            {
                var listViewItem = listView.SelectedItems[0];

                int id = listViewItem.SubItems[2].Text.GetInt();

                foreach (var bike in _bikes)
                {
                    if (bike.Id == id)

                    {
                       var type = bike.GetType();
                        if (type.Name.Equals("Cross"))
                        {
                            scContent.Panel2.Controls.Clear();
                            scContent.Panel2.Controls.Add(new UcCross((Cross)bike) { Dock = DockStyle.Fill });
                            break;
                        }
                        else if (type.Name.Equals("HardTeil"))
                        {
                            scContent.Panel2.Controls.Clear();
                            scContent.Panel2.Controls.Add(new UcHardTeil((HardTeil)bike) { Dock = DockStyle.Fill });
                            break;
                        }
                        else if (type.Name.Equals("Mountain"))
                        {
                            scContent.Panel2.Controls.Clear();
                            scContent.Panel2.Controls.Add(new UcMountain((Mountain)bike) { Dock = DockStyle.Fill });
                            break;
                        }

                    }
                }
            }
        }

       
    }
}
