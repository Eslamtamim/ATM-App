using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            
            //idk why its not working yet
            //var login = from Account in context.Accounts
            //            where Account.Pin == PIN && Account.Id == ID
            //            select Account;
            ///////////////////////////////////////////////////////////////////////////////
            //foreach (var Account in Accounts)
            //{
            //    if (Account.Id == ID && Account.Pin == PIN)
            //    {
            //        AccMethods(Account);
            //        CurrentAcc = Account;
            //        break;
            //    }
            //}


            Console.WriteLine("ID : ");
            String ID = Console.ReadLine();

            Console.Write("PIN : ");
            int PIN = int.Parse(Console.ReadLine());


            var login = context.Accounts.Where(a => a.Id == ID && a.Pin == PIN).FirstOrDefault();
           

            if (login != null)
            {
                AccMethods(login);
                break;
            }
            else { Console.WriteLine("your Id or Pin is incorrect Please try again"); }
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


    int menu =0;
    while (menu <= 5)
    {
        Console.WriteLine("\n1----Withdraw Cash");
        Console.WriteLine("2----Deposit Cash");
        Console.WriteLine("3----Cash Transfer");
        Console.WriteLine("4----Display Balance");
        Console.WriteLine("5----Exit\n");
        Console.Write("Please select one of the above options: ");
        menu = int.Parse(Console.ReadLine());

        if (menu == 1)
        {
            BankAccount.Withdraw(account);
            
        }
        else if (menu == 2)
        {
            BankAccount.Deposit(account);
            
        }
        else if (menu == 3)
        {
            while (true)
            {
                Console.WriteLine("please enter the Account id, PhoneNumber or email you want to trancfer to");
                string AccountToTrancefer = Console.ReadLine();
                var trancferacc = context.Accounts.Where(a => a.Id == AccountToTrancefer || a.Id == AccountToTrancefer || a.Id == AccountToTrancefer).FirstOrDefault();
                if (trancferacc != null)
                {
                    BankAccount.Transfer(account, trancferacc);
                    break;
                }
                else
                {
                    Console.WriteLine("There is no Account with this info please try again");
                }

            }
           
            
        }
        else if (menu == 4)
        {
            BankAccount.DisplayBalance(account);
            
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