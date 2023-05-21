using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rdttest
{
    public class FizzBuzz
    {
        public string Replace(int i)
        {
            var result = string.Empty;

            if (i % 3 == 0)
            {
                result += "Fizz";
            }
            if (i % 5 == 0)
            {
                result += "Buzz";

            }

            if (result.Length == 0)
                result = i.ToString();

            return result;
        }

        public List<string> Incremental(int start, int end)
        {
            var result = new List<string>();
            for (int i = start; i <= end; i++)
            {
                result.Add(Replace(i));
            }

            return result;
        }
    }
}
