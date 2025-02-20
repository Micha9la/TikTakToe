using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTakToe
{
    public static class LogicMethods
    {
        public static readonly Random random = new Random();
        public static (int, int) GetRandomAvailableMove(char[,] grid)
        {
            List<(int, int)> availableCells = new List<(int, int)>();

            for (int row = 0; row < Constants.GRID_SIZE_ROW; row++)
            {
                for (int col = 0; col < Constants.GRID_SIZE_COLUMN; col++)
                {
                    if (grid[row, col] == '\0') // Check if cell is empty
                    {
                        availableCells.Add((row, col));
                    }
                }
            }

            if (availableCells.Count > 0)
            {
                return availableCells[random.Next(availableCells.Count)]; // Pick a random empty cell
            }

            return (-1, -1); // No available moves exist anymore
        }
    }
}

        //int randomCoordinateRows = random.Next(Constants.LOWER_NUMBER_ROWS, Constants.UPPER_NUMBER_ROWS);
        //int randomCoordinateColumns = random.Next(Constants.LOWER_NUMBER_COLUMNS, Constants.UPPER_NUMBER_COLUMNS);
        //string computerCoordinatesRows = randomCoordinateRows.ToString();
        //string computerCoordinatesColumns = randomCoordinateColumns.ToString();
        //string computerCoordinates = computerCoordinatesRows + computerCoordinatesColumns;
        //return computerCoordinates;


