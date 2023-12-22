using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] numbers = File.ReadAllText("numsTask3.txt").Split(',');

        int[] intNumbers = Array.ConvertAll(numbers, int.Parse);

        int min = intNumbers.Min();
        int max = intNumbers.Max();

        Console.WriteLine("Минимальное значение: " + min);
        Console.WriteLine("Максимальное значение: " + max);
        
        double ratio = (double)min / max;
        Console.WriteLine("Отношение минимального к максимальному: " + ratio);
    }
}