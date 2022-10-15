using System;

namespace ConsoleApp2
{
    class Program
    {
        static char[] mas = new char[10] {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1;
        static int choice;
        static int win = 0;
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Давайте поиграем в Керстики-Нолики!:)");
                Console.WriteLine("Пишите только числа от 1 до 9");
                Console.WriteLine("Первый игрок играет за X");
                Console.WriteLine("Второй игрок играет за О");
                Console.WriteLine("\n");
                Board();
                if (player % 2 == 0)
                {
                    Console.Write("Игрок 2 выбирает:"+ choice);
                }
                else
                {
                    Console.Write("Игрок 1 выбирает:"+ choice);
                }
                Console.WriteLine("\n");
                choice = int.Parse(Console.ReadLine());
                if (mas[choice] != 'X' && mas[choice] != 'O')
                {
                    if (player % 2 == 0)
                    {
                        mas[choice] = 'O';
                        player++;
                    }
                    else
                    {
                        mas[choice] = 'X';
                        player++;
                    }
                }
                else
                {
                    Console.WriteLine("Извините, строка {0} уже отмечена символом {1}", choice, mas[choice]);
                    Console.WriteLine("\n");
                    Console.WriteLine("Выберите другую ячейку.");
                }
                win = CheckWin();
            }

            while (win != 1 && win != -1);
            Console.Clear();
            Board();
            if (win == 1)
            {
                Console.WriteLine("Игрок {0} был выиграл", (player % 2) + 1);
            }
            else
            {
                Console.WriteLine("Draw");
            }
            Console.ReadLine();
        }
        private static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", mas[1], mas[2], mas[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", mas[4], mas[5], mas[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", mas[7], mas[8], mas[9]);
            Console.WriteLine("     |     |      ");
        }
        private static int CheckWin()
        {
            if (mas[1] == mas[2] && mas[2] == mas[3])// по горизонтали 
            {
                return 1;
            }
            else if (mas[4] == mas[5] && mas[5] == mas[6])
            {
                return 1;
            }

            else if (mas[7] == mas[8] && mas[8] == mas[9])
            {
                return 1;
            }
            else if (mas[1] == mas[4] && mas[4] == mas[7])//по вертикали 
            {
                return 1;
            }
            else if (mas[2] == mas[5] && mas[5] == mas[8])
            {
                return 1;
            }
            else if (mas[3] == mas[6] && mas[6] == mas[9])
            {
                return 1;
            }

            else if (mas[1] == mas[5] && mas[5] == mas[9])//по диагонали
            {
                return 1;
            }
            else if (mas[3] == mas[5] && mas[5] == mas[7])
            {
                return 1;
            }
            else if (mas[1] != '1' && mas[2] != '2' && 
                mas[3] != '3' && mas[4] != '4' && mas[5] != '5' && 
                mas[6] != '6' && mas[7] != '7' && mas[8] != '8' && mas[9] != '9')
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