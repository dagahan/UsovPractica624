using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] input = File.ReadAllText("numsTask2.txt").Split(';');
        float[] nums = input.Skip(1).Select(float.Parse).ToArray();
        Array.Sort(nums);
        string sortedNumbers = input[0] + ";" + string.Join(";", nums.Select(num => num.ToString()));
        File.WriteAllText("numsTask2.txt", sortedNumbers);
    }
}