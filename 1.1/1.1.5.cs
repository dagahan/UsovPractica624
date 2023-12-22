using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
    public static void Main()
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();
        string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int wordCount = words.Length;

        input = "Start " + input + " End";

        Console.WriteLine("Количество слов: " + wordCount);
        Console.WriteLine("Измененная строка: " + input);
    }
}