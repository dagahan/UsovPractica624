using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] words = File.ReadAllLines("numsTask2.txt");
        string result = String.Join(" ", words);
        Console.WriteLine(result);
    }
}