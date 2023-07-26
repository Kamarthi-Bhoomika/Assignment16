using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment16_PropertiesOfC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount("Bhoomika");
            //Console.WriteLine("Enter Name: ");
            //bankAccount.AccountHolderName = Console.ReadLine();
            bankAccount.Deposit();
            bankAccount.Withdraw();
            Console.ReadKey();

        }
    }
}
