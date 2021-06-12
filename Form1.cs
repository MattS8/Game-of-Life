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
    public partial class MainWindow : Form
    {
        // Drawing colors
        Color gridColor = Color.Black;
        Color cellColor = Color.Gray;

        // The Timer class
        Timer timer = new Timer();

        // Timer invertval
        float timerMultiplier = 1;

        // Universe instance
        UniverseSystem universe = new UniverseSystem();

        public MainWindow()
        {
            InitializeComponent();

            // Setup the timer
            timer.Interval = SpeedSystem.GetSpeed(timerMultiplier); // milliseconds
            timer.Tick += Timer_Tick;
            timer.Enabled = false; // start timer running

            // Setup Universe Menu Toolstrip
            uiTypeFininite.Image = universe.universeType == UniverseType.Finite ? Properties.Resources.aCheckMark : null;
            uiTypeInfinite.Image = universe.universeType == UniverseType.Infinite ? Properties.Resources.aCheckMark : null;
            uiXSize.Text = universe.GetLength(0).ToString();
            uiYSize.Text = universe.GetLength(1).ToString();
        }

        // Calculate the next generation of cells
        private void NextGeneration()
        {
            // Get next generation
            universe.NextGeneration();

            // Update status strip generations
            toolStripStatusLabelGenerations.Text = "Generations = " + universe.generations.ToString();

            //GC.Collect(0);

            // Update the panel to show new generation
            graphicsPanel1.Invalidate();
        }

        private void NewUniverse()
        {
            //universe = new UniverseSystem(uiXSize.get)
        }

        // The event called by the timer every Interval milliseconds.
        private void Timer_Tick(object sender, EventArgs e)
        {
            NextGeneration();
        }

        private void graphicsPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Calculate the width and height of each cell in pixels
            // CELL WIDTH = WINDOW WIDTH / NUMBER OF CELLS IN X
            int cellWidth = graphicsPanel1.ClientSize.Width / universe.GetLength(0);
            // CELL HEIGHT = WINDOW HEIGHT / NUMBER OF CELLS IN Y
            int cellHeight = graphicsPanel1.ClientSize.Height / universe.GetLength(1);

            // A Pen for drawing the grid lines (color, width)
            Pen gridPen = new Pen(gridColor, 1);

            // A Brush for filling living cells interiors (color)
            Brush cellBrush = new SolidBrush(cellColor);

            // Iterate through the universe in the y, top to bottom
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    // A rectangle to represent each cell in pixels
                    Rectangle cellRect = Rectangle.Empty;
                    cellRect.X = x * cellWidth;
                    cellRect.Y = y * cellHeight;
                    cellRect.Width = cellWidth;
                    cellRect.Height = cellHeight;

                    // Fill the cell with a brush if alive
                    if (universe[x, y] == true)
                    {
                        e.Graphics.FillRectangle(cellBrush, cellRect);
                    }

                    // Outline the cell with a pen
                    e.Graphics.DrawRectangle(gridPen, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);
                }
            }

            // Cleaning up pens and brushes
            gridPen.Dispose();
            cellBrush.Dispose();
        }

        private void graphicsPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            // If the left mouse button was clicked
            if (e.Button == MouseButtons.Left)
            {
                // Calculate the width and height of each cell in pixels
                int cellWidth = graphicsPanel1.ClientSize.Width / universe.GetLength(0);
                int cellHeight = graphicsPanel1.ClientSize.Height / universe.GetLength(1);
                if (cellWidth == 0)
                    cellWidth = 1;
                if (cellHeight == 0)
                    cellHeight = 1;

                // Calculate the cell that was clicked in
                // CELL X = MOUSE X / CELL WIDTH
                int x = e.X / cellWidth;
                if (x >= universe.GetLength(0))
                {
                    System.Diagnostics.Debug.WriteLine("X was greater than universe length: " + x);
                    return;
                }
                // CELL Y = MOUSE Y / CELL HEIGHT
                int y = e.Y / cellHeight;
                if (y >= universe.GetLength(1))
                {
                    System.Diagnostics.Debug.WriteLine("Y was greater than universe length: " + y);
                    return;
                }

                // Toggle the cell's state
                universe[x, y] = !universe[x, y];

                // Tell Windows you need to repaint
                graphicsPanel1.Invalidate();
            }
        }

        private void graphicsPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine("X was greater than universe length: " + x);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void playPauseButton_Click(object sender, EventArgs e)
        {
            timer.Enabled = !timer.Enabled;
            playPauseButton.Image = !timer.Enabled ? Properties.Resources.outline_play_arrow_black_24dp : Properties.Resources.aPauseIcon;
        }

        private void speedUpButton_Click(object sender, EventArgs e)
        {
            timerMultiplier = SpeedSystem.IncreaseSpeed(timerMultiplier);
            System.Diagnostics.Debug.WriteLine("Speed: " + timerMultiplier);
            speedMultiplier.Text = SpeedSystem.GetMultiplierString(timerMultiplier);
            timer.Interval = SpeedSystem.GetSpeed(timerMultiplier); // milliseconds
        }

        private void slowDownButton_Click(object sender, EventArgs e)
        {
            timerMultiplier = SpeedSystem.DecreaseSpeed(timerMultiplier);
            System.Diagnostics.Debug.WriteLine("Speed: " + timerMultiplier);
            speedMultiplier.Text = SpeedSystem.GetMultiplierString(timerMultiplier);
            timer.Interval = SpeedSystem.GetSpeed(timerMultiplier); // milliseconds
        }

        private void newUniverse_Click(object sender, EventArgs e)
        {
            // Stop simulation
            timer.Enabled = false;
            playPauseButton.Image = Properties.Resources.aPauseIcon;

            // Reset the universe
            universe.Reset();

            graphicsPanel1.Invalidate();

            
            // Update status strip generations
            toolStripStatusLabelGenerations.Text = "Generations = " + universe.generations.ToString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uiNextFrame_Click(object sender, EventArgs e)
        {
            NextGeneration();
        }

        private void finiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            universe.universeType = UniverseType.Finite;
            uiTypeFininite.Image = Properties.Resources.aCheckMark;
            uiTypeInfinite.Image = null;
        }

        private void infiniteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            universe.universeType = UniverseType.Infinite;
            uiTypeFininite.Image = null;
            uiTypeInfinite.Image = Properties.Resources.aCheckMark;
        }

        private void size_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                // Ensure the modified size is a proper number
                if (!validateSize(((System.Windows.Forms.ToolStripTextBox)sender).Tag.Equals("uiWidth") ? uiXSize.Text : uiYSize.Text))
                    return;

                var item = (ToolStripItem)sender;
                var owner = (ToolStripDropDown)(item.Owner);
                owner.Close();
                e.Handled = true;

                universe.Resize(int.Parse(uiXSize.Text), int.Parse(uiYSize.Text));
                graphicsPanel1.Invalidate();
            }
        }

        private void heightToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            uiYSize.Text = universe.GetLength(1).ToString();
        }

        private void widthToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            uiXSize.Text = universe.GetLength(0).ToString();
        }

        private void uiUniverseRandomize_Click(object sender, EventArgs e)
        {
            universe.Randomize();
            graphicsPanel1.Invalidate();
        }

        private bool validateSize(String sizeStr)
        {
            foreach (char c in sizeStr)
            {
                if (!char.IsControl(c) && !char.IsDigit(c))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
