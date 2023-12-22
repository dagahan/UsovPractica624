using System;
using System.IO;
using System.Linq;

//Задание 2. Дан файл(nums.txt), содержащий целые числа, через пробел.
//Удалите из него все четные числа;

class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("nums.txt"); //тут открывает файл с числами и записывает каждую строчку (если есть) в каждый новый элемент массива Lines
        
        for (int i = 0; i < lines.Length; i++) //проходится по строчкам (если есть)
        {
            string[] numbers = lines[i].Split(' '); //из текущей сточки выделяет каждое отдельное число в элемент массива с такими цифрами
            numbers = numbers.Where(x => int.Parse(x) % 2 != 0).ToArray(); //если пикнутое число не делится на 2 без остатка то оно нечётное, и следовательно добавляется в массив numbers
            lines[i] = string.Join(" ", numbers); //строчка с оставшимися числами перезаписывается
        }

        File.WriteAllLines("nums.txt", lines);
    }
}