using System;

class Program
{
    static void Main()
    {
        int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
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