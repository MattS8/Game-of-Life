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
    public partial class HeadsUpDisplay : UserControl
    {
        MainWindow mainWindow;
        public HeadsUpDisplay(MainWindow mw)
        {
            mainWindow = mw;
            InitializeComponent();
        }

        public void UpdateHUD(int generation, int cellCount, string boundaryType, string uniName, string uniSize, int cellsAlive, int cellsDead)
        {
            lbCurrentGen.ForeColor = Properties.Settings.Default.ColorCurrentGen;
            lbCurrentGen.Font = Properties.Settings.Default.FontGen;
            
            lbCellCount.Font = Properties.Settings.Default.FontCellCount;
            lbCellCount.ForeColor = Properties.Settings.Default.ColorCellCount;
            lbBoundaryType.Font = Properties.Settings.Default.FontBoundaryType;
            lbBoundaryType.ForeColor = Properties.Settings.Default.ColorBoundaryType;
            lbUniverseName.Font = Properties.Settings.Default.FontUniName;
            lbUniverseName.ForeColor = Properties.Settings.Default.ColorUniName;
            lbUnivSize.Font = Properties.Settings.Default.FontUniSize;
            lbUnivSize.ForeColor = Properties.Settings.Default.ColorUniSize;
            lbAlive.Font = Properties.Settings.Default.FontCellsAlive;
            lbAlive.ForeColor = Properties.Settings.Default.ColorCellCountAlive;
            lbDead.Font = Properties.Settings.Default.FontCellsDead;
            lbDead.ForeColor = Properties.Settings.Default.ColorCellCountDead;

            lbCurrentGen.Text = "Genration: " + generation.ToString();
            lbCellCount.Text = "Cell Count: " + cellCount.ToString();
            lbBoundaryType.Text = "Boundary Type: " + boundaryType;
            lbUniverseName.Text = "Universe Name: " + uniName;
            lbUnivSize.Text = "Size: " + uniSize;
            lbAlive.Text = "Alive Cells: " + cellsAlive.ToString();
            lbDead.Text = "Dead Cells: " + cellsDead.ToString();
        }

        /** These functions pass through mouse clicks down to the
         *  graphics panel. Without these, clicks intended to turn
         *  on/off cells would be ignored when the HUD is displayed.
         **/  

        private void PassThrough_MouseClick(object sender, MouseEventArgs e)
        {
            mainWindow.graphicsPanel1_MouseClick(sender, e);
        }

        private void PassThrough_Click(object sender, EventArgs e)
        {
            
        }
    }
}
