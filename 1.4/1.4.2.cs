using System;
using System.IO;

//Задание 2. Дан файл numsTask2.txt с вещественными числами, расположенными через
//«;» Переберите все числа до 0. Определите сумму положительных элементов
//получившейся последовательности;

class Program
{
    static void Main()
    {
        string[] numbers = File.ReadAllText("numsTask2.txt").Split(';');
        
        double sum = 0;
        foreach (string num in numbers)
        {
            double current = double.Parse(num);
            if (current <= 0)
            {
                break;
            }
            if (current > 0)
            {
                sum += current;
            }
        }

        Console.WriteLine("Сумма положительных элементов последовательности: " + sum);
    }
}