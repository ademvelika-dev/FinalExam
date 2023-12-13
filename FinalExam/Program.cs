using FinalExam;

internal class Program
{

    static void AlgorithmForWithDrawMoney(int value, out int dollars100, out int dollars50, out int dollars20, out int dollars10)
    {
        dollars100 = 0;
        dollars50 = 0;
        dollars20 = 0;
        dollars10 = 0;

        dollars100 = value / 100;
        int remainingAmount = value % 100;

        dollars50 = remainingAmount / 50;
        remainingAmount %= 50;

        dollars20 = remainingAmount / 20;
        remainingAmount %= 20;

        dollars10 = remainingAmount / 10;

    }


    private static void Main(string[] args)
    {



        int value = 530;
        int dollars100, dollars50, dollars20, dollars10;
        AlgorithmForWithDrawMoney(value, out dollars100, out dollars50, out dollars20, out dollars10);
        Console.WriteLine($"Number of $100 : {dollars100}");
        Console.WriteLine($"Number of $50 : {dollars50}");
        Console.WriteLine($"Number of $20 : {dollars20}");
        Console.WriteLine($"Number of $10 : {dollars10}");

        var customers = JsonFileReader.ReadCustomers();

        Console.WriteLine($"Number of customers: {customers.Count}");

        foreach (var customer in customers)
        {
            Console.WriteLine($"Account Number: {customer.accountNumber}, Saving Balance: {customer.savingBalance}, Checking Balance: {customer.checkingBalance}");

        }


        Console.WriteLine("Select Language: ");

        string Language = Console.ReadLine();


        if (Language.ToLower() == "al")
        {

            Console.WriteLine("Shkruani numrin e llogarise: ");

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
                        Console.WriteLine("Zgjidh Tipin e Account: ");
                        Console.WriteLine("A: Checking, B:Saving ");
                        var test = Console.ReadLine();
                        if (test == "a")
                        {
                            testCustomer.ShowAccountBalance("a");


                        }
                        else if (test.ToLower() == "b")
                        {
                            testCustomer.ShowAccountBalance("b");

                        }

                    }
                }
            }
        }
        else
        if (Language.ToLower() == "en")
        {

            Console.WriteLine("Enter Account number: ");

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
                        Console.WriteLine("Enter account type: ");
                        Console.WriteLine("A: Checking, B:Saving ");
                        var test = Console.ReadLine();
                        if (test == "a")
                        {
                            testCustomer.ShowAccountBalance("a");


                        }
                        else if (test.ToLower() == "b")
                        {
                            testCustomer.ShowAccountBalance("b");

                        }

                    }
                }
            }
        }

    }
}