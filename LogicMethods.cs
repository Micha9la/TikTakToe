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
                    if (grid[row, col] == Constants.EMPTY_CELL) 
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

            int row = userCoordinate[0] - Constants.ZERO_BASED_INDEX_SUBTRACTER;
            int col = userCoordinate[1] - Constants.ZERO_BASED_INDEX_SUBTRACTER;

            if (row < 0 || row >= Constants.GRID_SIZE_ROW || col < 0 || col >= Constants.GRID_SIZE_COLUMN)
                return false; // Out of bounds

            return grid[row, col] == Constants.EMPTY_CELL; // True if cell is empty
        }

        public static void PlaceUserMove(char[,] grid, string userCoordinate)
        {
            int row = int.Parse(userCoordinate[0].ToString()) - 1;
            int col = int.Parse(userCoordinate[1].ToString()) - 1;
            grid[row, col] = Constants.USER_SYMBOL; // User always plays 'X'
        }

        public static void PlaceComputerMove(char[,] grid)
        {
            (int row, int col) = LogicMethods.GetRandomAvailableMove(grid);
            if (row != -1 && col != -1)
            {
                grid[row, col] = Constants.COMPUTER_SYMBOL; // Computer plays 'O'
            }
        }

        public static bool CheckWinRows(char[,] grid)
        {
            for (int rowIndex = 0; rowIndex < Constants.GRID_SIZE_ROW; rowIndex++)
            {
                if (grid[rowIndex, 0] != Constants.EMPTY_CELL &&
                    grid[rowIndex, 0] == grid[rowIndex, 1] &&
                    grid[rowIndex, 1] == grid[rowIndex, 2])
                {
                    return true; // Row win
                }
            }
            return false; // No row win found
        }

        public static bool CheckWinColumns(char[,] grid)
        {
            for (int columnIndex = 0; columnIndex < Constants.GRID_SIZE_COLUMN; columnIndex++)
            {
                if (grid[0, columnIndex] != Constants.EMPTY_CELL &&
                    grid[0, columnIndex] == grid[1, columnIndex] &&
                    grid[1, columnIndex] == grid[2, columnIndex])
                {
                    return true; // Column win
                }
            }
            return false; // No column win found
        }

        public static bool CheckWinDiagonals(char[,] grid)
        {
            if (grid[0, 0] != Constants.EMPTY_CELL &&
                grid[0, 0] == grid[1, 1] &&
                grid[1, 1] == grid[2, 2])
            {
                return true; // Main diagonal win
            }

            if (grid[0, 2] != Constants.EMPTY_CELL &&
                grid[0, 2] == grid[1, 1] &&
                grid[1, 1] == grid[2, 0])
            {
                return true; // Anti-diagonal win
            }

            return false; // No diagonal win found
        }

        public static bool CheckDraw(char[,] grid)
        {
            foreach (char cell in grid)
            {
                if (cell == Constants.EMPTY_CELL) // If any empty cell exists, the game continues
                    return false;
            }
            return true; // No empty cells left, it's a draw
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
            //Console.WriteLine("It's a draw!");
            return true;
        }
    }
}



