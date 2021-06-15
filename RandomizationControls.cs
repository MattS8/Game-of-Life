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
        public RandomizationControls()
        {
            InitializeComponent();
            restoreDefaults();
        }

        private void cbUniverseSeed_CheckedChanged(object sender, EventArgs e)
        {
            numSeed.Enabled = cbUniverseSeed.Checked;
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
            numAlive.Value = Properties.Settings.Default.RandAlive;
            numDead.Value = Properties.Settings.Default.RandDead;
            numSeed.Value = Properties.Settings.Default.RandSeed;
            numSeed.Enabled = cbUniverseSeed.Checked;
        }

        internal void applySettings()
        {
            Properties.Settings.Default.UseSeed = cbUniverseSeed.Checked;
            Properties.Settings.Default.RandAlive = (int)numAlive.Value;
            Properties.Settings.Default.RandDead = (int)numDead.Value;
            Properties.Settings.Default.RandSeed = (uint)numSeed.Value;
        }
    }
}
