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
    /// <summary>
    /// This is the base class used for all sections within the settings menu.
    /// It controls logic for saving, restoring, and keeping the Settings synced
    /// with the respective UI menu.
    /// </summary>
    public partial class SettingsControl : UserControl, ISettingsControl
    {
        public string SettingsName;

        /// <summary>
        /// Saves all settings from the control to Properties.Settings.
        /// </summary>
        public void applySettings() { }

        /// <summary>
        /// Applies the proper visuals for the settings currently saved
        /// within Properties.Settings.
        /// </summary>
        public void restoreDefaults() { }
    }
}
