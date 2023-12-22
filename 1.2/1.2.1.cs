using System;
using System.Collections.Generic;
using System.Linq;


//Задание 1. Создайте коллекцию(массив) размерностью 100. Добавьте в коллекцию числа
//в убывающем порядке, каждое число меньше предыдущего на 3;


class Program
{
    static void Main() //ну короче тут будет чето типо 300, 297, 294...6, 3...
    {
        int[] numbers = new int[100];
        int currentNumber = 300;

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = currentNumber;
            currentNumber -= 3;
            Console.WriteLine(numbers[i]);
        }
    }
}