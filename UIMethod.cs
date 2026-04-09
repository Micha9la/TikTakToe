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
        public static void DisplayGrid(char[,] grid)
        {
            // spacing for top-left corner
            Console.Write("   ");

            // column headers
            for (int columnHeader = Constants.ZERO_BASED_LOWER_BOUND; columnHeader < Constants.GRID_SIZE_COLUMN; columnHeader++)
            {
                Console.Write($" {columnHeader + 1} ");

                if (columnHeader < Constants.GRID_SIZE_COLUMN - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();

            for (int lineIndex = Constants.ZERO_BASED_LOWER_BOUND; lineIndex < Constants.GRID_SIZE_ROW; lineIndex++)
            {
                // row number
                Console.Write($" {lineIndex + 1} ");

                for (int columnIndex = Constants.ZERO_BASED_LOWER_BOUND; columnIndex < Constants.GRID_SIZE_COLUMN; columnIndex++)
                {
                    // 🔥 consistent cell width
                    Console.Write($" {grid[lineIndex, columnIndex]} ");

                    if (columnIndex < Constants.GRID_SIZE_COLUMN - 1)
                    {
                        Console.Write("|");
                    }
                }

                Console.WriteLine();

                // separator
                if (lineIndex < Constants.GRID_SIZE_ROW - 1)
                {
                    Console.Write("   ");

                    for (int separatorIndex = Constants.ZERO_BASED_LOWER_BOUND; separatorIndex < Constants.GRID_SIZE_COLUMN; separatorIndex++)
                    {
                        Console.Write("---");

                        if (separatorIndex < Constants.GRID_SIZE_COLUMN - 1)
                        {
                            Console.Write("+");
                        }
                    }

                    Console.WriteLine();
                }
            }

            Console.WriteLine("Above you see tic tac toe grid");
        }

        public static string GetUserChoice(string askCoordinates)
        {
            Console.WriteLine(askCoordinates);
            return Console.ReadLine();
        }

    }
}






