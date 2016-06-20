using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HardTeilBike;

namespace WF2
{
    public partial class UcHardTeil : UserControl
    {
        private readonly int Id;

        public UcHardTeil(int bikeId)
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

        public UcHardTeil(HardTeil hardTeil)
        {
            InitializeComponent();

            tbName.Text = hardTeil.Name;
            tbMaterial.Text = hardTeil.Material;
            cbColor.SelectedItem = hardTeil.Color;
            tbSize.Text = hardTeil.Size.ToString();
            tbForkType.Text = hardTeil.ForkType;
            this.Enabled = false;
        }

        public HardTeil GetHardTeil()
        {
            if (ValidateControls())
            {
                return new HardTeil(Id)
                {
                    Name = tbName.Text,
                    Color = cbColor.SelectedText,
                    Material = tbMaterial.Text,
                    Size = Convert.ToInt32(tbSize.Text),
                    ForkType = tbForkType.Text
                };
            }
            else
            {
                return null;
            }

        }

        public bool ValidateControls()
        {
            if ((tbName.Text.Trim() != String.Empty ) &
                (tbSize.Text.Trim() != String.Empty ) &
                (tbMaterial.Text.Trim() != String.Empty)&
                (tbForkType.Text.Trim() != String.Empty))
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
