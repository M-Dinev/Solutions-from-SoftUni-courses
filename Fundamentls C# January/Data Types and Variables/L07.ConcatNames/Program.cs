﻿using System;

namespace L07.ConcatNames
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = Console.ReadLine();
            var secondName = Console.ReadLine();
            var delimiter = Console.ReadLine();

            Console.WriteLine($"{firstName}{delimiter}{secondName}");
        }
    }
}
