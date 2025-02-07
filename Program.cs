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

            string userCoordinates = UIMethod.GetUserChoice ("Enter the row and column(e.g., 11 for the very first cell):");
            UIMethod.PlaceSymbol(char[,] grid, string coordinateUser);

            Console.WriteLine("Enter the row and column(e.g., 11 for the very first cell):");
            string move = Console.ReadLine();
            Console.WriteLine("You picked cell " + move);
            int row = int.Parse(move[0].ToString()) - 1;
            int col = int.Parse(move[1].ToString()) - 1;
            grid[row, col] = 'X';


            //grid[row, col] = 'X';


            //Console.WriteLine(grid[row, col]);

            UIMethod.DisplayGrid(grid);
        }
    }
}
