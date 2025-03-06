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
            //prints 2 spaces of alignment
            Console.Write("  ");
            //Prints column numbers (1 2 3) so users see coordinates.
            for (int columnHeader = 0; columnHeader < Constants.GRID_SIZE_COLUMN; columnHeader++)
            {
                Console.Write(columnHeader + 1 + " "); //We add 1 because arrays are zero-based, but users see 1-based indexing.
            }
            Console.WriteLine(); //moves to a new line

            for (int lineIndex = 0; lineIndex < Constants.GRID_SIZE_ROW; lineIndex++)//loops through rows
            {
                Console.Write(lineIndex + 1 + " ");//prints row numbers
                for (int columnIndex = 0; columnIndex < Constants.GRID_SIZE_COLUMN; columnIndex++)
                {
                    //grid[lineIndex, columnIndex] = '_'; if this is gone it will display the respective sign X at the spot user picked
                    Console.Write(grid[lineIndex, columnIndex] + " ");//Prints X, O, or empty space
                }
                Console.WriteLine();//moves to next row
            }
            Console.WriteLine("Above you see tik tak toe grid");

        }

        public static string GetUserChoice(string askCoordinates)
        {
            Console.WriteLine(askCoordinates);
            return Console.ReadLine();
        }

        public static bool CheckGameStatus(char[,] grid, string winnerMessage)
        {
            if (LogicMethods.CheckWinRows(grid) ||
                LogicMethods.CheckWinColumns(grid) ||
                LogicMethods.CheckWinDiagonals(grid))
            {
                Console.WriteLine(winnerMessage);
                return true; // Game is over
            }

            if (LogicMethods.CheckDraw(grid))
            {
                Console.WriteLine("It's a draw!");
                return true; // Game is over
            }

            return false; // Game continues
        }
    }
}






