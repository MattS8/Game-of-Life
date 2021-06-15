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
    public partial class PanelColorsControls : UserControl
    {
        public PanelColorsControls()
        {
            InitializeComponent();
            restoreDefaults();
        }

        private void lbPanelBG_Click(object sender, EventArgs e)
        {
            getColor(btnColorPanelBG);
        }

        private void btnColorPanelBG_Click(object sender, EventArgs e)
        {
            getColor(btnColorPanelBG);
        }

        private void getColor(Button btn)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (DialogResult.OK == colorDialog.ShowDialog())
            {
                btn.BackColor = colorDialog.Color;
            }
        }

        private void lbSegColor_Click(object sender, EventArgs e)
        {
            getColor(btnSegColor);
        }

        private void btnSegColor_Click(object sender, EventArgs e)
        {
            getColor(btnSegColor);
        }

        private void lbDeadCellBG_Click(object sender, EventArgs e)
        {
            getColor(btnDeadCellBG);
        }

        internal void applySettings()
        {
            Properties.Settings.Default["ColorPanelBG"] = btnColorPanelBG.BackColor;
            Properties.Settings.Default["ColorGridLine"] = btnGridColor.BackColor;
            Properties.Settings.Default["ColorGridSegment"] = btnSegColor.BackColor;
            Properties.Settings.Default["ColorCellDead"] = btnDeadCellBG.BackColor;
            Properties.Settings.Default["ColorCellAlive"] = btnAliveCellBG.BackColor;
        }

        internal void restoreDefaults()
        {
            btnColorPanelBG.BackColor = (Color)Properties.Settings.Default["ColorPanelBG"];
            btnGridColor.BackColor = (Color)Properties.Settings.Default["ColorGridLine"];
            btnSegColor.BackColor = (Color)Properties.Settings.Default["ColorGridSegment"];
            btnDeadCellBG.BackColor = (Color)Properties.Settings.Default["ColorCellDead"];
            btnAliveCellBG.BackColor = (Color)Properties.Settings.Default["ColorCellAlive"];
        }

        private void btnDeadCellBG_Click(object sender, EventArgs e)
        {
            getColor(btnDeadCellBG);
        }

        private void lbAliveCellBG_Click(object sender, EventArgs e)
        {
            getColor(btnAliveCellBG);
        }

        private void btnAliveCellBG_Click(object sender, EventArgs e)
        {
            getColor(btnAliveCellBG);
        }

        private void lbGridColor_Click(object sender, EventArgs e)
        {
            getColor(btnGridColor);
        }

        private void btnGridColor_Click(object sender, EventArgs e)
        {
            getColor(btnGridColor);
        }
    }
}
