using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc1 = new BankAccount();
            acc1.Id = 1234;
            acc1.Balance = 12531.48;

            BankAccount acc2 = new BankAccount();
            acc2.Id = 9876;
            acc2.Balance = 852487.64;

            List<BankAccount> list = new List<BankAccount>();
            list.Add(acc1);
            list.Add(acc2);

            Person p1 = new Person("Gosho", 14,list);

            p1.IntroduceYourself();
            foreach(var account in list)
            {
                account.Print();
            }
        }
    }
}
