using System;
using System.Collections.Generic;
using System.Linq;

//Задание 2. Заполните массив последовательными нечетными числами, начиная с 1;

class Program
{
    static void Main()
    {
        int[] numbers = new int[100];
        int currentNumber = 1; //просто берёт единицу в качестве начала
        
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = currentNumber;
            currentNumber += 2; //и на каждый шаг заполняет числами на 2 больше предыдущего, т.е. они все не четные
            Console.WriteLine(numbers[i]);
        }
    }
}