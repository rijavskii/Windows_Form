using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

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
                AddBikeToListView(bike);

                _bikeId++;


            }
        }

        private void AddBikeToListView(Bike bike)
        {
            _bikes.Add(bike);

            items = new ListViewItem(bike.Name);
            items.SubItems.Add(bike.Size.ToString());
            items.SubItems.Add(bike.Id.ToString());

            lvBikes.Items.Add(items);
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
                    _bikes.RemoveAll( bike => bike.Id == itm.SubItems[2].Text.GetInt());
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
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text files|*.txt";
            openFile.Multiselect = false;
            openFile.InitialDirectory = Directory.GetCurrentDirectory();

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string fileText = File.ReadAllText(openFile.FileName);
                List<string> stringBikes = fileText.Split(Environment.NewLine.ToCharArray(),
                    StringSplitOptions.RemoveEmptyEntries).ToList();
                _bikes.Clear();

                foreach (var stringBike in stringBikes)
                {
                    var stringBikeType = stringBike.Split('♫').ToList()[4];

                    BikeType type;
                    Enum.TryParse(stringBikeType, true, out type);

                    switch (type)
                    {
                        case BikeType.Cross:
                            Cross bike;
                            if(Cross.TryParse(stringBike, out bike))
                            {
                                AddBikeToListView(bike);
                            }
                            break;
                        case BikeType.HardTeil:
                            HardTeil hardTeil;
                            if (HardTeil.TryParse(stringBike, out hardTeil))
                            {
                                AddBikeToListView(hardTeil);
                            }
                            break;
                        case BikeType.Mountain:
                            Mountain mountainBike;
                            if (Mountain.TryParse(stringBike, out mountainBike))
                            {
                                AddBikeToListView(mountainBike);
                            }
                            break;
                    }
                }
            } 
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
                        scContent.Panel2.Controls.Clear();
                        if (type.Name.Equals("Cross"))
                        {
                            scContent.Panel2.Controls.Add(new UcCross((Cross)bike) { Dock = DockStyle.Fill });
                            break;
                        }
                        else if (type.Name.Equals("HardTeil"))
                        {
                            scContent.Panel2.Controls.Add(new UcHardTeil((HardTeil)bike) { Dock = DockStyle.Fill });
                            break;
                        }
                        else if (type.Name.Equals("Mountain"))
                        {
                            scContent.Panel2.Controls.Add(new UcMountain((Mountain)bike) { Dock = DockStyle.Fill });
                            break;
                        }

                    }
                }
            }
        }

        private void saveToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            try
            {
                //SaveToFileSimple();
                SerializeToFile();
                MessageBox.Show("","",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void SaveToFileSimple()
        {
            try
            {
                string result = _bikes.Aggregate(String.Empty, (current, bike) => current + (bike + Environment.NewLine));

                File.WriteAllText(@"E:\study\ITA\base.txt", result);
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

        private void saveToFileStreamSafe()
        {
            try
            {
                 using (Stream st = new FileStream(@"E:\study\ITA\base.txt", FileMode.CreateNew))
                {
                    using (StreamWriter sw = new StreamWriter(st))
                    {
                        foreach (var bike in _bikes)
                        {
                            sw.Write(bike + Environment.NewLine);
                        }
                        sw.Close();
                    }
                    st.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBikes aboutBikes = new AboutBikes();
            aboutBikes.ShowDialog();
        }

        public void SerializeToFile()
        {
            using (var stream = new FileStream((@"E:\study\ITA\ser.txt"), FileMode.OpenOrCreate))
            {
                var serializer = new XmlSerializer(typeof (List<Bike>),
                new[] { typeof (Cross), typeof (HardTeil), typeof (Mountain)});
                serializer.Serialize(stream, _bikes);
            }
        }

        public void DeSerializeFromFile(string filename)
        {
            if(File.Exists(filename))
            using (var stream = new FileStream((@"E:\study\ITA\ser.txt"), FileMode.OpenOrCreate))
            {
                var serializer = new XmlSerializer(typeof(List<Bike>),
                new[] { typeof(Cross), typeof(HardTeil), typeof(Mountain) });
                _bikes =(List<Bike>) serializer.Deserialize(stream);
            }
        }
    }
}
