//  https://projecteuler.net/problem=1
//  Author:  Jes Laursen
//  Date:   03-04-2019 02:38

using System;

namespace cSharpRepository
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum = 0;
            bool found = false;
            for (int i = 0; i < 1000; i++) 
            {
                if (i % 3 == 0) 
                {
                    sum = sum + i;
                    found = true;
                }
                if (i % 5 == 0 && !found ) 
                {
                    sum = sum + i;
                }
                found = false;
            }
            Console.WriteLine("sum: " + sum);
        }
    }
}
