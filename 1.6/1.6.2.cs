using System;
using System.IO;

//Задание 2. Дан файл numsTask2.txt со словами расположенными в столбик. Из заданных
//слов составьте одну длинную строку(разделить каждое слово пробелом);


class Program
{
    static void Main()
    {
        string[] words = File.ReadAllLines("numsTask2.txt");
        string result = String.Join(" ", words);
        Console.WriteLine(result);
    }
}