using System;
using System.Collections.Generic;
using System.Linq;

//Задание 5. В строке, которую вводит пользователь, определите количество слов,
//добавьте в начало строки слово Start и в конец строки слово End;

public class Program
{
    public static void Main()
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();
        string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); //распихивает стринги по элементам массива, а сами стринги находит из входного стринга, смотря на разделитель "пробел" между нимию.
        int wordCount = words.Length;

        input = "Start " + input + " End";

        Console.WriteLine("Количество слов: " + wordCount);
        Console.WriteLine("Измененная строка: " + input);
    }
}