using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 4, 2, 1, 3, 5, 7, 1, 4, 2, 12 };
            List<int> answer = new List<int>();

            answer = numbers.Where(el => el % 2 == 0).OrderBy(x => x).ToList();

            Console.WriteLine(string.Join(",",answer));
        }
    }
}
