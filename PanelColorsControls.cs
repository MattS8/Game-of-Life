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
            Properties.Settings.Default["Color1Neighbor"] = btn1Neighbor.BackColor;
            Properties.Settings.Default["Color2Neighbor"] = btn2Neighbor.BackColor;
            Properties.Settings.Default["Color3Neighbor"] = btn3Neighbor.BackColor;
            Properties.Settings.Default["Color4Neighbor"] = btn4Neighbor.BackColor;
            Properties.Settings.Default["Color5Neighbor"] = btn5Neighbor.BackColor;
            Properties.Settings.Default["Color6Neighbor"] = btn6Neighbor.BackColor;
            Properties.Settings.Default["Color7Neighbor"] = btn7Neighbor.BackColor;
            Properties.Settings.Default["Color8Neighbor"] = btn8Neighbor.BackColor;
        }

        internal void restoreDefaults()
        {
            btnColorPanelBG.BackColor = (Color)Properties.Settings.Default["ColorPanelBG"];
            btnGridColor.BackColor = (Color)Properties.Settings.Default["ColorGridLine"];
            btnSegColor.BackColor = (Color)Properties.Settings.Default["ColorGridSegment"];
            btnDeadCellBG.BackColor = (Color)Properties.Settings.Default["ColorCellDead"];
            btnAliveCellBG.BackColor = (Color)Properties.Settings.Default["ColorCellAlive"];
            btn1Neighbor.BackColor = (Color)Properties.Settings.Default["Color1Neighbor"];
            btn2Neighbor.BackColor = (Color)Properties.Settings.Default["Color2Neighbor"];
            btn3Neighbor.BackColor = (Color)Properties.Settings.Default["Color3Neighbor"];
            btn4Neighbor.BackColor = (Color)Properties.Settings.Default["Color4Neighbor"];
            btn5Neighbor.BackColor = (Color)Properties.Settings.Default["Color5Neighbor"];
            btn6Neighbor.BackColor = (Color)Properties.Settings.Default["Color6Neighbor"];
            btn7Neighbor.BackColor = (Color)Properties.Settings.Default["Color7Neighbor"];
            btn8Neighbor.BackColor = (Color)Properties.Settings.Default["Color8Neighbor"];
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

        private void btn1Neighbor_Click(object sender, EventArgs e)
        {
            getColor(btn1Neighbor);
        }

        private void btn2Neighbor_Click(object sender, EventArgs e)
        {
            getColor(btn2Neighbor);
        }

        private void btn3Neighbor_Click(object sender, EventArgs e)
        {
            getColor(btn3Neighbor);
        }

        private void btn4Neighbor_Click(object sender, EventArgs e)
        {
            getColor(btn4Neighbor);
        }

        private void btn5Neighbor_Click(object sender, EventArgs e)
        {
            getColor(btn5Neighbor);
        }

        private void btn6Neighbor_Click(object sender, EventArgs e)
        {
            getColor(btn6Neighbor);
        }

        private void btn7Neighbor_Click(object sender, EventArgs e)
        {
            getColor(btn7Neighbor);
        }

        private void btn8Neighbor_Click(object sender, EventArgs e)
        {
            getColor(btn8Neighbor);
        }
    }
}
