using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AAAA.Data;
using AAAA.Models;


namespace AAAA
{
    public class BankAccount : MainBankMethdes
    {

         
        //public BankAccount(string id, string firstname, string lastname, int pin, string phonenumber, string email, string city , double balance)
        //{
        //    this.Id = id;
        //    this.FirstName = firstname;
        //    this.LastName = lastname;
        //    this.Pin = pin;
        //    this.PhoneNumber = phonenumber;
        //    this.email = email;
        //    this.City = city;
        //    this.Balance = balance;

        //}
        public static void Withdraw(Account Account) {

            Console.Write("\nHow much are you willing to take : ");
            int Amount = int.Parse(Console.ReadLine());
            Account.Balance -= Amount;
            Console.WriteLine($"\nYou did a withdraw with {Amount} now your Balance goes from {Amount + Account.Balance} to {Account.Balance}\nThanks for using our service");
            Console.WriteLine("\nCurrent balance now is " + Account.Balance);


        }
        public static void Deposit(Account Account) {
            Console.WriteLine("Enter the cash amount to deposit:");
            int Amount = int.Parse(Console.ReadLine());
            Account.Balance += Amount;
            Console.WriteLine("Cash Deposited Successfully.");
            
        }
        public static void Transfer(Account Account) {

            Console.Write("\nHow much are you willing to transfer : ");
            int Amount = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter the account ID or PhoneNumber you want to send moeny : ");
            string AccountToTrancefer = Console.ReadLine();
            Account.Balance -= Amount;

            Console.WriteLine("Transaction confirmed.");
        }
        public static void DisplayBalance(Account Account) {

            Console.WriteLine($"\nHello Me.{Account.FirstName}");
            Console.WriteLine($"Balance: {Account.Balance}");
            Console.WriteLine($"\nDate: {DateTime.Now}");

        }
    }
}
