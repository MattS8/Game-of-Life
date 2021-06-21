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
    public partial class FontControls : SettingsControl
    {
        public FontControls()
        {
            InitializeComponent();
            restoreDefaults();
        }

        /** 
        * Listener Callback Functions 
        **/

        private void cmbGen_Click(object sender, EventArgs e)
        {
            getFont(cmbGen);
        }

        private void cmbNeighborFont_Click(object sender, EventArgs e)
        {
            getFont(cmbNeighborFont);
        }

        private void cmbCellCount_Click(object sender, EventArgs e)
        {
            getFont(cmbCellCount);
        }

        private void cmbBoundaryType_Click(object sender, EventArgs e)
        {
            getFont(cmbBoundaryType);
        }

        private void cmbUniName_Click(object sender, EventArgs e)
        {
            getFont(cmbUniName);
        }

        private void cmbUniSize_Click(object sender, EventArgs e)
        {
            getFont(cmbUniSize);
        }

        private void cmbAlive_Click(object sender, EventArgs e)
        {
            getFont(cmbAlive);
        }

        private void CmbDead_Click(object sender, EventArgs e)
        {
            getFont(CmbDead);
        }

        /** 
         * Helper Functions
         **/

        private void getFont(ComboBox cmb)
        {
            FontDialog dlg = new FontDialog();
            dlg.ShowColor = false;
            dlg.ShowApply = false;
            dlg.ShowHelp = false;
            dlg.ShowEffects = true;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                cmb.Text = dlg.Font.Name;
                cmb.Font = dlg.Font;
            }
        }

        /** 
         * Settings Abstract Functions
         **/

        new public void applySettings()
        {
            Properties.Settings.Default["FontNeighbors"] = cmbNeighborFont.Font;
            Properties.Settings.Default["FontGen"] = cmbGen.Font;
            Properties.Settings.Default["FontCellCount"] = cmbCellCount.Font;
            Properties.Settings.Default["FontBoundaryType"] = cmbBoundaryType.Font;
            Properties.Settings.Default["FontBoundaryType"] = cmbBoundaryType.Font;
            Properties.Settings.Default["FontUniName"] = cmbUniName.Font;
            Properties.Settings.Default["FontUniSize"] = cmbUniSize.Font;
            Properties.Settings.Default["FontCellsAlive"] = cmbAlive.Font;
            Properties.Settings.Default["FontCellsDead"] = CmbDead.Font;
        }

        new public void restoreDefaults()
        {
            cmbNeighborFont.Font = (Font)Properties.Settings.Default["FontNeighbors"];
            cmbNeighborFont.Text = cmbNeighborFont.Font.Name;
            cmbGen.Font = (Font)Properties.Settings.Default["FontGen"];
            cmbGen.Text = cmbNeighborFont.Font.Name;
            cmbCellCount.Font = (Font)Properties.Settings.Default["FontCellCount"];
            cmbCellCount.Text = cmbNeighborFont.Font.Name;
            cmbBoundaryType.Font = (Font)Properties.Settings.Default["FontBoundaryType"];
            cmbBoundaryType.Text = cmbNeighborFont.Font.Name;
            cmbUniName.Font = (Font)Properties.Settings.Default["FontUniName"];
            cmbUniName.Text = cmbNeighborFont.Font.Name;
            cmbUniSize.Font = (Font)Properties.Settings.Default["FontUniSize"];
            cmbUniSize.Text = cmbNeighborFont.Font.Name;

            cmbAlive.Font = (Font)Properties.Settings.Default["FontCellsAlive"];
            cmbAlive.Text = cmbAlive.Font.Name;
            CmbDead.Font = (Font)Properties.Settings.Default["FontCellsDead"];
            CmbDead.Text = CmbDead.Font.Name;
        }
    }
}
