using System;
using System.Diagnostics.Metrics;
using Microsoft.VisualBasic;

namespace TikTakToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //defines grid
            char[,] grid = new char[Constants.GRID_SIZE_ROW, Constants.GRID_SIZE_COLUMN];

            //initialize grid with empty cells
            for (int row = 0; row < Constants.GRID_SIZE_ROW; row++)
            {
                for (int col = 0; col < Constants.GRID_SIZE_COLUMN; col++)
                {
                    grid[row, col] = Constants.EMPTY_CELL;
                }
            }

            UIMethod.DisplayGrid(grid);

            //loop keeps running until someone wins or board is full.
            while (true)
            {
                //User's move
                string userCoordinate;
                bool validMove = false;
                int selectRow = -1;
                int selectCol = -1;

                do
                {
                    userCoordinate = UIMethod.GetUserChoice("Enter the row and column (e.g., 21 for first cell in middle line):");

                    if (LogicMethods.ValidateInput(userCoordinate, out selectRow, out selectCol) &&
                        LogicMethods.CheckCellEmpty(grid, selectRow, selectCol))
                    {
                        validMove = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid move! Either out of bounds or cell is occupied.");
                    }

                } while (!validMove);



                LogicMethods.PlaceUserMove(grid, selectRow, selectCol);
                Console.WriteLine("Checking wins...");
                UIMethod.DisplayGrid(grid);

                // Check if user wins or game is a draw
                if (LogicMethods.CheckGameStatus(grid, "You win!"))
                    break;

                // Computer's move
                LogicMethods.PlaceComputerMove(grid);
                UIMethod.DisplayGrid(grid);

                // Check if computer wins or game is a draw
                if (LogicMethods.CheckGameStatus(grid, "Computer wins!"))
                    break;
            }
        }
    }
}
