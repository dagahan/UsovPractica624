using System;

//Задание 1. Дано целое положительное число n. Вычислите произведение натуральных
//чисел, кратных трём и не превышающим число n;


class Program
{
    static void Main()
    {
        Console.WriteLine("Введите целое положительное число n:");
        int n = int.Parse(Console.ReadLine());

        int result = 1;

        for (int i = 3; i <= n; i += 3)
        {
            result *= i;
        }

        Console.WriteLine("Произведение натуральных чисел, кратных трём и не превышающих число n, равно: " + result);
    }
}