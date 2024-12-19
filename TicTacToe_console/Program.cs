namespace TicTacToe_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            DrawField(31, 30, 10);
            DrawX(31, 30, 10);
            DrawO(31, 30, 10);            
        }
        static void DrawField(int w, int h, int cellSize)
        {
            for (int y = 0; y <= h; y += cellSize)
            {
                for (int x = 0; x < w; x++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("█");
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

        static void Check()
        {
            char[,] arr = { 
                { '1',' ' },
                { '2',' ' },
                { '3',' ' },
                { '4',' ' },
                { '5',' ' },
                { '6',' ' },
                { '7',' ' },
                { '8',' ' },
                { '9',' ' }
            }; 
        }
    }
}
