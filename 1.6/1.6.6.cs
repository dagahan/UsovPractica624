using System;

//Задание 6. Дан массив со случайным количеством дробных чисел. Из элементов
//исходного массива постройте два новых. В первый должны входить только
//положительные элементы, а во второй только отрицательные элементы;


class Program
{
    static void Main()
    {
        Random random = new Random();
        int n = 10;//это размер для массива
        double[] originalArray = new double[n];
        
        for (int i = 0; i < n; i++)//случайн цифры
        {
            originalArray[i] = random.NextDouble() * (random.Next(2) == 0 ? -1 : 1);//число от -1 до 1
        }

        Console.WriteLine("Исходный массив:");
        foreach (var num in originalArray)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        //сколько полож и отриц
        int countPositive = 0;
        int countNegative = 0;
        foreach (var num in originalArray)
        {
            if (num > 0)
            {
                countPositive++;
            }
            else if (num < 0)
            {
                countNegative++;
            }
        }

       
        double[] positiveArray = new double[countPositive];//тут создание новых массивов для положительных и отрицательных элементов
        double[] negativeArray = new double[countNegative];
        int positiveIndex = 0;
        int negativeIndex = 0;
        foreach (var num in originalArray)
        {
            if (num > 0)
            {
                positiveArray[positiveIndex] = num;
                positiveIndex++;
            }
            else if (num < 0)
            {
                negativeArray[negativeIndex] = num;
                negativeIndex++;
                
            }
            
        }
        
        

        Console.WriteLine("Массив положительных элементов:");
        foreach (var num in positiveArray)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Массив отрицательных элементов:");
        foreach (var num in negativeArray)
        {
            Console.Write(num + " ");
        }
        
    }
}