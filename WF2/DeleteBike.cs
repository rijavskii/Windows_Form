using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CrossBike;
using HardTeilBike;
using MountainBike;
using WF2.BikeClasess;

namespace WF2
{
    public partial class DeleteBike : Form
    {
        private List<Bike> _bikes;
        
        public DeleteBike(List<Bike> delBikes)
        {
            InitializeComponent();

            _bikes = delBikes;
        }

        private void btShow_Click(object sender, EventArgs e)
        {
            if (tbBikeId.Text.Trim() != String.Empty)
            {
                foreach (var bike in _bikes)
                {
                    if (bike.Id == tbBikeId.Text.GetInt())
                    {
                        var type = bike.GetType();
                        if (type.Name.Equals("Cross"))
                        {
                            panelBike.Controls.Clear();
                            panelBike.Controls.Add(new UcCross((Cross)bike) { Dock = DockStyle.Fill });
                            break;
                        }
                        else if (type.Name.Equals("HardTeil"))
                        {
                            panelBike.Controls.Clear();
                            panelBike.Controls.Add(new UcHardTeil((HardTeil)bike) { Dock = DockStyle.Fill });
                            break;
                        }
                        else if (type.Name.Equals("Mountain"))
                        {
                            panelBike.Controls.Clear();
                            panelBike.Controls.Add(new UcMountain((Mountain)bike) { Dock = DockStyle.Fill });
                            break;
                        }


                    }
                    
                }
            }
        }
    }
}
