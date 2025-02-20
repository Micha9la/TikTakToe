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
                Console.WriteLine("Invalid input. Please enter a valid r and c (e.g., '11' for the top-left cell).");
            }
            return userCoordinate;
        }



    public static void PlaceSymbol(char[,] grid, string userCoordinate)
    {
           int row = int.Parse(userCoordinate[0].ToString()) - 1;
           int col = int.Parse(userCoordinate[1].ToString()) - 1;

           // Ensure the USER'S move is within bounds and place 'X'
           if (row < 0 || row >= Constants.GRID_SIZE_ROW || col < 0 || col >= Constants.GRID_SIZE_COLUMN)
             {
                Console.WriteLine("Invalid move! Coordinates out of bounds. Try again.");
                return;
             }

           if (grid[row, col] == '\0')
             {
                grid[row, col] = 'X';
             }
            else
             {
                Console.WriteLine("That cell is already taken! Please choose another.");
                return;
             }

           // Find all available empty cells for the COMPUTER'S move. c = column, r = row
           List<(int, int)> availableCells = new List<(int, int)>();
           for (int r = 0; r < Constants.GRID_SIZE_ROW; r++)
             {
                for (int c = 0; c < Constants.GRID_SIZE_COLUMN; c++)
                {
                    if (grid[r, c] == '\0') // Empty cell
                       {
                            availableCells.Add((r, c));
                       }
                }
             }

           // If there are available moves, let the computer choose randomly
           if (availableCells.Count > 0)
             {
                 Random random = new Random();
                 var (compRow, compCol) = availableCells[random.Next(availableCells.Count)];
                 grid[compRow, compCol] = 'O';
             }
    }
    }

}

//int r = int.Parse(userCoordinate[0].ToString()) - 1;
//int c = int.Parse(userCoordinate[1].ToString()) - 1;

//int rowComputer = int.Parse(computerCoordinatesRows[0].ToString()) - 1;
//int colComputer = int.Parse(computerCoordinatesColumns[1].ToString()) - 1;

//bool currentPlayer = true;
//grid[r, c] = 'X';
//grid[rowComputer, colComputer] = 'O';
//string computerMove = "O";
//string userMove = "X";

//if (currentPlayer == true)
//{
//  grid[r, c] = 'X';
//currentPlayer = false;
//}
//else
//{
//  grid[rowComputer, colComputer] = 'O';
//currentPlayer = true;
//}



