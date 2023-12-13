using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    internal class Account
    {
        public string Language { get; set; }
        public string AccountNumber { get; set; }
        public double Balance { get; set; }
        public Customer Customer{ get; set; }

        public double CheckingBalance { get; set; }
        public double SavingsBalance { get; set; }

      

        public bool IsLogged { get; set; } = false;
        public string AccountPin { get; set; }


        public Account( string AccountNumber, double Balance, string AccountPin)
        {
            this.AccountNumber = AccountNumber;
            
            this.Balance = Balance;
            this.AccountPin = AccountPin;
        }

        


        public virtual void DisplayBalance()
        {
            Console.WriteLine($"Balance:{Balance}");
        }

        public void DisplayCheckingBalance()
        {
            Console.WriteLine(CheckingBalance);
        }

        public void DisplaySavingsBalance()
        {
            Console.WriteLine(SavingsBalance);
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

    }
}
