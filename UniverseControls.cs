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
    public partial class UniverseControls : SettingsControl
    {
        public UniverseControls()
        {
            InitializeComponent();
            restoreDefaults();
        }

        private void cbTorodial_CheckedChanged(object sender, EventArgs e)
        {
            cbFinite.Checked = !cbTorodial.Checked;
        }

        private void cbFinite_CheckedChanged(object sender, EventArgs e)
        {
            cbTorodial.Checked = !cbFinite.Checked;
        }

        /** 
        * Settings Abstract Functions
        **/

        new public void applySettings()
        {
            Properties.Settings.Default["UniSimSpeed"] = (int)numUniSimSpeed.Value;
            Properties.Settings.Default["UniWidth"] = (int)numUniWidth.Value;
            Properties.Settings.Default["UniHeight"] = (int)numUniHeight.Value;
            Properties.Settings.Default["UniBoundaryType"] = cbTorodial.Checked ? "Torodial" : "Finite";
        }

        new public void restoreDefaults()
        {
            numUniSimSpeed.Value = Properties.Settings.Default.UniSimSpeed;
            numUniWidth.Value = Properties.Settings.Default.UniWidth;
            numUniHeight.Value = Properties.Settings.Default.UniHeight;
            cbTorodial.Checked = Properties.Settings.Default.UniBoundaryType == "Torodial";
            cbFinite.Checked = Properties.Settings.Default.UniBoundaryType == "Fininte";
        }
    }
}
