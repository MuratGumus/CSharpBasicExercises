using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vsdeneme2
{
    public class Customer
    {
        public string Name;
        public string Surname;
        public int Salary;
        public String Gender;
        private int Age;

        public Customer()
        {
            Console.WriteLine("Staring");
        }



        public void showInformationOfCustomer()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Surname);
            Console.WriteLine(Salary);
            Console.WriteLine(Gender);
            Console.WriteLine(Age);
        }

        private void showNameAndSurname(string nameOfCustomer, string surnameOfCustomer)
        {
            Console.WriteLine(nameOfCustomer + surnameOfCustomer);
        }
    }
}
