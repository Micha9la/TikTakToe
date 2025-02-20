using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTakToe
{
    public static class LogicMethods
    {
        public static readonly Random random = new Random();
        public static string ProduceRandomMove()
        {
            int randomCoordinateRows = random.Next(1, Constants.GRID_SIZE_ROW + 1);  // 1 to 3
            int randomCoordinateColumns = random.Next(1, Constants.GRID_SIZE_COLUMN + 1);  // 1 to 3

            return randomCoordinateRows.ToString() + randomCoordinateColumns.ToString();           
        }

        //int randomCoordinateRows = random.Next(Constants.LOWER_NUMBER_ROWS, Constants.UPPER_NUMBER_ROWS);
        //int randomCoordinateColumns = random.Next(Constants.LOWER_NUMBER_COLUMNS, Constants.UPPER_NUMBER_COLUMNS);
        //string computerCoordinatesRows = randomCoordinateRows.ToString();
        //string computerCoordinatesColumns = randomCoordinateColumns.ToString();
        //string computerCoordinates = computerCoordinatesRows + computerCoordinatesColumns;
        //return computerCoordinates;

    }
}
