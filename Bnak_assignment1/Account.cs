using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bnak_assignment1
{
    class Account : Address
    {
        private string accountNumber;
        private string accountName;
        private double balance;
        private Address address;

        public string AccountNumber
        { get; set; }
        public string AccountName
        { get; set; }
        public double Balance
        { get; set; }
        public void Withdraw(double amount)
        {
            if (balance <= 0)
            {
                Console.WriteLine("Insufficient balance \n Cant not withdraw this money");
            }
            else
            {
                balance = balance - amount;
                Console.WriteLine("Withdraw successful \n your corrent balance is: " + balance);
            }
        }
        public void Deposit(double amount)
        {
            balance = balance + amount;
            Console.WriteLine("Deposit successful \n your corrent balance is: " + balance);
        }
        public void Transfer(string Acnum, string Acname, double amount)
        {
            if (accountName == Acname && accountNumber == Acnum)
            {
                if (balance <= 0)
                {
                    Console.WriteLine("Insufficient balance \n Cant not Transfer this money");
                }
                else
                {
                    balance = balance - amount;
                    Console.WriteLine("Transfer successful \n your corrent balance is: " + balance);
                }
            }
        }
        public void ShowAccountInformation()
        {
            Console.WriteLine("Account Name: " + AccountName + "\nAccount Number: " + AccountNumber + "\nBalance: " + Balance);
            ShowAddress();
        }

    }
}
