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

        // The Timer class
        Timer timer = new Timer();

        // Timer invertval
        float timerMultiplier = 1;

        // Universe instance
        UniverseSystem universe = new UniverseSystem();

        // Name of Universe Save File
        String fileNameStr;

        public MainWindow()
        {
            InitializeComponent();

            // Setup the timer
            timer.Interval = SpeedSystem.GetSpeed(timerMultiplier); // milliseconds
            timer.Tick += Timer_Tick;
            timer.Enabled = false; // start timer running

            setupMenuToolstrip();
        }

        /* ----------- 
         * MAIN LOGIC 
         * ----------- 
         */

        // Calculate the next generation of cells
        private void NextGeneration()
        {
            // Get next generation
            universe.NextGeneration();

            // Update status strip generations
            toolStripStatusLabelGenerations.Text = "Generations = " + universe.generations.ToString();

            // Update status strip living cells
            toolStripStatusLabelLivingCells.Text = "Living Cells = " + universe.NumberOfLivingCells().ToString();

            //GC.Collect(0);

            // Update the panel to show new generation
            graphicsPanel1.Invalidate();
        }

        // The event called by the timer every Interval milliseconds.
        private void Timer_Tick(object sender, EventArgs e)
        {
            NextGeneration();
        }

        /* -------------------------
         * GRAPHICS PANEL FUNCTIONS 
         * -------------------------
         */

        private void graphicsPanel1_Paint(object sender, PaintEventArgs e)
        {
            graphicsPanel1.BackColor = Properties.Settings.Default.ColorPanelBG;

            // Calculate the width and height of each cell in pixels
            // CELL WIDTH = WINDOW WIDTH / NUMBER OF CELLS IN X
            float cellWidth = ((float) graphicsPanel1.ClientSize.Width) / universe.GetLength(0);
            // CELL HEIGHT = WINDOW HEIGHT / NUMBER OF CELLS IN Y
            float cellHeight = ((float) graphicsPanel1.ClientSize.Height) / universe.GetLength(1);

            // A Pen for drawing the grid lines (color, width)
            Pen gridPen = new Pen(Properties.Settings.Default.ColorGridLine, Properties.Settings.Default.GridLineThickness);
            //Pen segPen = new Pen(Properties.Settings.Default.ColorGridSegment, Properties.Settings.Default.GridSegmentThickness);

            // A Brush for filling living cells interiors (color)
            Brush cellBrush = new SolidBrush(Properties.Settings.Default.ColorCellAlive);
            Brush cellBrushDead = new SolidBrush(Properties.Settings.Default.ColorCellDead);

            // Neighbor Count Brushes
            Brush n1Brush = new SolidBrush(Properties.Settings.Default.Color1Neighbor);
            Brush n2Brush = new SolidBrush(Properties.Settings.Default.Color2Neighbor);
            Brush n3Brush = new SolidBrush(Properties.Settings.Default.Color3Neighbor);
            Brush n4Brush = new SolidBrush(Properties.Settings.Default.Color4Neighbor);
            Brush n5Brush = new SolidBrush(Properties.Settings.Default.Color5Neighbor);
            Brush n6Brush = new SolidBrush(Properties.Settings.Default.Color6Neighbor);
            Brush n7Brush = new SolidBrush(Properties.Settings.Default.Color7Neighbor);
            Brush n8Brush = new SolidBrush(Properties.Settings.Default.Color8Neighbor);
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            // Iterate through the universe in the y, top to bottom
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    // A rectangle to represent each cell in pixels
                    RectangleF cellRect = RectangleF.Empty;
                    cellRect.X = x * cellWidth;
                    cellRect.Y = y * cellHeight;
                    cellRect.Width = cellWidth;
                    cellRect.Height = cellHeight;

                    e.Graphics.FillRectangle(universe[x, y] == true ? cellBrush : cellBrushDead, cellRect);

                    if (Properties.Settings.Default.ViewNeighborCount)
                    {
                        int numNeighbors = universe.GetNumNeighbors(x, y);
                        e.Graphics.DrawString(numNeighbors.ToString(), Properties.Settings.Default.FontNeighbors, numNeighbors == 1
                            ? n1Brush : numNeighbors == 2
                            ? n2Brush : numNeighbors == 3
                            ? n3Brush : numNeighbors == 4
                            ? n4Brush : numNeighbors == 5
                            ? n5Brush : numNeighbors == 6
                            ? n6Brush : numNeighbors == 7
                            ? n7Brush : n8Brush,
                            cellRect, stringFormat);
                    }

                    // Outline the cell with a pen
                    if (Properties.Settings.Default.EnableGridLines)
                        e.Graphics.DrawRectangle(gridPen, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);
                }
            }

            // Cleaning up pens and brushes
            gridPen.Dispose();
            cellBrush.Dispose();
            cellBrushDead.Dispose();
            n1Brush.Dispose();
            n2Brush.Dispose();
            n3Brush.Dispose();
            n4Brush.Dispose();
            n5Brush.Dispose();
            n6Brush.Dispose();
            n7Brush.Dispose();
            n8Brush.Dispose();
        }

        private void graphicsPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            // If the left mouse button was clicked
            if (e.Button == MouseButtons.Left)
            {
                // Calculate the width and height of each cell in pixels
                float cellWidth = graphicsPanel1.ClientSize.Width / universe.GetLength(0);
                float cellHeight = graphicsPanel1.ClientSize.Height / universe.GetLength(1);
                if (cellWidth == 0)
                    cellWidth = 1;
                if (cellHeight == 0)
                    cellHeight = 1;

                // Calculate the cell that was clicked in
                // CELL X = MOUSE X / CELL WIDTH
                int x = e.X / (int)cellWidth;
                if (x >= universe.GetLength(0))
                {
                    System.Diagnostics.Debug.WriteLine("X was greater than universe length: " + x);
                    return;
                }
                // CELL Y = MOUSE Y / CELL HEIGHT
                int y = e.Y / (int)cellHeight;
                if (y >= universe.GetLength(1))
                {
                    System.Diagnostics.Debug.WriteLine("Y was greater than universe length: " + y);
                    return;
                }

                // Toggle the cell's state
                universe[x, y] = !universe[x, y];

                // Tell Windows you need to repaint
                graphicsPanel1.Invalidate();

                // Update status strip living cells
                toolStripStatusLabelLivingCells.Text = "Living Cells = " + universe.NumberOfLivingCells().ToString();
            }
        }

        private void graphicsPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine("X was greater than universe length: " + x);
        }

        /* ----------------------------
         * UNIVERSE TOOSTRIP FUNCTIONS
         * ----------------------------
         */

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

        private void uiNextFrame_Click(object sender, EventArgs e)
        {
            NextGeneration();
        }

        /* ----------------------------
         * UNIVERSE MENU FUNCTIONS
         * ----------------------------
         */

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

            // Update status strip living cells
            toolStripStatusLabelLivingCells.Text = "Living Cells = " + universe.NumberOfLivingCells().ToString();
        }

        private void uiTypeFininite_Click(object sender, EventArgs e)
        {
            universe.universeType = UniverseType.Finite;
            uiTypeFininite.Checked = true;
            uiTypeInfinite.Checked = false;
        }

        private void uiTypeInfinite_Click(object sender, EventArgs e)
        {
            universe.universeType = UniverseType.Torodial;
            uiTypeFininite.Checked = false;
            uiTypeInfinite.Checked = true;
        }

        private void nameInputToolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                universe.name = nameInputToolStripTextBox1.Text;
                this.Text = "Game of Life - " + universe.name;
            }
        }

        // Helper Functions
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

        /* ----------------------------
         * FILE MENU FUNCTIONS
         * ----------------------------
         */

        private void newUniverse_Click(object sender, EventArgs e)
        {
            // Clear opened file
            fileNameStr = "";

            // Stop simulation
            timer.Enabled = false;
            playPauseButton.Image = Properties.Resources.aPauseIcon;

            // Reset the universe
            universe.Reset();

            // Clear the name of the universe
            universe.name = "";

            // Redraw graphics panel
            graphicsPanel1.Invalidate();

            // Update window title
            this.Text = "Game of Life";

            // Update status strip generations
            toolStripStatusLabelGenerations.Text = "Generations = " + universe.generations.ToString();

            // Update status strip alive cells
            toolStripStatusLabelLivingCells.Text = "Living Cells = " + universe.NumberOfLivingCells();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 propertiesForm = new Form2();

            if (DialogResult.OK == propertiesForm.ShowDialog())
            {
                graphicsPanel1.Invalidate();
                setupMenuToolstrip();
                if (propertiesForm.randomizationChanged())
                    universe.InitializeRandomization();
            }
        }

        private void saveUniverse_Click(object sender, EventArgs e)
        {
            // Prompt user for Universe Name if it doesn't have one
            if (String.IsNullOrWhiteSpace(universe.name))
            {
                UniverseNameForm unf = new UniverseNameForm();

                if (DialogResult.OK == unf.ShowDialog())
                {
                    universe.name = unf.FileName;
                    this.Text = "Game of Life - " + universe.name;
                }
                else
                {
                    return;
                }
            }

            if (String.IsNullOrEmpty(fileNameStr))
                saveUniverseAs_Click(sender, e);
            else
                saveUniverse();
        }

        private void saveUniverseAs_Click(object sender, EventArgs e)
        {
            // Pause a running simulation
            timer.Enabled = false;
            playPauseButton.Image = !timer.Enabled ? Properties.Resources.outline_play_arrow_black_24dp : Properties.Resources.aPauseIcon;

            // Prompt user for Universe Name if it doesn't have one
            if (String.IsNullOrWhiteSpace(universe.name))
            {
                UniverseNameForm unf = new UniverseNameForm();

                if (DialogResult.OK == unf.ShowDialog())
                {
                    universe.name = unf.FileName;
                    this.Text = "Game of Life - " + universe.name;
                }
                else
                {
                    return;
                }
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "All Files|*.*|Cells|*.cells";
            sfd.FilterIndex = 2;
            sfd.DefaultExt = "cells";

            if (DialogResult.OK == sfd.ShowDialog())
            {
                fileNameStr = sfd.FileName;
                saveUniverse();
            }
        }

        private void openUniverse_Click(object sender, EventArgs e)
        {
            openUniverse();
        }

        // Helper Functions

        private void saveUniverse()
        {
            // Pause a running simulation
            timer.Enabled = false;
            playPauseButton.Image = !timer.Enabled ? Properties.Resources.outline_play_arrow_black_24dp : Properties.Resources.aPauseIcon;

            System.IO.StreamWriter writer;
            try
            {
                 writer = new System.IO.StreamWriter(fileNameStr);
            } catch (Exception e)
            {
                Console.WriteLine("Error: " + e.ToString());
                MessageBox.Show("The file could not be opened at this time.", "Error Opening File", MessageBoxButtons.OK);
                return;
            }

            writer.WriteLine("!Name: " + universe.name);
            writer.WriteLine("!UniverseType: " + (universe.universeType == UniverseType.Torodial ? "Torodial" : "Finite"));
            writer.WriteLine("!Generations: " + universe.generations.ToString());

            for (int y = 0; y < universe.GetLength(1); ++y)
            {
                var builder = new StringBuilder();
                for (int x = 0; x < universe.GetLength(0); ++x)
                    builder.Append(universe[x, y] ? 'O' : '.');
                writer.WriteLine(builder.ToString());
            }
            writer.Close();
        }

        private void openUniverse()
        {
            // Pause a running simulation
            timer.Enabled = false;
            playPauseButton.Image = !timer.Enabled ? Properties.Resources.outline_play_arrow_black_24dp : Properties.Resources.aPauseIcon;

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All Files|*.*|Cells|*.cells";
            dlg.FilterIndex = 2;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                fileNameStr = dlg.FileName;
                System.IO.StreamReader reader = new System.IO.StreamReader(fileNameStr);
                int maxWidth = 0;
                int maxHeight = 0;

                bool nameRead = false;

                // Reset universe generations variable before possibly
                // reading in a starting generation value
                universe.generations = 0;

                // Reset universe name in case opened file does not
                // contain a name
                universe.name = "";

                // Iterate through the file once to get its size.
                while (!reader.EndOfStream)
                {
                    // Read one row at a time.
                    string row = reader.ReadLine();

                    // If the row begins with '!' then it is a comment
                    // and should be ignored unless it's a supported option.
                    if (row.First() == '!')
                    {
                        if (nameRead)
                            continue;

                        var nameEndIndex = row.IndexOf(" ");
                        if (nameEndIndex == -1)
                            continue;

                        if (row.Substring(0, nameEndIndex).Equals("!Name:"))
                        {
                            universe.name = row.Substring(nameEndIndex + 1);
                            this.Text = "Game of Life - " + (!String.IsNullOrWhiteSpace(universe.name) ? " " + universe.name : "");
                            nameInputToolStripTextBox1.Text = universe.name;
                            nameRead = true;
                        }
                        else if (row.Substring(0, nameEndIndex).Equals("!UniverseType:"))
                        {
                            string second = row.Substring(nameEndIndex + 1);
                            Console.WriteLine("Parsed UniverseType: " + second);
                            universe.universeType = second.Equals("Infinite") ? UniverseType.Torodial : UniverseType.Finite;
                        }
                        else if (row.Substring(0, nameEndIndex).Equals("!Generations:"))
                        {
                            string second = row.Substring(nameEndIndex + 1);
                            Console.WriteLine("Parsed Generations: " + second);
                            universe.generations = int.Parse(second);
                        }
                        continue;
                    }

                    // Check for empty line
                    if (String.IsNullOrWhiteSpace(row))
                        continue;

                    // If the row is not a comment then it is a row of cells.
                    // Increment the maxHeight variable for each row read.
                    ++maxHeight;

                    // Get the length of the current row string
                    // and adjust the maxWidth variable if necessary.
                    if (row.Length > maxWidth)
                        maxWidth = row.Length;
                }

                // Reset stream reader to the beginning in preparation
                // for reading the universe data
                reader.DiscardBufferedData();
                reader.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);

                // Resize universe to the read-in width/height
                universe.Resize(maxWidth, maxHeight);

                // Keep track of current height
                int y = 0;

                while (!reader.EndOfStream)
                {
                    string row = reader.ReadLine();
                    
                    // Skip comments and option lines
                    if (row.First() == '!' || row.First() == '-')
                        continue;
                    
                    for (int x = 0; x < row.Length; ++x)
                        universe[x, y] = row.Substring(x, 1).Equals("O") || row.Substring(x,1).Equals("*");

                    ++y;
                }

                reader.Close();
        
                // Update panel
                graphicsPanel1.Invalidate();

                // Update status strip generations
                toolStripStatusLabelGenerations.Text = "Generations = " + universe.generations.ToString();

                // Update status strip living cells
                toolStripStatusLabelLivingCells.Text = "Living Cells = " + universe.NumberOfLivingCells().ToString();
            }
        }

        /* ----------------------------
        * View MENU FUNCTIONS
        * ----------------------------
        */

        private void toolStripMenuItemViewGrid_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.EnableGridLines = !Properties.Settings.Default.EnableGridLines;
            toolStripMenuItemViewGrid.Checked = Properties.Settings.Default.EnableGridLines;
            graphicsPanel1.Invalidate();
        }
        private void toolStripMenuItemNeighborCount_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ViewNeighborCount = !Properties.Settings.Default.ViewNeighborCount;
            toolStripMenuItemNeighborCount.Checked = Properties.Settings.Default.ViewNeighborCount;
            graphicsPanel1.Invalidate();
        }

        private void toolStripMenuItemViewHeadsUpDisplay_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ViewHeadsUpDisplay = !Properties.Settings.Default.ViewHeadsUpDisplay;
            toolStripMenuItemViewHeadsUpDisplay.Checked = Properties.Settings.Default.ViewHeadsUpDisplay;
            graphicsPanel1.Invalidate();
        }

        // Helper Functions
        private void setupMenuToolstrip()
        {
            // Setup Universe Menu Toolstrip
            uiTypeInfinite.Checked = universe.universeType == UniverseType.Torodial;
            uiTypeFininite.Checked = universe.universeType == UniverseType.Finite;
            uiXSize.Text = universe.GetLength(0).ToString();
            uiYSize.Text = universe.GetLength(1).ToString();

            // Setup View Menu Toolstrip
            toolStripMenuItemViewGrid.Checked = Properties.Settings.Default.EnableGridLines;
            toolStripMenuItemNeighborCount.Checked = Properties.Settings.Default.ViewNeighborCount;
            toolStripMenuItemViewHeadsUpDisplay.Checked = Properties.Settings.Default.ViewHeadsUpDisplay;
        }
    }
}
