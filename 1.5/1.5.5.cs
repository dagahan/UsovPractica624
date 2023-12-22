using System;
using System.IO;
using System.Linq;

//Задание 5. Дан файл numsTask5.txt с целыми числами. Вычислите среднее
//арифметическое элементов расположенных между минимальным и максимальным;

class Program
{
    static void Main()
    {
        string filePath = "numsTask5.txt";
        string fileContent = File.ReadAllText(filePath);
        string[] numbersStr = fileContent.Split(';');
        int[] numbers = Array.ConvertAll(numbersStr, int.Parse);

        int minIndex = Array.IndexOf(numbers, numbers.Min());
        int maxIndex = Array.IndexOf(numbers, numbers.Max());

        int start = Math.Min(minIndex, maxIndex) + 1;
        int end = Math.Max(minIndex, maxIndex);

        int sum = 0;
        for (int i = start; i < end; i++)
        {
            sum += numbers[i];
        }

        double average = (double)sum / (end - start);
        Console.WriteLine("Среднее арифметическое: " + average);
    }
}