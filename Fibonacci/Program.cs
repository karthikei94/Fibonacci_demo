using System;
using System.Collections.Generic;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Fibonacci Program****");
            Console.WriteLine("Please enter a number upto which you want to print fibonacci series");
            Console.WriteLine("------------------");
            Int32.TryParse(Console.ReadLine(), out int n);
            Fibonacci fb = new Fibonacci();
            foreach (var item in fb.FibonacciSeries(n))
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }

    }
    public class Fibonacci
    {
        public List<int> FibonacciSeries(int n)
        {
            var first = 0;
            var second = 1;
            List<int> result = new List<int>();
            result.Add(first);
            result.Add(second);
            for (var i = 2; i < n; i++)
            {
                int last = first + second;
                result.Add(last);
                first = second;
                second = last;
            }
            return result;
        }

    }
}
