using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
    public static void Main()
    {
        Console.Write("Введите минимальный ограничитель: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Введите максимальный ограничитель: ");
        int max = int.Parse(Console.ReadLine());
        int[] randomList = GenerateRandomList(min, max, 10);
        foreach (int num in randomList)
        {
            Console.Write(num + " ");
        }
    }

    public static int[] GenerateRandomList(int start, int end, int length)
    {
        int[] randomList = new int[length];
        Random rand = new Random();
        for (int i = 0; i < length; i++)
        {
            randomList[i] = rand.Next(start, end + 1);
        }

        return randomList;
    }
}