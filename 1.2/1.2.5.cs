using System;
using System.Collections.Generic;

//Задание 5. Выполните задание 4, используя Dictionary<key, value>. В качестве ключей
//используйте названия месяцев, а в качестве значений – массив температур по дням.
//Напишите метод, который используя данные из словаря вычислит среднюю температуру
//для каждого месяца, и вернет словарь(Dictionary) средних температур (В качестве ключа
//название месяца, в качестве значения коллекция средних температура);

class Program
{
    static void Main()
    {
        //Словарь где месяц название + температура число
        Dictionary<string, double[]> monthTemperatures = new Dictionary<string, double[]>();
        string[] monthNames = new string[12] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };

        Random rand = new Random();
        for (int i = 0; i < 12; i++)
        {
            double[] tempArray = new double[30];
            for (int j = 0; j < 30; j++)
            {
                tempArray[j] = rand.Next(-30, 30);
            }
            monthTemperatures.Add(monthNames[i], tempArray);
        }

        Dictionary<string, double> averageTemperatures = GetAverageTemperature(monthTemperatures);
        foreach (KeyValuePair<string, double> entry in averageTemperatures)
        {
            Console.WriteLine("Месяц " + entry.Key + " Средняя температура: " + entry.Value);
        }
    }

    static Dictionary<string, double> GetAverageTemperature(Dictionary<string, double[]> monthTemperatures)
    {
        Dictionary<string, double> averageTemperatures = new Dictionary<string, double>();
        foreach (KeyValuePair<string, double[]> entry in monthTemperatures)
        {
            double sum = 0;
            foreach (double temp in entry.Value)
            {
                sum += temp;
            }
            averageTemperatures.Add(entry.Key, sum / entry.Value.Length);
        }
        return averageTemperatures;
    }
}