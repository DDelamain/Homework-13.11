using System;

namespace SquareDrawerApp
{
    class Program
    {
        static void DrawSquare(int sideLength, char symbol)
        {
            if (sideLength <= 0)
            {
                Console.WriteLine("Длина стороны должна быть положительной!");
                return;
            }
            for (int i = 0; i < sideLength; i++)
            {
                for (int j = 0; j < sideLength; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
        static void DrawSquare(int sideLength)
        {
            DrawSquare(sideLength, '*');
        }
        static void Main()
        {
            Console.Write("Введи размер стороны: ");
            int size = int.Parse(Console.ReadLine());
            Console.Write("Введи символ: ");
            string input = Console.ReadLine();
            char sym = '*';
            if (!string.IsNullOrEmpty(input))
                sym = input[0];
            Console.WriteLine($"\nТвой квадрат {size}*{size}:");
            DrawSquare(size, sym);
        }
    }
}