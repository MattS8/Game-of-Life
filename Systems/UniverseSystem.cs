using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Life
{
    enum UniverseType { Finite, Torodial }

    class UniverseSystem
    {
        public const int MaxWidth = 999;
        public const int MaxHeight = 999;

        bool[,] universe;
        bool[,] nextGen;
        public UniverseType universeType;
        public int generations;
        public string name;

        private int numLivingCells;
        private uint numCellsBorn;
        private uint numCellsDied;
        
        Random rand;

        public UniverseSystem()
        {
            universe = new bool[Properties.Settings.Default.UniWidth, Properties.Settings.Default.UniHeight];
            nextGen = new bool[Properties.Settings.Default.UniWidth, Properties.Settings.Default.UniHeight];
            universeType = Properties.Settings.Default.UniBoundaryType == "Torodial" ? UniverseType.Torodial : UniverseType.Finite;
            generations = 0;
            numLivingCells = 0;
            numCellsBorn = 0;
            numCellsDied = 0;
            InitializeRandomization();
        }

        /// <summary>
        /// Resizes the universe, adding dead cells if the new size is larger, and trimming if smaller.
        /// </summary>
        /// <param name="newX"></param>
        /// <param name="newY"></param>
        public void Resize(int newX, int newY)
        {
            if (newX > MaxWidth)
                newX = MaxWidth;
            if (newY > MaxHeight)
                newY = MaxHeight;
            if (newX < 1)
                newX = 1;
            if (newY < 1)
                newY = 1;

            numLivingCells = 0;
            bool[,] temp = new bool[newX, newY];
            for (int x = 0; x < newX && x < GetLength(0); ++x)
                for (int y = 0; y < newY && y < GetLength(1); ++y)
                {
                    temp[x, y] = universe[x, y];
                    numLivingCells += universe[x, y] ? 1 : 0;
                }
                    

            universe = temp;
            nextGen = new bool[newX, newY];
        }

        /// <summary>
        /// Progresses the universe to the next frame in the simulation.
        /// </summary>
        public void NextGeneration()
        {
            // Increment generation count
            ++generations;

            // Copy universe into nextGen
            nextGen = universe.Clone() as bool[,];

            // Determine alive/dead cells
            int xLen = universe.GetLength(0);
            int yLen = universe.GetLength(1);
            int numNeighbors;
            for (int y = 0; y < yLen; ++y)
            {
                for (int x = 0; x < xLen; ++x)
                {
                    numNeighbors = GetNumNeighbors(x, y);

                    if (universe[x, y])
                    {
                        if (numNeighbors == 2 || numNeighbors == 3)
                        {
                            nextGen[x, y] = true;
                        } 
                        else
                        {
                            nextGen[x, y] = false;
                            --numLivingCells;
                        }
                        
                    }
                    else
                    {
                        if (numNeighbors == 3)
                        {
                            nextGen[x, y] = true;
                            ++numLivingCells;
                        }
                        else
                        {
                            nextGen[x, y] = false;
                        }
                    }   
                }
            }

            universe = nextGen;
        }

        /// <summary>
        /// Clears the universe of all live cells and resets the generation count back to 0.
        /// </summary>
        public void Reset()
        {
            universe = new bool[Properties.Settings.Default.UniWidth, Properties.Settings.Default.UniHeight];
            nextGen = new bool[Properties.Settings.Default.UniWidth, Properties.Settings.Default.UniHeight];
            universeType = Properties.Settings.Default.UniBoundaryType == "Torodial" ? UniverseType.Torodial : UniverseType.Finite;

            //for (int y = 0; y < universe.GetLength(1); y++)
            //{
            //    // Iterate through the universe in the x, left to right
            //    for (int x = 0; x < universe.GetLength(0); x++)
            //    {
            //        universe[x, y] = false;
            //    }
            //}

            generations = 0;
            numLivingCells = 0;
        }

        public int NumberOfLivingCells()
        {
            return numLivingCells;
        }

        private int GetNumNeighborsFinite(int x, int y)
        {
            int numNeighbors = 0;

            // Top Left
            if (x > 0 && y > 0)
                numNeighbors += universe[x - 1, y - 1] ? 1 : 0;
            // Left
            if (x > 0)
                numNeighbors += universe[x - 1, y] ? 1 : 0;
            // Bottom Left
            if (x > 0 && y < GetLength(1) - 1)
                numNeighbors += universe[x - 1, y + 1] ? 1 : 0;
            // Bottom
            if (y < GetLength(1)-1)
                numNeighbors += universe[x, y + 1] ? 1 : 0;
            // Bottom Right
            if (x < GetLength(0) - 1 && y < GetLength(1) - 1)
                numNeighbors += universe[x + 1, y + 1] ? 1 : 0;
            // Right
            if (x < GetLength(0) - 1)
                numNeighbors += universe[x + 1, y] ? 1 : 0;
            //Top Right
            if (x < GetLength(0) - 1 && y > 0)
                numNeighbors += universe[x + 1, y - 1] ? 1 : 0;
            //Top
            if (y > 0)
                numNeighbors += universe[x, y - 1] ? 1 : 0;

            return numNeighbors;
        }

        private int GetNumNeighborsTorodial(int x, int y)
        {
            int numNeighbors = 0;
            int xLen = GetLength(0);
            int yLen = GetLength(1);

            // Top Left
            numNeighbors += universe[x > 0 ? x - 1 : xLen - 1, y > 0 ? y - 1 : yLen - 1] ? 1 : 0;
            // Left
            numNeighbors += universe[x > 0 ? x - 1 : xLen - 1, y] ? 1 : 0;
            // Bottom Left
            numNeighbors += universe[x > 0 ? x - 1 : xLen - 1, y < yLen - 1 ? y + 1 : 0] ? 1 : 0;
            // Bottom
            numNeighbors += universe[x, y < yLen - 1 ? y + 1 : 0] ? 1 : 0;
            // Bottom Right
            numNeighbors += universe[x < xLen - 1 ? x + 1 : 0, y < yLen - 1 ? y + 1 : 0] ? 1 : 0;
            // Right
            numNeighbors += universe[x < xLen - 1 ? x + 1 : 0, y] ? 1 : 0;
            //Top Right
            numNeighbors += universe[x < xLen - 1 ? x + 1 : 0, y > 0 ? y - 1 : yLen - 1] ? 1 : 0;
            //Top
            numNeighbors += universe[x, y > 0 ? y - 1 : yLen - 1] ? 1 : 0;

            return numNeighbors;
        }

        /// <summary>
        /// Gets the number of neighbors of the given cell.
        /// </summary>
        /// <param name="x">X location</param>
        /// <param name="y">Y location</param>
        /// <returns>Number of neighbors</returns>
        public int GetNumNeighbors(int x, int y)
        {
            return universeType == UniverseType.Finite 
                ? GetNumNeighborsFinite(x, y) 
                : GetNumNeighborsTorodial(x, y);
        }

        /// <summary>
        /// Gets the universe length for the given dimension.
        /// </summary>
        /// <param name="deminsion"></param>
        /// <returns>Length of the univese array</returns>
        public int GetLength(int deminsion)
        {
            return universe.GetLength(deminsion);
        }

        public bool this[int x, int y]
        { 
            get { return universe[x, y]; }
            set 
            {
                if (universe[x, y] && !value)
                    --numLivingCells;
                else if (!universe[x, y] && value)
                    ++numLivingCells;
                universe[x, y] = value; 
            }
        }

        public void InitializeRandomization()
        {
            rand = Properties.Settings.Default.UseSeed ? new Random((int)Properties.Settings.Default.RandSeed) : new Random(new System.DateTime().Millisecond);
        }

        /**
         * The following 3 functions are used to randomize the universe via different
         * methods. The user can either specify a certain seed to used one-off.
         * Alternatively, they can elect to randomize the "default" way. This differs
         * based on what the user has set up in the settings menu.
         */ 

        private void Randomize(bool bUseTempSeed, int seed = -1)
        {
            Random tempRand = bUseTempSeed ? new Random(seed) : rand;
            numLivingCells = 0;
            for (int x = 0; x < GetLength(0); ++x)
                for (int y = 0; y < GetLength(1); ++y)
                {
                    int r = tempRand.Next(100);
                    universe[x, y] = r < (Properties.Settings.Default.RandAlive > Properties.Settings.Default.RandDead ? Properties.Settings.Default.RandDead : Properties.Settings.Default.RandAlive);
                    numLivingCells += universe[x, y] ? 1 : 0;
                }
        }

        internal void Randomize(int seed)
        {
            Randomize(true, seed);
        }

        internal void Randomize()
        {
            Randomize(false);
        }
    }

}
