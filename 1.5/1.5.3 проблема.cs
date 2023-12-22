using System;
using System.IO;

class Program
{
    static void Main()
    {
        string line;
        using (StreamReader reader = new StreamReader("numsTask3.txt"))
        {
            line = reader.ReadLine();
        }
        string[] numbers = line.Split(';');
        int minIndex = 0;
        int min = int.Parse(numbers[0]);
        for (int i = 0; i < numbers.Length; i++)
        {
            int num = int.Parse(numbers[i]);
            if (num < min)
            {
                min = num;
                minIndex = i;
            }
        }
        double sum = 0;
        for (int i = 0; i < minIndex; i++)
        {
            sum += int.Parse(numbers[i]);
        }
        double average = sum / minIndex;
        Console.WriteLine("Среднее арифметическое: " + average);
    }
}