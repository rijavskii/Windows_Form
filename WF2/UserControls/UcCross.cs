using System;
using System.Windows.Forms;

namespace WF2
{
    public partial class UcCross : UserControl
    {
        public UcCross()
        {
            InitializeComponent();

            cbColor.Items.Add(BikeColor.Blue);
            cbColor.Items.Add(BikeColor.Black);
            cbColor.Items.Add(BikeColor.Green);
            cbColor.Items.Add(BikeColor.Orange);
            cbColor.Items.Add(BikeColor.Red);
            cbColor.Items.Add(BikeColor.Yellow);
            cbColor.SelectedIndex = 2;
        }

        public Cross GetCross()
        {
          if(Validation())
            {
                return new Cross
                {
                    Color = cbColor.SelectedItem.ToString(),
                    Material = tbMaterial.Text,
                    Wheel = Convert.ToSingle(tbWheel.Text),
                    SpeedCount = Convert.ToInt32(tbSpeedCount.Text)
                };
            }
          else
            {
                return null;
            }

        }

        public bool Validation()
        {
            if ((tbMaterial.Text.Length > 0 ? true : false) &
                (tbSpeedCount.Text.Length > 0 ? true : false) &
                (tbWheel.Text.Length > 0 ? true : false))
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
