using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzClass
    {
        public bool Fizz(int number)
        {
            if (number % 3 == 0 && number % 5 != 0)
            {
                return true;
            }
            else {
                return false;
            }
        }

        public bool Buzz(int number)
        {
            if (number % 5 == 0 && number % 3 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool FizzAndBuzz(int number)
        {
            if (number % 5 == 0 && number % 3 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PrintNumbers(int number)
        {
            if (number % 1 == 0 && number % 3 != 0 && number % 5 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
