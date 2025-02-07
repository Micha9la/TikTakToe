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
        
        public static string GetUserChoice(string message)
        {
            Console.WriteLine(message); 
            string answerToMessage = Console.ReadLine();            
            return answerToMessage;
        }

        public static void PlaceSymbol(char[,] grid, string coordinateUser)
        {
            int row = int.Parse(coordinateUser[0].ToString()) - 1;
            int col = int.Parse(coordinateUser[1].ToString()) - 1;
            
                grid[row, col] = 'X';
        }

        //public static void GetUserChoice()


        //public static void Move(string moveUser)
        //{
        // int rowX = int.Parse(moveUser[0].ToString()) - 1;
        //int colX = int.Parse(moveUser[1].ToString()) - 1;
        //grid[row, col] = 'X';
        //UIMethod.Move(moveUser);
        //}
    }
}
