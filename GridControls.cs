using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_of_Life
{
    public partial class GridControls : SettingsControl
    {
        public GridControls()
        {
            InitializeComponent();
            restoreDefaults();
            SettingsName = "Grid Options";
        }

        /** 
         * Listener Callback Functions 
         **/

        private void txtSegment_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Ignore invalid keypresses
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter && !validateSize(txtSegment.Text))
            {
                // Ensure the modified size is a proper number
                txtSegment.Text = ((int)Properties.Settings.Default["GridSegmentLines"]).ToString();
            }
        }
        
        private void txtGridLine_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Ignore invalid keypresses
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter && !validateSize(txtSegment.Text))
            {
                // Ensure the modified size is a proper number
                txtGridLine.Text = ((int)Properties.Settings.Default["GridLineThickness"]).ToString();
            }
        }

        private void txtSegThick_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Ignore invalid keypresses
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter && !validateSize(txtSegment.Text))
            {
                // Ensure the modified size is a proper number
                txtSegThick.Text = ((int)Properties.Settings.Default["GridSegmentThickness"]).ToString();
            }
        }

        private void txtGridLine_TextChanged(object sender, EventArgs e)
        {
            if (!validateSize(txtGridLine.Text))
                txtGridLine.Text = ((int)Properties.Settings.Default["GridLineThickness"]).ToString();
        }

        private void txtSegment_TextChanged(object sender, EventArgs e)
        {
            if (!validateSize(txtSegment.Text))
                txtSegment.Text = ((int)Properties.Settings.Default["GridSegmentLines"]).ToString();
        }

        private void txtSegThick_TextChanged(object sender, EventArgs e)
        {
            if (!validateSize(txtSegThick.Text))
                txtSegThick.Text = ((int)Properties.Settings.Default["GridSegmentThickness"]).ToString();
        }

        private void cbDisplayGrid_CheckedChanged(object sender, EventArgs e)
        {
            toggleGridOptions();
        }
       
        private void cbDisplaySegmentGridlines_CheckedChanged(object sender, EventArgs e)
        {
            toggleSegmentOptions();
        }

        /** 
         * Helper Functions
         **/

        ///<summary> Ensures every character within sizeStr is a digit.</summary>
        private bool validateSize(String sizeStr)
        {
            foreach (char c in sizeStr)
            {
                if (!char.IsControl(c) && !char.IsDigit(c))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary> Toggles grid settings based on if they are enabled or not. </summary>
        private void toggleGridOptions()
        {
            lbGridThickness.Enabled = cbDisplayGrid.Checked;
            lbGridThicknessPx.Enabled = cbDisplayGrid.Checked;
            txtGridLine.Enabled = cbDisplayGrid.Checked;
        }

        /// <summary> Toggles grid segment settings based on if they are enabled or not. </summary>
        private void toggleSegmentOptions()
        {
            lbSegEvery.Enabled = cbDisplaySegmentGridlines.Checked;
            lbSegLines.Enabled = cbDisplaySegmentGridlines.Checked;
            lbSegPx.Enabled = cbDisplaySegmentGridlines.Checked;
            lbSegThickness.Enabled = cbDisplaySegmentGridlines.Checked;
            txtSegment.Enabled = cbDisplaySegmentGridlines.Checked;
            txtSegThick.Enabled = cbDisplaySegmentGridlines.Checked;
        }

        /** 
         * Settings Abstract Functions
         **/

        new public void restoreDefaults()
        {
            txtSegment.Text = ((int)Properties.Settings.Default["GridSegmentLines"]).ToString();
            txtGridLine.Text = ((int)Properties.Settings.Default["GridLineThickness"]).ToString();
            txtSegThick.Text = ((int)Properties.Settings.Default["GridSegmentThickness"]).ToString();
            cbDisplayGrid.Checked = (bool)Properties.Settings.Default["EnableGridLines"];
            cbDisplaySegmentGridlines.Checked = (bool)Properties.Settings.Default["EnableSegmentLines"];
            cbDisplayNeighborCount.Checked = (bool)Properties.Settings.Default["ViewNeighborCount"];
            cbHeadsUpDisplay.Checked = (bool)Properties.Settings.Default["ViewHeadsUpDisplay"];
            toggleGridOptions();
            toggleSegmentOptions();
        }

        new public void applySettings()
        {
            Console.WriteLine("Writing Grid Controls...");
            Properties.Settings.Default["GridSegmentLines"] = int.Parse(txtSegment.Text);
            Properties.Settings.Default["GridLineThickness"] = int.Parse(txtGridLine.Text);
            Properties.Settings.Default["GridSegmentThickness"] = int.Parse(txtSegThick.Text);
            Properties.Settings.Default["EnableGridLines"] = cbDisplayGrid.Checked;
            Properties.Settings.Default["EnableSegmentLines"] = cbDisplaySegmentGridlines.Checked;
            Properties.Settings.Default["ViewNeighborCount"] = cbDisplayNeighborCount.Checked;
            Properties.Settings.Default["ViewHeadsUpDisplay"] = cbHeadsUpDisplay.Checked;
        }

    }
}
