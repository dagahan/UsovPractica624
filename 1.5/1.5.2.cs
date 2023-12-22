using System;
using System.IO;
using System.Linq;

//Задание 2. Дан файл numsTask2.txt с вещественными числами, расположенными через
//«;». Напишите алгоритм, сортирующий числа по возрастанию. Запишите полученную
//отсортированную последовательность обратно в файл


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