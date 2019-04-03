﻿//  https://projecteuler.net/problem=1
//  Author:  Jes Laursen
//  Date:   03-04-2019 02:38

using System;

namespace cSharpRepository
{
    class ProjectEuler_1
    {


        static void Main(string[] args)
        {

            opgave1 opgave = new opgave1();
            opgave.projectEuler1();
        }
    }
    class opgave1
    {
        public long projectEuler1()
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
                if (i % 5 == 0 && !found)
                {
                    sum = sum + i;
                }
                found = false;
            }
            Console.WriteLine("sum: " + sum);
            return sum;
        }
    }
    class opgave2
    {
        //  https://projecteuler.net/problem=1
        //  Author:  Jes Laursen
        //  StartDate:   03-04-2019 03:11
        //  EndDate:     03-04-2019 03:11

        long sum = 0;
        long lastNumber = 1;
        long nextNumber = 0;

        public long projectEuler2()
        {

            for (long i = 2; i < 4000000;)
            {
                
                nextNumber = lastNumber + i;
                i = i + lastNumber;
                lastNumber = i;
                
            }


            return sum;

            /*
            Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:

        1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...

        By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
             */

        }
    }
}