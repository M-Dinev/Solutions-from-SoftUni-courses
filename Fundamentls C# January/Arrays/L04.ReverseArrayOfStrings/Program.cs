﻿using System;

namespace L04.ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split();

            //for (int i = text.Length - 1; i >= 0; i++)
            //{

            //}

            Array.Reverse(text);

            Console.WriteLine(string.Join(" ", text));

        }
    }
}
