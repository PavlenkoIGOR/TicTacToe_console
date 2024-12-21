using System.Threading.Tasks;
namespace TicTacToe_console
{
    internal class Program
    {
        static DrawingOClass _drawingOClass = new DrawingOClass();
        static DrawingXClass _drawingXClass = new DrawingXClass();
        static DrawingField _drawingField = new DrawingField();
        internal static void Main()
        {
            Console.SetWindowSize(74, 38);
            sbyte result = default;
            char[] arr = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 'o' || arr[i] != 'x')
                {

                } 
            }
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
            sbyte playerNum = default;
            Random random = new Random();
            playerNum = (sbyte)random.Next(1, 3);
            var t = Task.Run(async() => 
            {
                Console.Write("Идёт определения очерёдности ходов...");
                
                await Task.Delay(1500);
                Console.SetCursorPosition(0, 0);
                Console.Clear();
                Console.Write($"Первым ходит игрок {playerNum}");
                await Task.Delay(1500);
                Console.SetCursorPosition(0, 0);
            }); 
            t.Wait();
            _drawingField.DrawField(36, 36, 12);
            _drawingField.FillFieldByNumbers(coordinates, arr);
            for (int i = 0; i < 9; i++)
            {
                Console.SetCursorPosition(40, 1);
                Console.WriteLine($"Ходит игрок {playerNum} - {(playerNum == 1 ? 'X' : 'O')}");

                bool validInput = false;
                do
                {

                    Console.SetCursorPosition(40, 2);
                    Console.Write($"Игрок {playerNum} введите номер клетки:     ");
                    Console.SetCursorPosition(40, 2);
                    Console.Write($"Игрок {playerNum} введите номер клетки: ");

                    bool parsed = sbyte.TryParse(Console.ReadLine(), out result);
                    Console.SetCursorPosition(40, 3);
                    Console.Write(new string(' ', "Эта клетка уже занята. Попробуйте другую.".Length));
                    if (parsed && result >= 1 && result <= 9)
                    {
                        if (arr[result - 1] != 'X' && arr[result - 1] != 'O') // Проверка на занятость клетки
                        {
                            sbyte[] aaarr = coordinates[result];
                            if (playerNum == 1)
                            {
                                _drawingXClass.DrawX(aaarr[0], aaarr[1], 8);
                                arr[result - 1] = 'X'; // Сохранение состояния клетки
                            }
                            else
                            {
                                _drawingOClass.DrawO(aaarr[0], aaarr[1], 8);
                                arr[result - 1] = 'O'; // Сохранение состояния клетки
                            }
                            validInput = true; // Успешный ввод
                        }
                        else
                        {
                            Console.SetCursorPosition(40, 3);
                            Console.WriteLine("Эта клетка уже занята. Попробуйте другую.");
                        }
                    }
                    else
                    {
                        Console.SetCursorPosition(40, 3);
                        Console.WriteLine("Некорректный ввод. Нужно число от 1 до 9.");
                    }
                } while (!validInput);
                if (CheckWin(arr) == 1)
                {
                    Console.Clear();
                    Console.WriteLine($"Игрок {playerNum} победил и получает свободу!");
                    return;
                }
                else if (CheckWin(arr) == -1) 
                {
                    Console.Clear();
                    Console.WriteLine($"Ничья!");
                    return;
                }

                
                // Смена игрока
                playerNum = (sbyte)(playerNum == 1 ? 2 : 1);
            }
            Console.ReadLine();
        } 
        

        static sbyte CheckWin(char[] arr)
        {
            #region Horzontal Winning Condtion
            //Winning Condition For First Row
            if (arr[0] == arr[1] && arr[1] == arr[2])
            {
                return 1;
            }
            
            else if (arr[3] == arr[4] && arr[4] == arr[5])
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
            else if (arr[0] == arr[3] && arr[3] == arr[6])
            {
                return 1;
            }
            //Winning Condition For Second Column
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }
            //Winning Condition For Third Column
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }
            #endregion
            #region Diagonal Winning Condition
            else if (arr[0] == arr[4] && arr[4] == arr[8])
            {
                return 1;
            }
            else if (arr[2] == arr[4] && arr[4] == arr[6])
            {
                return 1;
            }
            #endregion
           
            else if (arr[0] != '1' && arr[1] != '2' && arr[2] != '3' && arr[3] != '4' && arr[4] != '5' && arr[5] != '6' && arr[6] != '7' && arr[7] != '8' && arr[8] != '9')
            {
                return -1;
            }
            
            else
            {
                return 0;
            }
        }
    }
}
