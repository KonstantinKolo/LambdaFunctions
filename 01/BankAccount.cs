using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class BankAccount
    {
        private int id;
        private double balance;

        public int Id { get; set; }
        public double Balance { get; set; }

        public void Print()
        {
            Console.WriteLine($"{Id} with {Balance}");
        }
    }
}
