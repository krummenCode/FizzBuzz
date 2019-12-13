using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzClass fb = new FizzBuzzClass();

            for (int number = 1; number < 101; number++)
            {
                //if Divisable by 5 and 3
                if(number % 5 == 0 && number % 3 == 0 )
                {
                    Console.WriteLine("FizBuzz");
                }
                //Divisable by 5 but not 3
                if(number % 5 == 0 && number % 3 != 0 )
                {
                    Console.WriteLine("Buzz");
                }
                //Divisable by 3 but not 5
                if(number % 3 == 0 && number % 5 != 0)
                {
                    Console.WriteLine("Fizz");
                }
                if(number % 1 == 0 && number % 3 != 0 && number % 5 != 0)
                {
                    Console.WriteLine(number);
                }
            }

            //exit
            Console.ReadLine();
        }
    }
}
