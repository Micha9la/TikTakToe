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
            Console.WriteLine(askCoordinates); 
            string userCoordinate = Console.ReadLine();            
            return userCoordinate;
        }

        public static string ProduceRandomMove()
        {
            int randomCoordinateRows = random.Next(Constants.LOWER_NUMBER_ROWS, Constants.UPPER_NUMBER_ROWS);
            int randomCoordinateColumns = random.Next(LOWER_NUMBER_COLUMNS, UPPER_NUMBER_COLUMNS);
            string computerCoordinatesRows = randomCoordinateRows.ToString();
            string computerCoordinatesColumns = randomCoordinateColumns.ToString();
            string computerCoordinates = computerCoordinatesRows + computerCoordinatesColumns;
            return computerCoordinates;
        }

        public static void PlaceSymbol(char[,] grid, string userCoordinate, string computerCoordinates)
        {
            int row = int.Parse(userCoordinate[0].ToString()) - 1;
            int col = int.Parse(userCoordinate[1].ToString()) - 1;
            if ()
                grid[row, col] = 'X';
        }

      
    }
}
