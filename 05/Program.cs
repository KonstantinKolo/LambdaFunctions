using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();           
            int k = input.Length / 4;
            int[] firstNum = input.Take(k).Reverse().ToArray();
            int[] lastNum = input.Reverse().Take(k).ToArray();
            int[] row1 = firstNum.Concat(lastNum).ToArray();
            int[] row2 = input.Skip(k).Take(k * 2).ToArray();

            var sumArr = row1.Select((x, index) => x + row2[index]);

            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}
