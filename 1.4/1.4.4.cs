using System;
using System.IO;

//Задание 4. Дан файл numsTask4.txt с целыми числами, расположенными через пробел.
//Определите количество одинаковых рядом стоящих чисел;


class Program
{
    static void Main()
    {
        string[] numbersStr = File.ReadAllText("numsTask4.txt").Split(' ');
        int[] numbers = Array.ConvertAll(numbersStr, int.Parse);
        
        int count = 0;

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] == numbers[i - 1])
            {
                count++;
            }
        }
        Console.WriteLine("Количество одинаковых рядом стоящих чисел: " + count);
    }
}