using System;
using System.Windows.Forms;

namespace WF2
{
    public partial class UcMountain : UserControl
    {
        public readonly int Id;
        public UcMountain(int bikeId)
        {
            InitializeComponent();

            SetColor();

            cbColor.SelectedIndex = 2;
            Id = bikeId;
        }

        private void SetColor()
        {
            cbColor.Items.Add(BikeColor.Blue);
            cbColor.Items.Add(BikeColor.Black);
            cbColor.Items.Add(BikeColor.Green);
            cbColor.Items.Add(BikeColor.Orange);
            cbColor.Items.Add(BikeColor.Red);
            cbColor.Items.Add(BikeColor.Yellow);
        }

        public UcMountain(Mountain bike)
        {
            InitializeComponent();
            SetColor();
            tbName.Text = bike.Name;
            tbSize.Text = bike.Size.ToString();
            tbBreakType.Text = bike.BreakType;
            tbWheelSize.Text = bike.WheelSize.ToString();
            cbColor.SelectedIndex = bike.Color;

            this.Enabled = false;
        }

        public Mountain GetMountain()
        {
            if (ValidateControls())
            {
                return new Mountain(Id)
                {
                    Name = tbName.Text,
                    Size = tbSize.Text.GetInt(),
                    Color = cbColor.SelectedIndex,
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
                (tbWheelSize.Text.Trim().GetInt()>5))
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
