using System;

//Задание 5. Дана прямоугольная матрица a, имеющей n строк и m столбцов. Исходная
//матрица состоит из нулей и единиц. Добавьте к матрице еще один столбец, каждый
//элемент которого делает количество единиц в каждой строке четным;


class Program
{
    static void Main()
    {
        Random random = new Random();
        int n = 5; //строки
        int m = 5; //столюы
        int[,] matrix = new int[n, m + 1]; //+1
        
        for (int i = 0; i < n; i++) //тут заполняется вся матрица случайными 0 и 1))
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = random.Next(2);
            }
        }

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        //добавлеение столбца
        for (int i = 0; i < n; i++)
        {
            int countOnes = 0;
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] == 1)
                {
                    countOnes++;
                }
            }
            if (countOnes % 2 != 0)
            {
                matrix[i, m] = 1;
            }
            else
            {
                matrix[i, m] = 0;
            }
        }

        Console.WriteLine("Матрица с добавленным столбцом:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m + 1; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}