using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGL03
{
    public class Program
    {

        public static int fib(int limit)
        {
            List<int> fibonacci = new List<int>();
            fibonacci.Add(0);
            fibonacci.Add(1);
            Enumerable.Range(2, limit)
                .ToList()
                .ForEach(n => fibonacci.Add(n <= 1 ? 1 : (fibonacci[n - 1] + fibonacci[n - 2])));
            return fibonacci[limit];
        }

        public static int factorial(int limit)
        {
            List<int> factorials = new List<int>();
            factorials.Add(0);
            factorials.Add(1);
            Enumerable.Range(2, limit-1)
                .ToList()
                .ForEach(n => factorials.Add(factorials[n - 1] * n));
            return factorials[limit];
        }


        public static void Main(string[] args)
        {
            Console.WriteLine(fib(10));
            Console.WriteLine(factorial(10));
        }

        
    }

}
