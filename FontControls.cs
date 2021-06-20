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
    public partial class FontControls : UserControl
    {
        public FontControls()
        {
            InitializeComponent();
            restoreDefaults();
        }

        private void cmbNeighborFont_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            dlg.ShowColor = false;
            dlg.ShowApply = false;
            dlg.ShowHelp = false;
            dlg.ShowEffects = true;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                cmbNeighborFont.Text = dlg.Font.Name;
                cmbNeighborFont.Font = dlg.Font;
            }
        }

        internal void applySettings()
        {
            Properties.Settings.Default["FontNeighbors"] = cmbNeighborFont.Font;
        }

        internal void restoreDefaults()
        {
            cmbNeighborFont.Font = (Font)Properties.Settings.Default["FontNeighbors"];
            cmbNeighborFont.Text = cmbNeighborFont.Font.Name;
        }
    }
}
