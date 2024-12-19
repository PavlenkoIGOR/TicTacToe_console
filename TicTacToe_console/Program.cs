namespace TicTacToe_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Установить размер окна консоли
            Console.SetWindowSize(70, 38);

            // Установить размер буфера консоли (если нужно)
            //Console.SetBufferSize(60, 60);
            sbyte result = default;
            char[] arr = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            Dictionary<sbyte, sbyte[]> coordinates = new Dictionary<sbyte, sbyte[]>()
            {
                { 1, [2,2] },       { 2, [14, 2] },     { 3, [26, 2] },
                { 4, [2, 14] },     { 5, [14, 14] },    { 6, [26, 14] },
                { 7, [2, 26] },     { 8, [14, 26] },    { 9, [26, 26] }
            };
            foreach (var key in coordinates.Keys)
            {
                sbyte[] coord = coordinates[key];
                //DrawX(coord[0], coord[1], 8);
            }


            for (int i = 0; i < coordinates.Count; i++) 
            {
                DrawField(36, 36, 12);
                Console.SetCursorPosition(40, 1);
                Console.Write("enter number of cell: ");
                bool parsed = sbyte.TryParse(Console.ReadLine(), out result);
                if (parsed)
                {
                    sbyte[] aaarr = coordinates[result];
                    DrawX(aaarr[0], aaarr[1], 8);
                }
                Console.SetCursorPosition(64, 1);
            }



            
            //
            Console.ReadLine();
        }
        static void DrawField(int w, int h, int cellSize)
        {
            for (int y = 0; y <= h; y += cellSize)
            {
                for (int x = 0; x < w; x++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("██");
                }
            }
            for (int x = 0; x <= w; x += cellSize)
            {
                for (int y = 0; y <= h; y++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("█");
                }
            }
        }
        static void DrawX(int x, int y, int size)
        {
            for (int i = x; i <= x + size; i++)
            {
                for (int j = y; j <= y + size; j++)
                {
                    if (i - j == x - y || i + j == y + x + size)
                    {
                        Console.SetCursorPosition(i, j);
                        Console.WriteLine("█");
                    }
                }
            }
        }
        static void DrawO(int x, int y, int size)
        {
            for (int i = x; i <= x + size; i++)
            {
                for (int j = y; j <= y + size; j++)
                {
                    if (i == x || i == x + size || j == y || j == y + size)
                    {
                        Console.SetCursorPosition(i, j);
                        Console.WriteLine("█");
                    }
                }
            }
        }

        static int CheckWin(int[] arr)
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
    }
}
