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

            UIMethod.DisplayGrid(grid);

            //loop keeps running until someone wins or board is full.
            while (true)
            {
                //User's move
                string userCoordinate;
                bool validMove = false;

                do
                {
                    userCoordinate = UIMethod.GetUserChoice("Enter the row and column (e.g., 11 for top-left):");

                    if (LogicMethods.ValidateInput(userCoordinate, out int selectRow, out int selectCol) &&
                        LogicMethods.CheckCellEmpty(grid, selectRow, selectCol))
                    {
                        validMove = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid move! Either out of bounds or cell is occupied.");
                    }

                } while (!validMove);



                LogicMethods.PlaceUserMove(grid, userCoordinate);               
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
