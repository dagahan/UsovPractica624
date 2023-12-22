using System;
using System.Collections.Generic;
using System.Linq;

//Задание 2. Добавляйте новые числа в список до тех пор, пока пользователь не введет 0.
//Выведите в консоль сумму и произведение всех элементов списка. Выведите средннее,
//среди всех элементов списка;

public class Program
{
    public static void Main()
    {
        Random random = new Random();
        int num;
        var numbers = new List<int>();

        while (true)
        {
            Console.WriteLine("Введите число: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num == 0)
            {
                break;
            }

            numbers.Add(num);
        }

        int sum = 0;
        int proizvnumbers = 1;
        foreach (var n in numbers)
        {
            sum += n;
            proizvnumbers *= n;
        }

        double average = (double)sum / numbers.Count;
        Console.WriteLine("Сумма элементов: " + sum);
        Console.WriteLine("Произведение элементов: " + proizvnumbers);
        Console.WriteLine("Среднее значение: " + average);
    }
}