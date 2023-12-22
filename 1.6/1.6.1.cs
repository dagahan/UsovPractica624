using System;
using System.IO;

//Задание 1. Дан файл numsTask1.txt со словами. Выведите все слова нечетной длины;


class Program
{
    static void Main()
    {
        string[] words = File.ReadAllText("numsTask1.txt").Split(' ');
        foreach (string word in words)
        {
            if (word.Length % 2 != 0)
            {
                Console.Write(word + ";");
            }
        }
    }
}