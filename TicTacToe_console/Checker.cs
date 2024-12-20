using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_console
{
    internal class Checker
    {
        internal int CheckWin(int[] arr)
        {
            #region Horzontal Winning Condtion
            //Winning Condition For First Row
            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }
            //Winning Condition For Second Row
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }
            //Winning Condition For Third Row
            else if (arr[6] == arr[7] && arr[7] == arr[8])
            {
                return 1;
            }
            #endregion
            #region vertical Winning Condtion
            //Winning Condition For First Column
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }
            //Winning Condition For Second Column
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }
            //Winning Condition For Third Column
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                return 1;
            }
            #endregion
            #region Diagonal Winning Condition
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }
            #endregion
            #region Checking For Draw
            // If all the cells or values filled with X or O then any player has won the match
            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {
                return -1;
            }
            #endregion
            else
            {
                return 0;
            }
        }

        // Все возможные выигрышные комбинации
        int[,] winningCombinations = new int[,]
        {
            { 0, 1, 2 }, // 1, 2, 3
            { 3, 4, 5 }, // 4, 5, 6
            { 6, 7, 8 }, // 7, 8, 9
            { 0, 3, 6 }, // 1, 4, 7
            { 1, 4, 7 }, // 2, 5, 8
            { 2, 5, 8 }, // 3, 6, 9
            { 0, 4, 8 }, // 1, 5, 9
            { 2, 4, 6 }  // 3, 5, 7
        };
    }
}
