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
            BankAccount bankAccount = new BankAccount("Bhoomika",11);
            bankAccount.Deposit();
            bankAccount.Withdraw();

            BankAccount bankAccount2 = new BankAccount("Sparsha",12);
            bankAccount2.Deposit();
            bankAccount2.Withdraw();
            Console.ReadKey();

        }
    }
}
