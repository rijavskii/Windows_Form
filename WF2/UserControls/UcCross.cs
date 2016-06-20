using System;
using System.Windows.Forms;
using CrossBike;

namespace WF2
{
    public partial class UcCross : UserControl
    {
        private readonly int Id;

        public UcCross(int bikeId)
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

        public UcCross(Cross bCross)
        {
            InitializeComponent();

            tbName.Text = bCross.Name;
            tbSize.Text = bCross.Size.ToString();
            tbWheel.Text = bCross.Wheel.ToString();
            tbSpeedCount.Text = bCross.SpeedCount.ToString();
            cbColor.SelectedItem = bCross.Color;
            this.Enabled = false;
        }

        public Cross GetCross()
        {
          if(ValidateControls())
            {
                return new Cross(Id)
                {
                    Name = tbName.Text,
                    Size = tbName.Text.GetInt(),
                    Wheel = tbSize.Text.GetInt(),
                    SpeedCount = Convert.ToInt32(tbSpeedCount.Text)
                };
            }
          else
            {
                return null;
            }

        }

        public bool ValidateControls()
        {
            if ((tbName.Text.Trim() !=  String.Empty ? true : false) &
                (tbSpeedCount.Text.Trim() != String.Empty ? true : false) &
                (tbSize.Text.Trim() != String.Empty ? true : false))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void UcCross_Load(object sender, EventArgs e)
        {

        }
    }
}
