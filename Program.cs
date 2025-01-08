using System;
using System.Diagnostics.Metrics;

namespace TikTakToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int GRID_SIZE_ROW = 3;
            const int GRID_SIZE_COLUMN = 3;

            char [,] grid = new char[GRID_SIZE_ROW, GRID_SIZE_COLUMN];
           
            for (int lineIndex = 0; lineIndex < GRID_SIZE_ROW; lineIndex++)
            {
                for (int columnIndex = 0; columnIndex < GRID_SIZE_COLUMN; columnIndex++)
                {
                    grid[lineIndex, columnIndex] = '_';
                    Console.Write(grid[lineIndex, columnIndex] + " ");
                    
                }
                Console.WriteLine();
            }           
            Console.WriteLine("Above you see tik tak toe grid");

            string currentPlayer = "X";
            if (currentPlayer == "X")
            {
                currentPlayer = "O";
            }
            else
            {
                currentPlayer = "X";
            }

            Console.WriteLine("Enter the row and column(e.g., 0 1):"); 
            string move = Console.ReadLine(); 
        }
    }
}
