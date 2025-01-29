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

            UIMethod.UserPicksCell();
            UIMethod.Move(moveUser);            

            
        }
    }
}
