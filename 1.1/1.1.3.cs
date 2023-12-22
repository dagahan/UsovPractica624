using System;
using System.Collections.Generic;
using System.Linq;



public class Program
{
    public static void Main()
    {
        var elements = new List<string>();
        while (true)
        {
            try
            {
                Console.Write("Введите элемент: ");
                var element = Console.ReadLine();
                if (string.IsNullOrEmpty(element))
                {
                    break; // Выход из цикла, если строка пустая
                }

                elements.Add(element);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }

        string mine = elements[0];
        string maxe = elements[0];
        for (int i = 1; i < elements.Count; i++)
        {
            if (elements[i].Length < mine.Length)
            {
                mine = elements[i];
            }
            if (elements[i].Length > maxe.Length)
            {
                maxe = elements[i];
            }
        }

        Console.WriteLine("Самый короткий элемент: " + mine);
        Console.WriteLine("Самый длинный элемент: " + maxe);
    }
}