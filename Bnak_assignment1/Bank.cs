using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bnak_assignment1

{
    class Bank : Account
    {
        public string BankName
        {
            get; set;
        }
        public Account[] myBank;
        public void AddAccount(Account[] account)
        {

        }
        public void DeleteAccount(int accountNumber)
        {

        }
        public void Transaction()
        {

        }
        public void PrintAccountDetails()
        {
            ShowAccountInformation();
            Console.WriteLine("Bank Name: " + BankName);
        }
    }
}
