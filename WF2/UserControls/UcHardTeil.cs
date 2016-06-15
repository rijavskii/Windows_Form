using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF2
{
    public partial class UcHardTeil : UserControl
    {
        public UcHardTeil()
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


        public HardTeil GetHardTeil()
        {
            return new HardTeil
            {
                Color = cbColor.SelectedText,
                Material = tbMaterial.ToString(),
                Size = Convert.ToInt32(tbSize),
                ForkType = tbForkType.ToString()
            };

        }
    }

}
