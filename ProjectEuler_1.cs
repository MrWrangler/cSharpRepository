

using System;
using System.Collections;
using System.Numerics;

namespace cSharpRepository
{
    class ProjectEuler_1
    {


        static void Main(string[] args)
        {

            Opgave1 opgave1 = new Opgave1();
            Console.WriteLine("Opgave 1 = " + opgave1.projectEuler1());

            Opgave2 opgave2 = new Opgave2();
            Console.WriteLine("Opgave 2 = " + opgave2.projectEuler2());

            Opgave20 opgave20 = new Opgave20();
            Console.WriteLine("Opgave20 = " + opgave20.projectEuler20());

        }
    }
    class Opgave1
    {
        //  https://projecteuler.net/problem=1
        //  Author:  Jes Laursen
        //  Date:   03-04-2019 02:38
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

            return sum;
        }
    }
    class Opgave2
    {
        //  https://projecteuler.net/problem=2
        //  Author:  Jes Laursen
        //  StartDate:   03-04-2019 03:11
        //  EndDate:     03-04-2019 10:47



        public long projectEuler2()
        {
            long sum = 0;
            long number1 = 1;
            long number2 = 2;
            long tempNumber = 0;

            for (long i = 0; i < 4000000; i++)
            {
                if (number2 % 2 == 0)
                {
                    sum = sum + number2;
                }
                tempNumber = number2;
                number2 = number1 + number2;
                number1 = tempNumber;

                if (number2 > 4000000)
                {
                    break;
                }
            }
            return sum;
        }
    }

    class Opgave20
    {
        //  https://projecteuler.net/problem=20
        //  Author:  Jes Laursen
        //  StartDate:   03-04-2019 10:55
        //  EndDate:     03-04-2019 11:32


        public long projectEuler20()
        {
            BigInteger multiplicitet = 1;
            long sum = 0;
            string stringWorker;
            ArrayList list = new ArrayList();

            for (int i = 100 + 1; i > 1; i--)
            {
                multiplicitet = multiplicitet * (i - 1);
            }

            stringWorker = multiplicitet.ToString();

            foreach (var ch in stringWorker)
            {
                sum = sum + (long)Char.GetNumericValue(ch);
            }
            return sum;
        }
    }
}
