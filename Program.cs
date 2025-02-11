using System;
using System.Diagnostics.Metrics;
using Microsoft.VisualBasic;

namespace TikTakToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //const int GRID_SIZE_ROW = 3;
            //const int GRID_SIZE_COLUMN = 3;

            //defines grid
            char[,] grid = new char[Constants.GRID_SIZE_ROW, Constants.GRID_SIZE_COLUMN];
            UIMethod.DisplayGrid(grid);

            //player
            string currentPlayer = "X";
            if (currentPlayer == "X")
            {
                currentPlayer = "O";
            }
            else
            {
                currentPlayer = "X";
            }

            string userCoordinate = UIMethod.GetUserChoice ("Enter the row and column(e.g., 11 for the very first cell):");
            string computerCoordinates = UIMethod.RandomMove(grid);
            UIMethod.PlaceSymbol(grid, userCoordinate, computerCoordinates);
            

            


            //grid[row, col] = 'X';


            //Console.WriteLine(grid[row, col]);

            UIMethod.DisplayGrid(grid);
        }
    }
}
