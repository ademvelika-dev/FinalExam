namespace FinalExam
{
    public class Customer
    {
        public string accountNumber { get; set; }
        public string password { get; set; }
        public int savingBalance { get; set; }
        public int checkingBalance { get; set; }
        //public Customer(string accountNumber, string password, int savingAccount, int checkingAccount)
        //{
        //    this.accountNumber = accountNumber;
        //    this.password = password;
        //    this.savingBalance = savingAccount;
        //    this.checkingBalance = checkingAccount;
        //}

        public bool LogIn(string name, string password)
        {
            if (accountNumber == name && this.password == password)
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        public void ShowAccountBalance(string accountType)
        {
            if (accountType == "a")
            {
                Console.WriteLine($"{savingBalance}");
            }
            else if (accountType == "b")
            {
                Console.WriteLine($"{checkingBalance}");
            }

        }
        public void PrintRecipt(int value)
        {
            Console.WriteLine($"{accountNumber} withdrawed {value}$");
        }
        public void WithDraw(string accountType, int value)
        {
            if (accountType == "a")
            {

                if (value > 400)
                {
                    Console.WriteLine("you cant withdraw more than 400$");
                }
                else if (value > savingBalance)
                {

                    Console.WriteLine("You can't withdraw this ammount in your saving account");

                }
                else if (value < 0)
                {

                }
                else if (0 <= value && value < 400)
                {
                    savingBalance -= value;
                    PrintRecipt(value);
                }
            }
            else
            {
                if (accountType == "b")
                {
                    if (value > 700)
                    {
                        Console.WriteLine("You cant withdraw more than 700 dollars");
                    }
                    else if (value > checkingBalance)
                    {
                        Console.WriteLine("you can't withdraw this ammount in your saving account");
                    }
                    else if (value < 0)
                    {
                        Console.WriteLine("You can't withdraw negative ammount");
                    }
                    else if (0 <= value && value < 700) ;
                    {
                        checkingBalance -= value;
                        PrintRecipt(value);
                    }

                }
            }

        }

    }
}
