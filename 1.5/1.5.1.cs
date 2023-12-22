using System;
using System.IO;
using System.Linq;

//Задание 1. Дан файл numsTask1.txt с целыми числами, вычислите произведение
//элементов расположенных после минимального


class Program
{
    static void Main()
    {
        string[] input = File.ReadAllText("numsTask1.txt").Split(' ');
        
        int minIndex = Array.IndexOf(input, input.Min());
        int[] arr = input.Skip(minIndex + 1)
            .Select(int.Parse)
            .ToArray();
                       
        int result = 1;
        foreach (int num in arr)
        {
            result *= num;
        }
    
        Console.WriteLine(result);
    }
}