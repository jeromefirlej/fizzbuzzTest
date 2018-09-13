using System;
using System.Linq;
using System.Linq.Expressions;

namespace Cours.Implementations
{
    internal class FizzBuzz
    {
        private const string Fizz = "Fizz";

        private const string Buzz = "Buzz";

        public string Get(int input)
        {

            string ret = String.Empty;

            if (input % 3 == 0)
            {
                ret = String.Concat(ret, Fizz);
            }

            if (input % 5 == 0)
            {
                ret = string.Concat(ret, Buzz);
            }

            return ret == String.Empty ? input.ToString(): ret;
        }
    }
}