using System;

//Задание 3. Дан файл, содержащий несколько целых чисел количеством i. Создайте
//массив height длиной i. Каждый элемент массива это вертикальная линия определенной
//длины. Найдите две линии, которые вместе с осью x образуют контейнер, содержащий
//наибольшее количество воды;


class Program
{
    static void Main()
    {
        Random rand = new Random();
        string iString = File.ReadAllText("i.txt");
        int i = int.Parse(iString);

        int[] height = new int[i];
        for (int j = 0; j < i; j++)
        {
            height[j] = rand.Next(1, 10);
            Console.WriteLine(height[j]);
        }
       
        int maxArea = MaxArea(height);
        Console.WriteLine(maxArea);
    }

    static int MaxArea(int[] height)
    {
        int maxArea = 0;
        int left = 0;
        int right = height.Length - 1;

        while (left < right)
        {
            Console.WriteLine("left: " + left); //test
            Console.WriteLine("right: " + right); //test
            
            
            int h = Math.Min(height[left], height[right]);
            int w = right - left;
            maxArea = Math.Max(maxArea, h * w);

            
            Console.WriteLine("H: " + h); //test
            Console.WriteLine("W: " + w); //test
            
            
            if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
            
            Console.WriteLine("-----------------------"); //test
        }

        return maxArea;
    }
}