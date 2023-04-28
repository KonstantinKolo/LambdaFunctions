using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ', '/','.',',','?','!','(',')',';',':','[',']','\'','\"','\\').ToList();
            List<string> answer = input.Where(el => el != "").Where(el => el.Length < 5).Select(el => el.ToLower()).Distinct().OrderBy(el => el).ToList();
            Console.WriteLine(string.Join(", ",answer));
        }
    }
}
