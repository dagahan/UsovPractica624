using System;

class Program
{
    static void Main()
    {
        string[] monthNames = new string[13];
        
        monthNames[0] = "Январь";
        monthNames[1] = "Февраль";
        monthNames[2] = "Март";
        monthNames[3] = "Апрель";
        monthNames[4] = "Май";
        monthNames[5] = "Июнь";
        monthNames[6] = "Июль";
        monthNames[7] = "Август";
        monthNames[8] = "Сентябрь";
        monthNames[9] = "Октябрь";
        monthNames[10] = "Ноябрь";
        monthNames[11] = "Декабрь";
        
        double[,] temperature = new double[12, 30]; //матрица температур это
        
        //рандомное заполнение матрицы температур
        Random rand = new Random();
        
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 30; j++)
            {
                temperature[i, j] = rand.Next(-30, 30);
            }
        }
        
        
        
        //test 
        for (int i = 0; i < 12; i++) //крч вывод
        {
            for (int j = 0; j < 30; j++) // i eto strochki a j eto stolbtsi
            {
                Console.Write(temperature[i, j] + " ");
            }
            Console.WriteLine();
        }        
        
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Средние Температуры В месяцах:");
        

        double[] averageTemperatures = GetAverageTemperature(temperature);
        Array.Sort(averageTemperatures);
        
        int mn = 0;
        foreach (double temp in averageTemperatures)
        {
            Console.WriteLine("Месяц " + monthNames[mn] + " " + temp);
            mn += 1;
        }
    }


    //вычисление средней температуры
    //каждая строчка в матрице это месяц, а 30 элементов в строчке (столбец) это температура в один из 30 дней месяца.
    static double[] GetAverageTemperature(double[,] temperature)
    {
        double[] averageTemperatures = new double[12];
        
        for (int i = 0; i < 12; i++)
        {
            double sum = 0;
            
            for (int j = 0; j < 30; j++)
            {
                sum += temperature[i, j];
            }
            
            averageTemperatures[i] = sum / 30;
        }
        
        return averageTemperatures;
    }
}