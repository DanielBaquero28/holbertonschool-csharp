﻿using System;

namespace _2_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            for (i = 97; i <= 122; i++)
            {
                Console.Write("{0}", (char) i);
            }
        }
    }
}
