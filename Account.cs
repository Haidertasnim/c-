using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_1
{
	public class Account
	{
		private static int accountNumber = 101;
		private string accountName;
		private double balance;
		private Address address;

		public static int AccNumber()
		{
			return accountNumber++;
		}
		public int AccountNumber
		{
			get
			{
				return AccNumber();
			}
		}
		public Account(string accountName, double balance, Address address)
		{
			this.accountName = accountName;
			this.balance = balance;
			this.address = address;
		}

		public void Deposit(double amount)
		{
			if (amount > 0)
			{
				Console.WriteLine("\nPrevious Balance was: " + balance);
				Console.WriteLine(+amount + " $ Deposited...");

				balance = balance + amount;

				Console.WriteLine("Current Balance is: " + balance);
			}
			else
			{
				Console.WriteLine("\nCan Not Deposit...");
			}
		}
		public void Withdraw(double amount)
		{
			if (amount < 0)
			{
				Console.WriteLine("\nSorry, you can not withdraw a negative amount.");
			}
			else if (amount > balance)
			{
				Console.WriteLine("\nSorry, this withdrawal would exceed the balance");
			}
			else
			{
				this.balance = (this.balance - amount);
				Console.WriteLine("\n" + amount + " $ Withdrawn...");
				Console.WriteLine("\nAvailable Balance: " + balance);
			}
		}
		public void Transfer(double amount,Account receiver)
		{
			if(amount<0)
			{
				Console.WriteLine("\nSorry, you can not transfer a negative amount.");
			}
			else if(balance>=amount)
			{
				Withdraw(amount);
				receiver.Deposit(amount);
				Console.WriteLine("\n" + accountName + " has transfered " + amount + " taka to " + receiver.accountName + "'s account");
			}
			else
			{
				Console.WriteLine("\nInsufficient Balance");
			}
			Console.WriteLine("\n" +accountName + "'s current balance is " +balance);
			//Console.WriteLine(receiver.accountName + "'s current balance is " + receiver.balance);
		}

		public void ShowAccountInformation()
		{
			Console.WriteLine("\nAccount Holder Name: " + accountName);
			Console.WriteLine("Account Number: " + AccNumber());
			Console.WriteLine("Address: " + address.GetAddress());
			Console.WriteLine("Available Balance: " + balance);
		}
	}
}
