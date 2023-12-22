using System;
using System.IO;
using System.Linq;

//Задание 3. Дан файл numsTask3.txt с целыми числами, расположенными через «,».
//Переберите все числа до 0. Определите отношение
//минимального и максимального элементов друг к другу;


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