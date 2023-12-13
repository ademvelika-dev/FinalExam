using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    internal class Atm
    {
        public List<Customer> Customers { get; set; }
        public List<Account> Accounts { get; set; }

        public char AtmLanguage { get; set; }


        public void SelectLanguage(char language)
        {
            
           
            
                AtmLanguage = language;

            

        }

        public Account AuthenticateAccount(string accountNumber, string pin)
        {
            try
            {
                
                Account account = Accounts.Find(acc => acc.AccountNumber == accountNumber && acc.AccountPin == pin);
                account.IsLogged = true;
                

                if (account == null)
                {
                    throw new Exception("Authentication failed. Invalid account number or password.");
                }


                return account;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Authentication Error: {ex.Message}");
                return null;
            }
            
        }

        public void GetAccount(Account account,string input)
        {

            
            if (input.Equals("A"))
            {
                account.DisplayCheckingBalance();

            }
            else if(input.Equals("B"))
            {
                account.DisplaySavingsBalance();    
            }
            else if (input.Equals("C"))
            {
                GetAccount(account, input);
            }
            

        }

       public void Deposit(double amount)
        {
        

        }
        








    }
}
