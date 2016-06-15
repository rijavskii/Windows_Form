using System;
using System.Windows.Forms;
using BikesHometask;


namespace WF2
{
    public partial class AddBike : Form
    {
        private UcCross ucCross = new UcCross();
        private UcHardTeil ucHardTeil = new UcHardTeil();
        private UcMountain ucMountain = new UcMountain();

        public AddBike()
        {
            InitializeComponent();
            
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
            BikeType type = (BikeType)Enum.Parse(
                typeof(BikeType),
                cbBikeType.SelectedItem.ToString()
                );

            switch (type)
            {
                case BikeType.Cross:
                    return ucCross.GetCross();
                case BikeType.HardTeil:
                    return ucHardTeil.GetHardTeil();

                case BikeType.Mountain:
                    return ucCross.GetCross();

                default:
                    return null;

            }
        }
    }
}
