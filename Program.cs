namespace Assignment_5._3._1
{
    using System;

    class Program
    {
        static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (flowerbed[i] == 0 && (i == 0 || flowerbed[i - 1] == 0) && (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0))
                {
                    flowerbed[i] = 1;
                    n--;
                }
            }

            return n <= 0;
        }

        static void Main(string[] args)
        {
            int[] flowerbed1 = { 1, 0, 0, 0, 1 };
            Console.WriteLine($"Example 1: {CanPlaceFlowers(flowerbed1, 1)}"); 

            int[] flowerbed2 = { 1, 0, 0, 0, 1 };
            Console.WriteLine($"Example 2: {CanPlaceFlowers(flowerbed2, 2)}"); 
        }

    }
}