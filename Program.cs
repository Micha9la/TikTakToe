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

            string userCoordinate = UIMethod.GetUserChoice("Enter row and column (e.g., 11 for top-left):");

            UIMethod.PlaceSymbol(grid, userCoordinate);

            UIMethod.DisplayGrid(grid);



            //int computerMove= UIMethod.PlaceSymbol(grid, userCoordinate, computerCoordinates[0].ToString(), computerCoordinates[1].ToString());
        }
    }
}
