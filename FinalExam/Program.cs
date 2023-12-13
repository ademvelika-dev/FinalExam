
using FinalExam;
using System;
using System.ComponentModel.Design;


List<Customer> customers = new List<Customer>();
customers = JsonFileReader.ReadCustomers();

Console.WriteLine($"Number of customers: {customers.Count}");

foreach (var customer in customers)
{
    Console.WriteLine($"Account Number: {customer.accountNumber}, Saving Balance: {customer.savingBalance}, Checking Balance: {customer.checkingBalance}");
   
}


Console.WriteLine("Select Language: ");

string Language = Console.ReadLine();





if (Language == "AL")
{

    Console.WriteLine("Shkruani numrin e llogarise: ");

    Customer testCustomer=null;

    string accnr = Console.ReadLine();

    foreach (var customer in customers)
    {
        if (customer.accountNumber == accnr)
        {
            testCustomer = customer;
        }
    }

    if (testCustomer is Customer)
    {
        Console.WriteLine("Vendosni Pin: ");

        string pin;

        for (int i = 0; i < 3; i++)
        {
            pin = Console.ReadLine();
            if (pin != testCustomer.password)
            {
                Console.WriteLine("Provo Perseri!");
            }
            else
            {


               Console.WriteLine("A=Kontrollo, B=Terhiq, C=Dil: ");
               string typeAcc=Console.ReadLine();

                if (typeAcc == "A")
                {
                   
                            Console.WriteLine("Balanca: " + testCustomer.checkingBalance);
                     
                }
                else if (typeAcc == "B")
                {
                    
                            Console.WriteLine("Balanca: " + testCustomer.savingBalance);
                   
                }
                else
                {
                    Console.WriteLine("A=Kontrollo, B=Terhiq, C=Dil: ");
                    string typeAcc1 = Console.ReadLine();

                    if (typeAcc1 == "A")
                    {

                        Console.WriteLine("Balanca: " + testCustomer.checkingBalance);

                    }
                    else if (typeAcc1 == "B")
                    {

                        Console.WriteLine("Balanca: " + testCustomer.savingBalance);

                    }
                }


                Console.WriteLine("A=Depozito, B=Trhiq, C=Dorezohu");

                string typeAcc2 = Console.ReadLine();
                string amountt = Console.ReadLine();
                decimal amountDec;
                decimal.TryParse(amountt, out amountDec);

                if (typeAcc2 == "A")
                {
                    testCustomer.Deposit(amountDec, typeAcc2);

                   
                    Console.WriteLine(testCustomer.checkingBalance);
                }
                else if(typeAcc2 == "B")
                {
                    testCustomer.Withdraw(amountDec, typeAcc2);

                    Console.WriteLine(testCustomer.checkingBalance);
                }
                else
                {
                    Console.WriteLine("A=Depozito, B=Trhiq, C=Dorezohu");

                    string typeAcc3 = Console.ReadLine();
                    string amountt1 = Console.ReadLine();
                    decimal amountDec1;
                    decimal.TryParse(amountt1, out amountDec1);

                    if (typeAcc2 == "A")
                    {
                        testCustomer.Deposit(amountDec, typeAcc3);


                        Console.WriteLine(testCustomer.checkingBalance);
                    }
                    else if (typeAcc2 == "B")
                    {
                        testCustomer.Withdraw(amountDec, typeAcc3);

                        Console.WriteLine(testCustomer.checkingBalance);
                    }
                }

                }                
               
            }
        }
    }










else
{
    Console.WriteLine("Enter account number: ");

    Customer testCustomer = null;

    string accnr = Console.ReadLine();

    foreach (var customer in customers)
    {
        if (customer.accountNumber == accnr)
        {
            testCustomer = customer;
        }
    }

    if (testCustomer is Customer)
    {
        Console.WriteLine("Enter Pin: ");

        string pin;

        for (int i = 0; i < 3; i++)
        {
            pin = Console.ReadLine();
            if (pin != testCustomer.password)
            {
                Console.WriteLine("Try again!");
            }
            else
            {


                Console.WriteLine("A=Check, B=Withdraw, C=Cancel: ");
                string typeAcc = Console.ReadLine();

                if (typeAcc == "A")
                {

                    Console.WriteLine("Balance: " + testCustomer.checkingBalance);

                }
                else if (typeAcc == "B")
                {

                    Console.WriteLine("Balance: " + testCustomer.savingBalance);

                }
                else
                {
                    Console.WriteLine("A=Check, B=Withdraw, C=Cancel: ");
                    string typeAcc1 = Console.ReadLine();

                    if (typeAcc1 == "A")
                    {

                        Console.WriteLine("Balance: " + testCustomer.checkingBalance);

                    }
                    else if (typeAcc1 == "B")
                    {

                        Console.WriteLine("Balance: " + testCustomer.savingBalance);

                    }
                }


                Console.WriteLine("A=Deposit, B=Withdraw, C=Quit");

                string typeAcc2 = Console.ReadLine();
                string amountt = Console.ReadLine();
                decimal amountDec;
                decimal.TryParse(amountt, out amountDec);

                if (typeAcc2 == "A")
                {
                    testCustomer.Deposit(amountDec, typeAcc2);


                    Console.WriteLine(testCustomer.checkingBalance);
                }
                else if (typeAcc2 == "B")
                {
                    testCustomer.Withdraw(amountDec, typeAcc2);

                    Console.WriteLine(testCustomer.checkingBalance);
                }
                else
                {
                    Console.WriteLine("A=Deposit, B=Withdraw, C=Quit");

                    string typeAcc3 = Console.ReadLine();
                    string amountt1 = Console.ReadLine();
                    decimal amountDec1;
                    decimal.TryParse(amountt1, out amountDec1);

                    if (typeAcc2 == "A")
                    {
                        testCustomer.Deposit(amountDec, typeAcc3);


                        Console.WriteLine(testCustomer.checkingBalance);
                    }
                    else if (typeAcc2 == "B")
                    {
                        testCustomer.Withdraw(amountDec, typeAcc3);

                        Console.WriteLine(testCustomer.checkingBalance);
                    }
                }

            }

        }
    }
}
 



   
    
 



   

