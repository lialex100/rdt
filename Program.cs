using System.Runtime.Serialization.Formatters;

namespace rdttest;
class Program
{
    static void Main(string[] args)
    {
        var fb= new FizzBuzz();

        var r = fb.Incremental(1, 100);

        foreach (var item in r)
        {
            Console.WriteLine(item);
        }

    }
}