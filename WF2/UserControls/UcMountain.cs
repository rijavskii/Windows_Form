using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MountainBike;

namespace WF2
{
    public partial class UcMountain : UserControl
    {
        public readonly int Id;
        public UcMountain(int bikeId)
        {
            InitializeComponent();

            cbColor.Items.Add(BikeColor.Blue);
            cbColor.Items.Add(BikeColor.Black);
            cbColor.Items.Add(BikeColor.Green);
            cbColor.Items.Add(BikeColor.Orange);
            cbColor.Items.Add(BikeColor.Red);
            cbColor.Items.Add(BikeColor.Yellow);

            cbColor.SelectedIndex = 2;
            Id = bikeId;
        }

        public UcMountain(Mountain bike)
        {
            InitializeComponent();

            tbName.Text = bike.Name;
            tbSize.Text = bike.Size.ToString();
            tbBreakType.Text = bike.BreakType;
            tbWheelSize.Text = bike.WheelSize.ToString();
            cbColor.SelectedItem = bike.Color;

            this.Enabled = false;
        }

        public Mountain GetMountain()
        {
            if (ValidateControls())
            {
                return new Mountain(Id)
                {
                    Name = tbName.Text,
                    Size = tbName.Text.GetInt(),
                    WheelSize = tbWheelSize.Text.GetInt(),
                    BreakType = tbBreakType.Text
                };
            }
            else
            {
                return null;
            }
        }

        public bool ValidateControls()
        {
            if ((tbName.Text.Trim() != String.Empty) &
                (tbSize.Text.Trim() != String.Empty) &
                (tbBreakType.Text.Trim() != String.Empty)&
                (tbWheelSize.Text.Trim().GetInt()<10))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


       
    }
}
