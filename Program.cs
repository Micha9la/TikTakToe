using System;
using System.Diagnostics.Metrics;
using Microsoft.VisualBasic;

namespace TikTakToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int GRID_SIZE_ROW = 3;
            const int GRID_SIZE_COLUMN = 3;

            char[,] grid = new char[GRID_SIZE_ROW, GRID_SIZE_COLUMN];

            Console.Write("  ");
            for (int columnHeader = 0; columnHeader < GRID_SIZE_COLUMN; columnHeader++)
            {
                Console.Write(columnHeader + 1 + " ");
            }
            Console.WriteLine();
            
            for (int lineIndex = 0; lineIndex < GRID_SIZE_ROW; lineIndex++)
            {
                Console.Write(lineIndex + 1 + " ");
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

            Console.WriteLine("Enter the row and column(e.g., 11 for the very first cell):");
            string move = Console.ReadLine();
            Console.WriteLine("You picked cell " + move);
            int row = int.Parse(move[0].ToString()) - 1;
            int col = int.Parse(move[1].ToString()) - 1;
            grid[row, col] = 'X';
            Console.WriteLine(grid[row, col]);

            Console.Write("  ");
            for (int columnHeader = 0; columnHeader < GRID_SIZE_COLUMN; columnHeader++)
            {
                Console.Write(columnHeader + 1 + " ");
            }
            Console.WriteLine();

            for (int lineIndex = 0; lineIndex < GRID_SIZE_ROW; lineIndex++)
            {
                Console.Write(lineIndex + 1 + " ");
                for (int columnIndex = 0; columnIndex < GRID_SIZE_COLUMN; columnIndex++)
                {
                    
                    Console.Write(grid[lineIndex, columnIndex] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Above you see the updated tik tak toe grid");


        }
    }
}
