using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTakToe
{
    public static class Constants
    {
        public const int GRID_SIZE_ROW = 3;
        public const int GRID_SIZE_COLUMN = 3;
        public const int UPPER_NUMBER_ROWS = 4;
        public const int LOWER_NUMBER_ROWS = 1;
        public const int UPPER_NUMBER_COLUMNS = 4;
        public const int LOWER_NUMBER_COLUMNS = 1;

        public const int EMPTY_CELL = '\0'; // \0 is a symbol to check if cell is empty
        public const int ZERO_BASED_INDEX_SUBTRACTER = '1';
        public const char USER_SYMBOL = 'X';
        public const char COMPUTER_SYMBOL = 'O';

        public const int COORDINATE_FIRST_ROW = 0;
        public const int COORDINATE_FIRST_COLUMN = 0;

        public const int COORDINATE_SECOND_ROW = 1;
        public const int COORDINATE_SECOND_COLUMN = 1;

        public const int COORDINATE_THIRD_ROW = 2;
        public const int COORDINATE_THIRD_COLUMN = 2;
    }
}
