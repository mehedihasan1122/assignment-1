using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bnak_assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acod = new Account();
            Bank bobj = new Bank();
            acod.GetAddress("230", "nikunja", "dhaka", "BD");
            bobj.AccountName = "mehedi hasan";
            bobj.AccountNumber = "02";
            bobj.Balance = 500000d;
            bobj.Deposit(500);
            bobj.Withdraw(50);
            acod.ShowAccountInformation();

            bobj.BankName = "Shonali";
            bobj.PrintAccountDetails();
        }
    }
}
