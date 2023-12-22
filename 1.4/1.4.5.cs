using System;

//Задание 5. Даны вещественные числа a и b. Определите, принадлежит ли точка с
//координатами (a; b) заштрихованной области;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите координаты точки (a b):");
        string input = Console.ReadLine();
        string[] coordinates = input.Split(' ');
        
        double a = Convert.ToDouble(coordinates[0]);
        double b = Convert.ToDouble(coordinates[1]);
        
        if (a >= -1 && a <= 3 && b >= -2 && b <= 4)
        {
            Console.WriteLine("Точка (" + a + ", " + b + ") принадлежит заданной области");
        }
        else
        {
            Console.WriteLine("Точка (" + a + ", " + b + ") не принадлежит заданной области");
        }
    }
}