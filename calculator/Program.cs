using System;

namespace ConsoleCalculator
{
    class Program
    {
        static double A = 0, B = 0;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Меню выбора:");
                Console.WriteLine("1. ввести число А");
                Console.WriteLine("2. ввести число B");
                Console.WriteLine("3. выполнить операцию '+'");
                Console.WriteLine("4. выполнить операцию '-'");
                Console.WriteLine("5. выполнить операцию '*'");
                Console.WriteLine("6. выполнить операцию '/'");
                Console.WriteLine("7. выход");
                Console.Write("Ваш выбор: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": InputA(); break;
                    case "2": InputB(); break;
                    case "3": Add(); break;
                    case "4": Subtract(); break;
                    case "5": Multiply(); break;
                    case "6": Divide(); break;
                    case "7": return;
                    default:
                        Console.WriteLine("Неверный ввод. Нажмите любую клавишу...");
                        Console.ReadKey(); break;
                }
            }
        }

        static void InputA()
        {
            Console.Write("Введите значение A: ");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine("A сохранено. Нажмите любую клавишу...");
            Console.ReadKey();
        }

        static void InputB()
        {
            Console.Write("Введите значение B: ");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine("B сохранено. Нажмите любую клавишу...");
            Console.ReadKey();
        }

        static void Add()
        {
            Console.WriteLine($"Результат: {A} + {B} = {A + B}");
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }

        static void Subtract()
        {
            Console.WriteLine($"Результат: {A} - {B} = {A - B}");
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }

        static void Multiply()
        {
            Console.WriteLine($"A * B = {A * B}");
            Console.ReadKey();
        }

        static void Divide()
        {
            if (B == 0)
                Console.WriteLine("Ошибка: деление на ноль");
            else
                Console.WriteLine($"A / B = {A / B}");
            Console.ReadKey();
        }
    }
}