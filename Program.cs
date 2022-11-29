namespace pr2
{
    internal class Program
    {
        static void RandomNum()
        {
            Console.Clear();
            Console.WriteLine("Поиск рандомного числа");
            Random random = new Random();
            int rnd_num = random.Next(1, 100);
            while (true)
            {
                Console.Write("Ввод числа: ");
                int user_input = Convert.ToInt32(Console.ReadLine());

                if (user_input == rnd_num)
                {
                    Console.WriteLine($"Вы угадали число {rnd_num}");
                    break;
                }
                else if (user_input > rnd_num)
                {
                    Console.WriteLine($"Введенное число больше загаданного");
                }
                else
                {
                    Console.WriteLine($"Введенное число меньше загаданного");
                }
            }
            Console.WriteLine("Нажмите любую клавишу для продолжения");
            Console.ReadKey();
        }
        static void MultipTable()
        {
            Console.Clear();
            Console.WriteLine("Таблица умножения\n");
            int[,] nums = new int[10, 10];
            string ots;
            for (int h = 1; h < 10; h++)
            {
                for (int w = 1; w < 10; w++)
                {
                    nums[h, w] = h * w;
                    if (h * w > 9)
                    {
                        ots = "   ";
                    }
                    else
                    {
                        ots = "    ";
                    }
                    Console.Write($"{nums[h, w]}{ots}");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Нажмите любую клавишу для продолжения");
            Console.ReadKey();
        }
        static void DividerSearch()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Поиск делителей числа");
                Console.Write("Введите число или \"Выход\": ");
                string input = Console.ReadLine().ToLower();
                if (input == "выход")
                {
                    break;
                }
                int number = Convert.ToInt32(input);
                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        Console.Write($"{i}  ");
                    }
                }
                Console.WriteLine("\nНажмите любую клавишу для продолжения");
                Console.ReadKey();
            }

        }
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Выбор программы\n1. Угадай число\n2. Таблица умножения\n3. Вывод делителей числа\n4. Закрыть программу");
                int prog = Convert.ToInt32(Console.ReadLine());
                switch (prog)
                {
                    case 1:
                        RandomNum();
                        break;
                    case 2:
                        MultipTable();
                        break;
                    case 3:
                        DividerSearch();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}