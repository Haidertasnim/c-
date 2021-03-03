using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bank b = new Bank("Janata Bank", 3);

            Address ad = new Address("32", "112", "Dhaka", "Bangladesh");
            Address ad1 = new Address("48", "109", "Khulna", "Bangladesh");

            Account[] a = new Account[3];

            a[0] = new Account("Tasnim", 5000, ad);
            b.AddAccount(a[0]);

            a[0].Deposit(1000);
            a[0].Withdraw(500);

            a[1] = new Account("Natasha", 5000, ad1);
            b.AddAccount(a[1]);

            a[1].Deposit(2000);
            a[1].Withdraw(1000);
            a[0].Transfer(500,a[1]);

            b.PrintAccountDetails();

            //b.DeleteAccount(102);
        }
    }
}
