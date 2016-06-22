using System;
using System.Collections.Generic;
using System.IO;
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
        ListViewItem items;
        private int selected_id = 0;
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

                items = new ListViewItem(bike.Name);
                items.SubItems.Add(bike.Size.ToString());
                items.SubItems.Add(_bikeId.ToString());

                lvBikes.Items.Add(items);

                _bikeId++;


            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           var result =  MessageBox.Show("Are you shure want to delete this bike?", "Information", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                for(int i = items.ListView.SelectedItems.Count-1; i >= 0; i--)
                {
                    ListViewItem itm = lvBikes.SelectedItems[i];
                    lvBikes.Items[itm.Index].Remove();
                        //if (_bikes.Count != 0)
                        //{
                        //    //var list = items.ListView.SelectedItems[0];
                        //    this.lvBikes.SelectedItems.Clear();
                        //    //for (int i = 0; i <= _bikes.Count; i++)
                        //    //{
                        //    //    if (_bikes[i].Id == selected_id)
                        //    //    {
                        //    //        _bikes.RemoveAt(i);
                        //    //    }
                        //    //}
                        //    //list.Remove();
                    scContent.Panel2.Controls.Clear();
                }
            }
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

                selected_id = listViewItem.SubItems[2].Text.GetInt();

                foreach (var bike in _bikes)
                {
                    if (bike.Id == selected_id)

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

        private void saveToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream st = new FileStream(@"E:\study\ITA\base.txt", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(st);
            foreach (var bike in _bikes)
            {
                sw.Write(bike.ToString()+Environment.NewLine);
            }
            sw.Close();
            st.Close();
        }
    }
}
