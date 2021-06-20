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
    public partial class RandomizationControls : UserControl
    {
        public bool randomizationChanged;
        public RandomizationControls()
        {
            InitializeComponent();
            restoreDefaults();
            randomizationChanged = false;
        }

        private void cbUniverseSeed_CheckedChanged(object sender, EventArgs e)
        {
            numSeed.Enabled = cbUniverseSeed.Checked;
            cbTimeSeed.Checked = !cbUniverseSeed.Checked;
        }

        private void numAlive_ValueChanged(object sender, EventArgs e)
        {
            numDead.Value = 100 - numAlive.Value;
        }

        private void numDead_ValueChanged(object sender, EventArgs e)
        {
            numAlive.Value = 100 - numDead.Value;
        }

        internal void restoreDefaults()
        {
            cbUniverseSeed.Checked = Properties.Settings.Default.UseSeed;
            cbTimeSeed.Checked = !cbUniverseSeed.Checked;
            numAlive.Value = Properties.Settings.Default.RandAlive;
            numDead.Value = Properties.Settings.Default.RandDead;
            numSeed.Value = Properties.Settings.Default.RandSeed;
            numSeed.Enabled = cbUniverseSeed.Checked;

        }

        internal void applySettings()
        {
            randomizationChanged = false;
            if (Properties.Settings.Default.UseSeed != cbUniverseSeed.Checked)
            {
                Properties.Settings.Default.UseSeed = cbUniverseSeed.Checked;
                randomizationChanged = true;
            }
            if (Properties.Settings.Default.RandSeed != (uint)numSeed.Value)
            {
                Properties.Settings.Default.RandSeed = (uint)numSeed.Value;
                randomizationChanged = true;
            }
            Properties.Settings.Default.RandAlive = (int)numAlive.Value;
            Properties.Settings.Default.RandDead = (int)numDead.Value;
        }

        private void cbTimeSeed_CheckChanged(object sender, EventArgs e)
        {
            cbUniverseSeed.Checked = !cbTimeSeed.Checked;
            numSeed.Enabled = !cbTimeSeed.Checked;
        }
    }
}
