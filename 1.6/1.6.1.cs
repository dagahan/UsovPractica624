using System;
using System.IO;

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