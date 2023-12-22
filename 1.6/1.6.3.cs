using System;

//Задание 3. Дано число. Определите будет ли это число четным и кратным 10;


class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        
        if (num % 2 == 0)
        {
            Console.WriteLine("Чётное");
        }
        else
        {
            Console.WriteLine("Не Четное");
        }
        
        if (num % 10 == 0)
        {
            Console.WriteLine("Кратное 10");
        }
        else
        {
            Console.WriteLine("Не кратное 10");
        }
    }
}