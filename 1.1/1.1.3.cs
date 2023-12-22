using System;
using System.Collections.Generic;
using System.Linq;

//Задание 3. Добавляйте новые элементы в список до тех пор, пока пользователь не
//отправит пустую строку. Выведите в консоль самый короткий
//и самый длинный элементы списка;

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
                if (string.IsNullOrEmpty(element))//Выход из вот этого цикла по добавлению если строка пустая
                {
                    break;
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