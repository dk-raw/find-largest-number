﻿using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            FindLargestNumber();
        }
        private static void FindLargestNumber()
        {
            int[] p = new int[] { 5, 8, 9, 2, 3, 7 };
            int max = p[0];
            for (int i = 1; i < p.Length; i++)
            {
                if (p[i] > max)
                {
                    max = p[i];
                }
            }
            Console.WriteLine(max);
        }
    }
}
