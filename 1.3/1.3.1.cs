using System;
using System.IO;

namespace YourNamespace
{
    class Program
    {

        static void Main()
        {
            string[] input = File.ReadAllLines("input.txt");

            if (input.Length < 3) // Check if input contains enough elements
            {
                Console.WriteLine("Input data is not in the expected format.");
                return;
            }

            string[] chosenNumbers = input[0].Split(' ');
            int n;

            if (!int.TryParse(input[1], out n)) // Check if n can be parsed as an integer
            {
                Console.WriteLine("Invalid value for n.");
                return;
            }

            string[] output = new string[n];

            for (int i = 0; i < n; i++)
            {
                if (input.Length < i + 3) // Check if input contains enough elements for ticketNumbers
                {
                    Console.WriteLine("Not enough ticket numbers in input data.");
                    return;
                }

                string[] ticketNumbers = input[i + 2].Split(' ');
                int count = 0;

                foreach (string number in ticketNumbers)
                {
                    if (Array.IndexOf(chosenNumbers, number) != -1)
                    {
                        count++;
                    }
                }

                output[i] = count >= 3 ? "Lucky" : "Unlucky";
            }

            File.WriteAllLines("output.txt", output);
        }
    }
}