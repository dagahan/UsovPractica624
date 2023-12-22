using System;
using System.Linq;



public class Program
{
    static void Main()
    {
        Random rnd = new Random();
        var numbers = Enumerable.Range(0, 10).Select(x => rnd.Next(1, 101)).ToArray();
        Console.WriteLine(string.Join(" ", numbers));
    
        var minIndex = Array.IndexOf(numbers, numbers.Min()) + 1;
        Console.WriteLine("Номер минимального элемента: " + minIndex);
    }
}