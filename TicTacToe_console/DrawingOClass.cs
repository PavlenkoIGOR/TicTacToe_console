using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_console
{
    internal class DrawingOClass
    {
        internal void DrawO(int x, int y, int size)
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
    }
}
