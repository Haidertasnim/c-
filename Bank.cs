using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_1
{
    public class Bank
    {
        private string bankName;
        public static Account[] myBank;

        public Bank(string bankName,int count)
        {
            this.bankName = bankName;
            myBank = new Account[count];
        }
        public void AddAccount(Account account)
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    myBank[i] = account;
                    break;
                }
            }
        }
        public void DeleteAccount(int accountNumber)
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i].AccountNumber == accountNumber)
                {
                    myBank[i] = null;
                    break;
                }
            }
        }
        public void PrintAccountDetails()
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    break;
                }
                Console.WriteLine("Bank Name: "+bankName);
                myBank[i].ShowAccountInformation();
            }
        }
        public static void Transaction(int a, int b = 0)
        {

        }
    }
}
