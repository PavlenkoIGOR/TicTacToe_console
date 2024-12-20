namespace TicTacToe_console
{
    internal class DrawingField
    {
        internal void DrawField(int w, int h, int cellSize)
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

        internal void FillFieldByNumbers(Dictionary<sbyte, sbyte[]> coord, char[]nums)
        {
            sbyte i = 0;
            foreach (var value in coord.Values)
            {
                Console.SetCursorPosition(value[0], value[1]);
                Console.Write(nums[i++]);
            }
        }
    }
}
