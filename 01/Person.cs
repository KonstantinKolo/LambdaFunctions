using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Person
    {
        private string name;
        private int age;
        private List<BankAccount> account;

        public string Name { get; set; }
        public int Age { get; set; }
        public List<BankAccount> Account { get; set; }

        public Person(string name,int age): this(name, age, new List<BankAccount>())
        {
        }
        public Person(string name, int age, List<BankAccount> account)
        {
            this.Name = name;
            this.Age = age;
            this.Account = account;
        }

        public void IntroduceYourself()
        {
            Console.WriteLine("This is {0} and he is {1}", Name, Age);
        }
    }
}
