using AAAA.Data;
using AAAA.Models;
using AAAA;
using ATMdbContext context = new ATMdbContext();
var Accounts = context.Accounts;
var account = new Account();

Console.WriteLine("Hi and welcome to our banking system\ndo you have an account or would you like to create one?");
Console.WriteLine("1- I want to log in\n2- I want to make an account");
int MainMenu = int.Parse(Console.ReadLine());



while (true) {

    if (MainMenu == 1)
    {
        while (true)
        {
            Console.WriteLine("ID : ");
            String ID = Console.ReadLine();

            Console.Write("PIN : ");
            int PIN = int.Parse(Console.ReadLine());
            foreach (var Account in Accounts)
            {
                if (Account.Id == ID && Account.Pin == PIN)
                {
                    AccMethods(Account);
                    break;
                }
              
                
            }break;
        }
        break;
    }
    else if (MainMenu == 2)
    {
        
        Console.WriteLine("Thanks for choosing us\n please provide us with your info");
        
        Console.WriteLine("ID : ");
        String ID = Console.ReadLine();
        
        
        Console.Write("FristName : ");
        String FristName = Console.ReadLine();

        Console.Write("LastName : ");
        String LastName = Console.ReadLine();

        Console.Write("PIN : ");
        int PIN = int.Parse(Console.ReadLine());

        Console.WriteLine("PhoneNumber : ");
        String PhoneNum = Console.ReadLine();

        Console.WriteLine("E-mail : ");
        String Email = Console.ReadLine();

        Console.WriteLine("City : ");
        String City = Console.ReadLine();

        Console.Write("Your start salary : ");
        int balance = int.Parse(Console.ReadLine());
        account = new Account() {
            Id = ID,
            FirstName = FristName,
            LastName = LastName,
            Pin = PIN,
            PhoneNumber= PhoneNum,
            Email = Email,
            City = City ,
            Balance = balance
        };
        context.Accounts.Add(account);
        context.SaveChanges();
        AccMethods(account);
        break;
    }
    else { Console.WriteLine("try again");  MainMenu = int.Parse(Console.ReadLine()); }
}


void AccMethods(Account account)
{
    Console.WriteLine("\n1----Withdraw Cash");
    Console.WriteLine("2----Deposit Cash");
    Console.WriteLine("3----Cash Transfer");
    Console.WriteLine("4----Display Balance");
    Console.WriteLine("5----Exit\n");
    Console.Write("Please select one of the above options: ");

    int menu = int.Parse(Console.ReadLine());

    while (menu <= 5)
    {
        if (menu == 1)
        {
            BankAccount.Withdraw(account);
            menu = int.Parse(Console.ReadLine());
        }
        else if (menu == 2)
        {
            BankAccount.Deposit(account);
            menu = int.Parse(Console.ReadLine());
        }
        else if (menu == 3)
        {
            BankAccount.Transfer(account);
            menu = int.Parse(Console.ReadLine());
        }
        else if (menu == 4)
        {
            BankAccount.DisplayBalance(account);
            menu = int.Parse(Console.ReadLine());
        }
        else if (menu == 5)
        {
            exit();
            break;
        }
        else { Console.WriteLine("plz try again"); menu = int.Parse(Console.ReadLine());}
    }


}
void exit()
{
    Console.WriteLine("bye");
}
context.SaveChanges();