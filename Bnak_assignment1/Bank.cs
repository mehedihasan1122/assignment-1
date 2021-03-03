using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bnak_assignment1

{
    class Bank : Account
    {
        public string t;
        public double Amount { get; set; }
        public string BankName
        {
            get; set;
        }
        public Account[] myBank;

        public int i = 1;
        public void AddAccount(/*Account[] account*/)
        {
            Console.WriteLine("Enter Your account name: ");
            AccountName = Console.ReadLine();
            AccountNumber = Convert.ToString(i);
            i++;
            Console.WriteLine("Road No: ");
            Roadno = Console.ReadLine();
            Console.WriteLine("House No: ");
            Houseno = Console.ReadLine();
            Console.WriteLine("City: ");
            City = Console.ReadLine();
            Console.WriteLine("Country: ");
            Country = Console.ReadLine();
            
        }
        
        public void Transaction()
        {
            Console.WriteLine("Which Transaction do you want? \n");
            Console.WriteLine("1.Deposit\n2.Withdraw\n3.Transfer");
            t = Console.ReadLine();
            switch (t)
            {

                case "1":
                    Console.WriteLine("Enter the amount for deposit: ");
                    Amount = Convert.ToDouble(Console.ReadLine());
                    Deposit(Amount);
                    break;
                case "2":
                    Console.WriteLine("Enter the amount for Withdraw: ");
                    Amount = Convert.ToDouble(Console.ReadLine());
                    Withdraw(Amount);
                    break;
                case "3":
                    Console.WriteLine("You are transfering money.\nEnter Account name: ");
                    AccountName = Console.ReadLine();
                    Console.WriteLine("Enter Account number: ");
                    AccountNumber = Console.ReadLine();
                    Console.WriteLine("Enter the amount: ");
                    Amount = Convert.ToDouble(Console.ReadLine());
                    Transfer(AccountName, AccountName, Amount);
                    break;
                default:
                    Console.WriteLine("Wrong output: ");
                    break;
            }

        }
        public void PrintAccountDetails()
        {
            ShowAccountInformation();
        }
    }
}
