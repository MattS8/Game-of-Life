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
        const int FastestSpeedInterval = 15;
        const int SlowestSpeedInterval = 1000;
        const int Interval = 50;

        // The universe array
        bool[,] universe = new bool[30, 30];
        bool[,] nextGen = new bool[30, 30];

        // Drawing colors
        Color gridColor = Color.Black;
        Color cellColor = Color.Gray;

        // The Timer class
        Timer timer = new Timer();

        // Generation count
        int generations = 0;

        // Timer invertval
        int timerInterval = 100;

        public MainWindow()
        {
            InitializeComponent();

            // Setup the timer
            timer.Interval = timerInterval; // milliseconds
            timer.Tick += Timer_Tick;
            timer.Enabled = false; // start timer running
        }

        // Calculate the next generation of cells
        private void NextGeneration()
        {


            // Increment generation count
            generations++;

            // Update status strip generations
            toolStripStatusLabelGenerations.Text = "Generations = " + generations.ToString();

            // Copy universe into nextGen
            nextGen = universe.Clone() as bool[,];

            // Loop through each cell an determine if it is alive or dead
            int numNeighbors = 0;
            int xLen = universe.GetLength(0);
            int yLen = universe.GetLength(1);
            for (int x = 0; x < xLen; ++x)
            {
                for (int y = 0; y < yLen; ++y)
                {
                    numNeighbors = 0;
                    if (x > 0)
                    {
                        // Left neighor
                        numNeighbors += universe[x - 1, y] ? 1 : 0;

                        // Top left neighbor
                        if (y > 0)
                            numNeighbors += universe[x - 1, y - 1] ? 1 : 0;

                        // Bottom left neighbor
                        if (y < yLen - 1)
                            numNeighbors += universe[x - 1, y + 1] ? 1 : 0;
                    }

                    if (x < xLen-1)
                    {
                        // Right neighbor
                        numNeighbors += universe[x + 1, y] ? 1 : 0;

                        // Top right neighbor
                        if (y > 0)
                            numNeighbors += universe[x + 1, y - 1] ? 1 : 0;

                        // Bottom right neighbor
                        if (y < yLen - 1)
                            numNeighbors += universe[x + 1, y + 1] ? 1 : 0;
                    }
                        
                    // Top neighbor
                    if (y > 0)
                        numNeighbors += universe[x, y - 1] ? 1 : 0;

                    // Bottom neighbor
                    if (y < yLen - 1)
                        numNeighbors += universe[x, y + 1] ? 1 : 0;

                    if (universe[x, y])
                        nextGen[x, y] = numNeighbors == 2 || numNeighbors == 3;
                    else
                        nextGen[x, y] = numNeighbors == 3;
                }
            }

            universe = nextGen;

            //GC.Collect(0);

            // Update the panel to show new generation
            graphicsPanel1.Invalidate();
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
        }

        private void speedUpButton_Click(object sender, EventArgs e)
        {
            if (timerInterval - Interval >= FastestSpeedInterval)
                timerInterval -= Interval;
            timer.Interval = timerInterval;
        }

        private void slowDownButton_Click(object sender, EventArgs e)
        {
            if (timerInterval + Interval <= SlowestSpeedInterval)
                timerInterval += Interval;
            timer.Interval = timerInterval;
        }

        private void newUniverse_Click(object sender, EventArgs e)
        {
            // Stop simulation
            timer.Enabled = false;

            // Clear panel - iterate through the universe in the y, top to bottom
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    universe[x, y] = false;
                }
            }
            graphicsPanel1.Invalidate();

            // Reset generations
            generations = 0;

            // Update status strip generations
            toolStripStatusLabelGenerations.Text = "Generations = " + generations.ToString();
        }
    }
}
