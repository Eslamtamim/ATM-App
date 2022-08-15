using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AAAA.Data;
using AAAA.Models;
using AAAA;



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
        public static void Withdraw(Account a) {

            Console.Write("\nHow much are you willing to take : ");
            int Amount = int.Parse(Console.ReadLine());
            a.Balance -= Amount;
            Console.WriteLine($"\nYou did a withdraw with {Amount} now your Balance goes from {Amount + a.Balance} to {a.Balance}\nThanks for using our service");
            Console.WriteLine("\nCurrent balance now is " + a.Balance);


        }
        public static void Deposit(Account a) {
            Console.WriteLine("Enter the cash amount to deposit:");
            int Amount = int.Parse(Console.ReadLine());
            a.Balance += Amount;
            Console.WriteLine("Cash Deposited Successfully.");
            
        }
        public static void Transfer(Account a) {

            Console.Write("\nHow much are you willing to transfer : ");
            int Amount = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter the account ID or PhoneNumber you want to send moeny : ");
            string AccountToTrancefer = Console.ReadLine();
            
            //still in progress 
            
            a.Balance -= Amount;

            Console.WriteLine("Transaction confirmed.");
        }
        public static void DisplayBalance(Account a) {

            Console.WriteLine($"\nHello Me.{a.FirstName}");
            Console.WriteLine($"Balance: {a.Balance}");
            Console.WriteLine($"\nDate: {DateTime.Now}");

        }
    }
}
