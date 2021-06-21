using System;
using System.Windows.Forms;

namespace Game_of_Life
{
    public partial class Form2 : Form
    {
        int shownIndex = 0;
        PanelColorsControls panelProperties = new PanelColorsControls();
        GridControls gridControls = new GridControls();
        RandomizationControls randomizationControls = new RandomizationControls();
        FontControls fontControls = new FontControls();

        public Form2()
        {
            InitializeComponent();
            lwProperties.Items[shownIndex].Selected = true;
            BackColor = Properties.Settings.Default.ColorBackColor;
        }

        private void lwProperties_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            Console.WriteLine("Item selection changed!" + e.Item.Index);
            shownIndex = e.Item.Index;
            showOptions();
        }

        private void showOptions()
        {
            grpProperties.Controls.Clear();
            switch(shownIndex)
            {
                case 0:
                    grpProperties.Text = "Panel Colors";
                    grpProperties.Controls.Add(panelProperties);
                    break;
                case 1:
                    grpProperties.Text = "Grid Options";
                    grpProperties.Controls.Add(gridControls);
                    break;
                case 2:
                    grpProperties.Text = "Fonts";
                    grpProperties.Controls.Add(fontControls);
                    break;
                case 3:
                    grpProperties.Text = "Window Colors";
                    break;
                case 4:
                    grpProperties.Text = "Randomization Options";
                    grpProperties.Controls.Add(randomizationControls);
                    break;
                default:
                    //grpProperties.Text = "";
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            panelProperties.applySettings();
            gridControls.applySettings();
            randomizationControls.applySettings();
            fontControls.applySettings();
            Properties.Settings.Default.Save();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnRestoreDefaults_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            panelProperties.restoreDefaults();
            gridControls.restoreDefaults();
            fontControls.restoreDefaults();

            randomizationControls.restoreDefaults();
        }

        public bool randomizationChanged() { return randomizationControls.randomizationChanged; }
    }
}
