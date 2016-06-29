using System;
using System.Windows.Forms;

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

            cbColor.Items.Add(BikeColor.Blue);
            cbColor.Items.Add(BikeColor.Black);
            cbColor.Items.Add(BikeColor.Green);
            cbColor.Items.Add(BikeColor.Orange);
            cbColor.Items.Add(BikeColor.Red);
            cbColor.Items.Add(BikeColor.Yellow);

            tbName.Text = bCross.Name;
            tbSize.Text = bCross.Size.ToString();
            tbWheel.Text = bCross.Wheel.ToString();
            tbSpeedCount.Text = bCross.SpeedCount.ToString();
            cbColor.SelectedIndex = bCross.Color;
            this.Enabled = false;
        }

        public Cross GetCross()
        {
          if(ValidateControls())
            {
                return new Cross(Id)
                {
                    Name = tbName.Text,
                    Size = tbSize.Text.GetInt(),
                    Wheel = tbWheel.Text.GetFloat(),
                    SpeedCount = tbSpeedCount.Text.GetInt(),
                    Color = cbColor.SelectedIndex
                };
            }
          else
            {
                return null;
            }

        }

        public bool ValidateControls()
        {
            if ((tbName.Text.Trim() !=  String.Empty) &
                (tbSpeedCount.Text.Trim() != String.Empty) &
                (tbSize.Text.Trim() != String.Empty) &
                (tbWheel.Text.Trim() != String.Empty))
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
