using System;
using System.Windows.Forms;

namespace WF2
{
    public partial class AddBike : Form
    {
        private UcCross ucCross;
        private UcHardTeil ucHardTeil;
        private UcMountain ucMountain;

        public AddBike(int bikeId)
        {
            InitializeComponent();
            
            ucCross = new UcCross(bikeId);
            ucHardTeil = new UcHardTeil(bikeId);
            ucMountain = new UcMountain(bikeId);

            cbBikeType.Items.Add(BikeType.Cross);
            cbBikeType.Items.Add(BikeType.HardTeil);
            cbBikeType.Items.Add(BikeType.Mountain);
            cbBikeType.SelectedIndex = 0;
            
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
           BikeType type = (BikeType)Enum.Parse(
                typeof(BikeType), 
                cbBikeType.SelectedItem.ToString()
                );
            switch (type)
            {
                case BikeType.Cross:
                    panelContent.Controls.Clear();
                    panelContent.Controls.Add(ucCross);
                    break;
                case BikeType.HardTeil:
                    panelContent.Controls.Clear();
                    panelContent.Controls.Add(ucHardTeil);
                    
                    break;

                case BikeType.Mountain:
                    panelContent.Controls.Clear();
                    panelContent.Controls.Add(ucMountain);
                    
                    break;

                
            }
        }

        public Bike GetCreatedBike()
        {
            var type = GetSelectedBykeType();

            switch (type)
            {
                case BikeType.Cross:
                    return ucCross.GetCross();
                case BikeType.HardTeil:
                    return ucHardTeil.GetHardTeil();

                case BikeType.Mountain:
                    return ucMountain.GetMountain();
                default:
                    return null;

            }
        }

        private BikeType GetSelectedBykeType()
        {
            BikeType type = (BikeType) Enum.Parse(
                typeof (BikeType),
                cbBikeType.SelectedItem.ToString()
                );
            return type;
        }

        private void AddBike_FormClosing(object sender, FormClosingEventArgs e)
        {
            var eventSource = (Form)sender;
            if (eventSource.DialogResult != DialogResult.Cancel)
            {
                if (!ValidateControls())
                {
                    MessageBox.Show("Please input correct value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }
        }

        public bool ValidateControls()
        {
            var type = GetSelectedBykeType();
            switch (type)
            {
                case BikeType.Cross:
                    return ucCross.ValidateControls();

                case BikeType.HardTeil:
                    return ucHardTeil.ValidateControls();

                case BikeType.Mountain:
                    return ucMountain.ValidateControls();

                default:
                    return true;
            }
            
        }
    }
}
