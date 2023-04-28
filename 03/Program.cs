using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            var sorted = input.OrderByDescending(x=>x);
            var largestnums = sorted.Take(3);
            Console.WriteLine(string.Join(" ",largestnums));
        }
    }
}
