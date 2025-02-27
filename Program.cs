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
            bool gameOver = false;

            UIMethod.DisplayGrid(grid);

            //loop keeps running until someone wins or board is full.
            while (!gameOver)
            {
                //User's move
                string userCoordinate;
                bool validMove = false;

                do
                {
                    userCoordinate = UIMethod.GetUserChoice("Enter the row and column (e.g., 11 for top-left):");
                    validMove = LogicMethods.IsValidMove(grid, userCoordinate);

                    if (!validMove)
                        Console.WriteLine("Invalid move! That cell is occupied or out of bounds. Try again.");

                } 
                
                while (!validMove);

                LogicMethods.PlaceUserMove(grid, userCoordinate);
                UIMethod.DisplayGrid(grid);

                if (LogicMethods.CheckWinRows(grid) || LogicMethods.CheckWinColumns(grid) || LogicMethods.CheckWinDiagonals(grid))
                {
                    Console.WriteLine("You win!");
                    break;
                }
                
                if (LogicMethods.CheckDraw(grid))
                {
                    Console.WriteLine("It's a draw!");
                    break;
                }                

                //Computer's move

                (int row, int col) = LogicMethods.GetRandomAvailableMove(grid);

                if (row != -1 && col != -1)
                {
                    LogicMethods.PlaceComputerMove(grid);
                    UIMethod.DisplayGrid(grid);
                }
                else
                {
                    Console.WriteLine("No available moves left! The game is a draw.");
                    break;
                }

                if (LogicMethods.CheckWinRows(grid) || LogicMethods.CheckWinColumns(grid) || LogicMethods.CheckWinDiagonals(grid))
                {
                    Console.WriteLine("Computer wins!");
                    break;
                }
                if (LogicMethods.CheckDraw(grid))
                {
                    Console.WriteLine("It's a draw!");
                    break;
                }

                //Check if computer won
                //if (LogicMethods.IsGameOver(grid))
                //{
                //  Console.WriteLine("Computer wins!");
                //break;
                //}
            }



            
        }
    }
}
