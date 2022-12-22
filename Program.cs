using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool notPrime = false;
            int j;

            Console.WriteLine("Please enter the first number");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number");
            int n2 = int.Parse(Console.ReadLine());

            for (int i = n1; i <= n2; i++)
            {
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        notPrime = true;
                        break;
                    }
                }

                if (!notPrime)
                    Console.WriteLine( j);
                else
                    notPrime = false;
            }

        }
    }
    }

