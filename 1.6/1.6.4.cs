using System;

//Задание 4. Вводятся положительные числа. Определите сумму чисел, делящихся на
//положительное число a нацело. При вводе отрицательного числа закончите работу;

class Program
{
    static void Main()
    {
        int a;
        int sum = 0;
        Console.WriteLine("Введите положительное число a:");
        a = Convert.ToInt32(Console.ReadLine());

        while (true)
        {
            try
            {
                Console.WriteLine("Введите положительное число:");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number < 0)
                {
                    break;
                }

                if (number % a == 0)
                {
                    sum += number;
                }
            }
            catch
            {
                Console.WriteLine("Некорректный ввод числа");
            }
        }

        Console.WriteLine("Сумма чисел, делящихся на " + a + " нацело: " + sum);
    }
}