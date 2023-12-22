using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("nums.txt");
        
        for (int i = 0; i < lines.Length; i++)
        {
            string[] numbers = lines[i].Split(' ');
            numbers = numbers.Where(x => int.Parse(x) % 2 != 0).ToArray();
            lines[i] = string.Join(" ", numbers);
        }

        File.WriteAllLines("nums.txt", lines);
    }
}