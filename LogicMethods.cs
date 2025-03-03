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
                char firstSymbol = grid[rowIndex, 0]; // First symbol in the row
                if (firstSymbol == Constants.EMPTY_CELL) continue; // Ignore empty rows

                bool rowWin = true;
                for (int colIndex = 1; colIndex < Constants.GRID_SIZE_COLUMN; colIndex++)
                {
                    if (grid[rowIndex, colIndex] != firstSymbol)
                    {
                        rowWin = false;
                        break;
                    }
                }

                if (rowWin)
                    return true; // Found a winning row
            }
            return false; // No winning row found
        }

        public static bool CheckWinColumns(char[,] grid)
        {
            for (int colIndex = 0; colIndex < Constants.GRID_SIZE_COLUMN; colIndex++)
            {
                char firstSymbol = grid[0, colIndex]; // First symbol in the column
                if (firstSymbol == Constants.EMPTY_CELL) continue; // Ignore empty columns

                bool colWin = true;
                for (int rowIndex = 1; rowIndex < Constants.GRID_SIZE_ROW; rowIndex++)
                {
                    if (grid[rowIndex, colIndex] != firstSymbol)
                    {
                        colWin = false;
                        break;
                    }
                }

                if (colWin)
                    return true; // Found a winning column
            }
            return false; // No winning column found
        }

        public static bool CheckWinDiagonals(char[,] grid)
        {
            bool mainDiagonalWin = true;
            bool antiDiagonalWin = true;
            char mainSymbol = grid[0, 0]; // First cell of main diagonal
            char antiSymbol = grid[0, Constants.GRID_SIZE_COLUMN - 1]; // First cell of anti-diagonal

            if (mainSymbol == Constants.EMPTY_CELL) 
                mainDiagonalWin = false;
            if (antiSymbol == Constants.EMPTY_CELL) 
                antiDiagonalWin = false;

            for (int i = 1; i < Constants.GRID_SIZE_ROW; i++)
            {
                if (grid[i, i] != mainSymbol) 
                    mainDiagonalWin = false; // Main diagonal
                if (grid[i, Constants.GRID_SIZE_COLUMN - 1 - i] != antiSymbol) 
                    antiDiagonalWin = false; // Anti-diagonal
            }

            return mainDiagonalWin || antiDiagonalWin; //if at least one of these two variables is true, it will return true
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
            return CheckWinRows(grid) || CheckWinColumns(grid) || CheckWinDiagonals(grid) || CheckDraw(grid);
        }
    }
}



