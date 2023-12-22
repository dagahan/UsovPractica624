using System;
using System.Collections.Generic;
using System.Linq;

//Задание 4. Напишите функцию, которая заполняет список случайными числами в
//диапазоне, указанном пользователем. Функция принимает начало диапазона и его конец,
//и возвращает целочисленный массив. С помощью специальной формы цикла for
//выведете элементы получившегося массив в одну строку, с пробелами;

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

    public static int[] GenerateRandomList(int start, int end, int length) //минимальный придел для генерации числа и максимальный, размер (колличество элементов в массиве)
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