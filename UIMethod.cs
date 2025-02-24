using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TikTakToe
{
    public static class UIMethod
    {
        static readonly Random random = new Random();
        public static void DisplayGrid(char[,] grid)
        {
            Console.Write("  ");
            for (int columnHeader = 0; columnHeader < Constants.GRID_SIZE_COLUMN; columnHeader++)
            {
                Console.Write(columnHeader + 1 + " ");
            }
            Console.WriteLine();

            for (int lineIndex = 0; lineIndex < Constants.GRID_SIZE_ROW; lineIndex++)
            {
                Console.Write(lineIndex + 1 + " ");
                for (int columnIndex = 0; columnIndex < Constants.GRID_SIZE_COLUMN; columnIndex++)
                {
                    //grid[lineIndex, columnIndex] = '_'; if this is gone it will display the respective sign X at the spot user picked
                    Console.Write(grid[lineIndex, columnIndex] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Above you see tik tak toe grid");

        }

        public static string GetUserChoice(string askCoordinates)
        {
            string userCoordinate;
            while (true)
            {
                Console.WriteLine(askCoordinates);
                userCoordinate = Console.ReadLine();

                // Ensure user enters exactly 2 characters and both are digits
                if (userCoordinate.Length == 2 && char.IsDigit(userCoordinate[0]) && char.IsDigit(userCoordinate[1]))
                {
                    int row = int.Parse(userCoordinate[0].ToString());
                    int col = int.Parse(userCoordinate[1].ToString());

                    if (row >= Constants.LOWER_NUMBER_ROWS && row < Constants.UPPER_NUMBER_ROWS &&
                        col >= Constants.LOWER_NUMBER_COLUMNS && col < Constants.UPPER_NUMBER_COLUMNS)
                    {
                        break;
                    }
                }
                Console.WriteLine("Invalid input. Please enter a valid rpw and column (e.g., '11' for the top-left cell).");
            }
            return userCoordinate;
        }


        public static void PlaceUserMove(char[,] grid, string userCoordinate)
        {
            int row = int.Parse(userCoordinate[0].ToString()) - 1;
            int col = int.Parse(userCoordinate[1].ToString()) - 1;
            grid[row, col] = 'X'; // User always plays 'X'
        }

        public static void PlaceComputerMove(char[,] grid)
        {
            (int row, int col) = LogicMethods.GetRandomAvailableMove(grid);
            if (row != -1 && col != -1)
            {
                grid[row, col] = 'O'; // Computer plays 'O'
            }
        }      
    }
}






