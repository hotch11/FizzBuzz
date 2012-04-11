using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)

        {

            for
                (int x = 1; x <= 100; ++x)
            {
                if (x % 3 == 0 && x % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");

                }

                else
                {
                    if (x % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }

                    if (x % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }

                    if (x % 3 != 0 && x % 5 != 0)
                    {
                        
                        Console.WriteLine(x);
                        
                    }

                        Thread.Sleep(100);

                    
                    
                }
            }
        }
    }
}
