﻿
using System;
class DemoSai
{
    static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 5, 5, 5, 6 };
            int count = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j=0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count += 1;
                    }
                }
                Console.WriteLine("{0} is repeated {1} times", arr[i], count);
                count = 0;
            }
            Console.ReadLine();
        }
}