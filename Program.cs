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
            string moveUserX = Console.ReadLine();
            Console.WriteLine("You picked cell " + moveUserX);
            int rowX = int.Parse(moveUserX[0].ToString()) - 1;
            int colX = int.Parse(moveUserX[1].ToString()) - 1;
            grid[rowX, colX] = 'X';
            //Console.WriteLine(grid[rowX, colX]); = displays only X

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

            Console.WriteLine("Enter the row and column(e.g., 11 for the very first cell):");
            string moveUserO = Console.ReadLine();
            Console.WriteLine("You picked cell " + moveUserO);
            int rowO = int.Parse(moveUserO[0].ToString()) - 1;
            int colO = int.Parse(moveUserO[1].ToString()) - 1;
            grid[rowO, colO] = 'O';
            //Console.WriteLine(grid[rowX, colX]); = displays only X

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
