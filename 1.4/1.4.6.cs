using System;

//Задание 6. Даны вещественные числа a и b. Определите, принадлежит ли точка с
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
        
        double[,] vertices = { {0, 2}, {2, -3}, {-2, -3} };
        
        double[] vectors = new double[3];

        for (int i = 0; i < 3; i++)
        {
            double x = vertices[(i + 1) % 3, 0] - vertices[i, 0];
            double y = vertices[(i + 1) % 3, 1] - vertices[i, 1];
            vectors[i] = x * (b - vertices[i, 1]) - y * (a - vertices[i, 0]);
        }

        if ((vectors[0] >= 0 && vectors[1] >= 0 && vectors[2] >= 0) || (vectors[0] <= 0 && vectors[1] <= 0 && vectors[2] <= 0))
        {
            Console.WriteLine("Точка (" + a + ", " + b + ") принадлежит заданной области");
        }
        else
        {
            Console.WriteLine("Точка (" + a + ", " + b + ") не принадлежит заданной области");
        }
    }
}