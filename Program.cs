using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        if (!int.TryParse(Console.ReadLine(), out int number))
        {
            Console.WriteLine("Ошибка ввода. Введите целое число.");
            return;
        }

        bool isEven = number % 2 == 0;

        if (isEven)
        {
            Console.WriteLine("Число является четным.");
        }
        else
        {
            Console.WriteLine("Число не является четным.");
        }
    }
}
