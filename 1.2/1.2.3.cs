using System;

class Program
{
    static void Main()
    {
        int n = 5;
        int[,] matrix = new int[n, n];
        
        for (int i = 0; i < n; i++)
        {
            matrix[0, i] = 1;
            matrix[i, 0] = 1;
        }
        
        for (int i = 1; i < n; i++)
        {
            for (int j = 1; j < n; j++)
            {
                matrix[i, j] = matrix[i - 1, j] + matrix[i, j - 1];
            }
        }
        
        for (int i = 0; i < n; i++) //крч вывод
        {
            for (int j = 0; j < n; j++) // i eto strochki a j eto stolbtsi
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}