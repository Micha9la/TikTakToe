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
                    if (grid[row, col] == '\0') // \0 is a symbol to check if cell is empty
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

        public static bool IsValidMove(char[,] grid, string userCoordinate)
        {
            if (userCoordinate.Length != 2) return false;

            int row = userCoordinate[0] - '1';
            int col = userCoordinate[1] - '1';

            if (row < 0 || row >= Constants.GRID_SIZE_ROW || col < 0 || col >= Constants.GRID_SIZE_COLUMN)
                return false; // Out of bounds

            return grid[row, col] == '\0'; // True if cell is empty
        }
        public static bool IsGameOver(char[,] grid)
        {
            // Check Rows & Columns in One Loop
            for (int i = 0; i < Constants.GRID_SIZE_ROW; i++)
            {
                if (grid[i, 0] != '\0' && grid[i, 0] == grid[i, 1] && grid[i, 1] == grid[i, 2])
                    return true; // Row win

                if (grid[0, i] != '\0' && grid[0, i] == grid[1, i] && grid[1, i] == grid[2, i])
                    return true; // Column win
            }

            // Check Diagonals
            if (grid[0, 0] != '\0' && grid[0, 0] == grid[1, 1] && grid[1, 1] == grid[2, 2])
                return true; // Main diagonal

            if (grid[0, 2] != '\0' && grid[0, 2] == grid[1, 1] && grid[1, 1] == grid[2, 0])
                return true; // Anti-diagonal

            // Check for a Draw (No empty cells left)
            foreach (char cell in grid)
            {
                if (cell == '\0') // Empty cell found, game continues
                    return false;
            }

            //if program reached here, it is a draw
            Console.WriteLine("It's a draw!");
            return true;
        }
    }
}



