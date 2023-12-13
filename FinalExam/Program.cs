
using FinalExam;

//Console.WriteLine(JsonFileReader.ReadCustomers());

Atm atm = new Atm();

Console.WriteLine("Select Language: ");
Console.WriteLine("Please enter a Value A or B\n A=Alb, B=Eng");
char language = Console.ReadKey().KeyChar;
Customer customer = new Customer(1, "Kevin", "1234");
Account account = new Account("1",50,"1234");



atm.SelectLanguage(language);

if( language.Equals("A"))
{
    Console.WriteLine("Vendosni Emrin e Account:");
}
else
{
    Console.WriteLine("Enter Account Number");
}

var accountNumber= Convert.ToString(Console.ReadLine());

if (language.Equals( "A"))
{
    Console.WriteLine("Vendosni Passwordin");
}
else
{
    Console.WriteLine("Enter Password");
}

var pin = Convert.ToString(Console.ReadLine());

atm.AuthenticateAccount(accountNumber, pin);

Console.WriteLine("A=Checking, B=Savings, C=Quit");
string input = Convert.ToString(Console.ReadLine());

atm.GetAccount(account, input);

Console.WriteLine("A=Deposit, B=Withdrawal, C=Cancel");



