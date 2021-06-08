using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Life
{
    enum UniverseType { Finite, Infinite }

    class UniverseSystem
    {
        bool[,] universe;
        bool[,] nextGen;
        public UniverseType universeType;
        public int generations;

        public UniverseSystem(int width = 30, int height = 30, UniverseType type = UniverseType.Finite, int initialGenerations = 0)
        {
            universe = new bool[width, height];
            nextGen = new bool[width, height];
            universeType = type;
            generations = initialGenerations;
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
            for (int x = 0; x < xLen; ++x)
            {
                for (int y = 0; y < yLen; ++y)
                {
                    numNeighbors = GetNumNeighbors(x, y);

                    if (universe[x, y])
                        nextGen[x, y] = numNeighbors == 2 || numNeighbors == 3;
                    else
                        nextGen[x, y] = numNeighbors == 3;
                }
            }

            universe = nextGen;
        }

        /// <summary>
        /// Clears the universe of all live cells and resets the generation count back to 0.
        /// </summary>
        public void Reset()
        {
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    universe[x, y] = false;
                }
            }

            generations = 0;
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

        private int GetNumNeighborsInfinite(int x, int y)
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
                : GetNumNeighborsInfinite(x, y);
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
            set { universe[x, y] = value; }
        }

    }

}
