using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Bank
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public Bank(string accountNumber, decimal balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public virtual void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount:C} to account {AccountNumber}. New balance: {Balance:C}");
        }

        public virtual void Withdraw(decimal amount)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrew {amount:C} from account {AccountNumber}. New balance: {Balance:C}");
        }

        public virtual void CalculateInterest()
        {
            Console.WriteLine("Calculating interest for a general bank account.");
        }


    }
    class ICICI : Bank
    {

        public ICICI(string accountNumber, decimal balance)
        : base(accountNumber, balance)
        {
        }

        public override void CalculateInterest()
        {
            decimal interest = Balance * 0.04m; 
            Balance += interest;
            Console.WriteLine("ICICI BANK void method");
        }
    }
    class YES : Bank
    {
        public YES(string accountNumber, decimal balance)
        : base(accountNumber, balance)
        {
        }

        public override void CalculateInterest()
        {
            decimal interest = Balance * 0.05m; 
            Balance += interest;
            Console.WriteLine("YES BANK void method");
        }
    }
    internal class bank
    {
        static void Main()
        {
            ICICI obj1 = new ICICI("ICICI123", 3000);
            obj1.Deposit(1000);
            obj1.Withdraw(500);
            obj1.CalculateInterest();

            YES obj2 = new YES("YES456", 4000);
            obj2.Deposit(2000);
            obj2.Withdraw(1000);
            obj2.CalculateInterest();

        }
    }
}
