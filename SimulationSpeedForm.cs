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
    public partial class SimulationSpeedForm : Form
    {
        public int IntervalTime;
        public SimulationSpeedForm(int InitialInterval)
        {
            InitializeComponent();
            IntervalTime = InitialInterval;
            numInterval.Value = IntervalTime;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            IntervalTime = (int)numInterval.Value;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
