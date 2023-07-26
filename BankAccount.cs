using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment16_PropertiesOfC_
{
    public class BankAccount
    {
		private int accountNumber;

		public int AccountNumber
		{
			get { return accountNumber; }
		}
		private string accountHolderName;

		public string AccountHolderName
		{
			get { return accountHolderName; }
			set { accountHolderName = value; }
		}
		private double balance;

		public double Balance
		{
			get { return balance; }
		}
        public BankAccount(string accountHolderName)
        {
			this.accountHolderName = accountHolderName;
            balance = 0;
        }
		public void Deposit()
		{
            Console.WriteLine("Enter Amount to Deposit: ");
			double amount = double.Parse(Console.ReadLine());
			balance += amount;
            Console.WriteLine("Account Holder Name: "+accountHolderName);
            Console.WriteLine("Balance Amount= "+balance);
        }
		public void Withdraw()
		{
            Console.WriteLine("Enter Amount to Withdraw: ");
			double amount = double.Parse(Console.ReadLine());
			balance -= amount;
            Console.WriteLine("Account Holder Name: " + accountHolderName);
            Console.WriteLine("Balance Amount= " + balance);
        }

    }
}
