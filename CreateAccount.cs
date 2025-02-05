using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    internal class CreateAccount
    {
        public int AccountNumber { get; }
        public int IdNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float InitialBalance { get; set; }

        public CreateAccount(int accountNumber, int idNumber, string firstName, string lastName, float initialBalance)
        {
            AccountNumber = accountNumber;
            IdNumber = idNumber;
            FirstName = firstName;
            LastName = lastName;
            InitialBalance = initialBalance;
        }

        public double AccNumber() 
        {
            Random random = new Random();
            var account = random.Next(100000000,999999999);
            return account;
        }

        public double SecretPin()
        {
            Random SecretPin = new Random();
            var Pin = SecretPin.Next(1000, 1999);
            return Pin;
        }

        public void MoneyDeposits()
        {
            Console.WriteLine("Enter your Deposit amount :");
            float amount = float.Parse(Console.ReadLine());
            InitialBalance += amount;
            Console.WriteLine($"You succesfuly deposited {amount}. Your updated balance is {InitialBalance}");
        }
    }
}
