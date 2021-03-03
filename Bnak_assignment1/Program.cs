using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bnak_assignment1
{
    class Program
    {

        public string BankName
        { 
            get;set;
        }
        static void Main(string[] args)
        {
            //Account acod = new Account();
            Bank bobj = new Bank();
            Console.WriteLine("enter bank name: ");
            bobj.BankName = Console.ReadLine();

            Console.WriteLine("Do you want to creat account or you have account:\n 1.creat   2.Have account");
            int d1 = Convert.ToInt32(Console.ReadLine());
            if (d1 == 1)
            {
                bobj.AddAccount();
            }
            else
            {
                Console.WriteLine("You have loged in ");

            }
            bobj.Transaction();
            bobj.PrintAccountDetails();
            Console.ReadLine();


            //acod.GetAddress("230", "nikunja", "dhaka", "BD");
           // bobj.AccountName = "mehedi hasan";
           // bobj.AccountNumber = "02";
            //bobj.Balance = 500000d;
           // bobj.Deposit(500);
           //bobj.Withdraw(50);
            //acod.ShowAccountInformation();
            //bobj.BankName = "Agrani";
           // bobj.PrintAccountDetails();
        }
    }
}
