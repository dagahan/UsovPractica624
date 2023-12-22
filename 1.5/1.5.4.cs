using System;
using System.IO;

//Задание 4. Дан файл numsTask4.txt с целыми числами. Вычислите сумму элементов,
//отличающихся от максимального на 1;

class Program
{
    static void Main()
    {
        string line;
        using (StreamReader reader = new StreamReader("numsTask4.txt"))
        {
            line = reader.ReadLine();
        }
        string[] numbers = line.Split(';');
        int max = int.Parse(numbers[0]);
        int sum = 0;
        for (int i = 1; i < numbers.Length; i++)
        {
            int num = int.Parse(numbers[i]);
            if (num == max - 1 || num == max + 1)
            {
                sum += num;
            }
            if (num > max)
            {
                max = num;
            }
        }
        Console.WriteLine("Сумма элементов, отличающихся от максимального на 1: " + sum);
    }
}