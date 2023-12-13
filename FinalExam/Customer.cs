using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    public class Customer
    {
        public string accountNumber { get; set; }
        public string password { get; set; }
        public decimal checkingBalance { get; set; }
        public decimal savingBalance { get; set; }
      
       
       

        public Customer(string accountNumber, string password, decimal checkingBalance, decimal savingBalance)
        {
            this.accountNumber = accountNumber;
            this.password = password;
            this.checkingBalance = checkingBalance;
            this.savingBalance = savingBalance;
         
        }


       
           

            
      

        public void Deposit(decimal amount,string type)
        {

            try
            {
                if(type=="A")
                {
                    if (amount < 0)
                    {
                        throw new InvalidInput("Negative amount are not allowed");

                    }
                    else
                    {
                        checkingBalance += amount;
                    }
                }
                else if(type=="B")
                {
                    if (amount < 0)
                    {
                        throw new InvalidInput("Negative amount are not allowed");

                    }
                    else
                    {
                        savingBalance += amount;
                    }
                }
               
            }
            catch (Exception ex)
            {
                throw new InvalidInput(ex.Message);
            }


        }


        public decimal Withdraw(decimal amount, string type)
        {
            if (amount < 0)
            {
                throw new InvalidInput("Negative amounts are not allowed");
            }

           
                if (type == "A")
                {
                    if (amount > checkingBalance)
                    {
                        throw new InvalidInput("Not allowed!");
                    }
                    else
                    {
                        checkingBalance -= amount;
                        return checkingBalance;
                    }
                }
                else if (type == "B")
                {
                    if (amount > savingBalance)
                    {
                        throw new InvalidInput("Not allowed!");
                    }
                    else
                    {
                        savingBalance -= amount;
                        return savingBalance;
                    }
                }
                else
                {
                    throw new InvalidInput("Invalid account type");
                }
        
        }


        static List<int> ATMWithdraw(int amount)
        {
            List<int> dollars = new List<int>();

            dollars.Add(amount / 100);  
            amount %= 100;

            dollars.Add(amount / 50);   
            amount %= 50;

            dollars.Add(amount / 20);   
            amount %= 20;

            dollars.Add(amount / 10);   

            return dollars;
        }





    }
}
