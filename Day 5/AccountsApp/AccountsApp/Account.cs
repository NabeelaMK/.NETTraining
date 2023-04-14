using System;
namespace AccountsApp
{
    public class Account
    {
       public int Id;
       public string Name;
       public decimal Balance;
       public Account()
        {

        }
        public void CreateAccount(int id, string name, decimal balance)
        {
            Id = id;
            Name = name;
            Balance = balance;

        }

        public void DisplayAccInfo()
        {
            Console.WriteLine("****** Application Information ******");
            Console.WriteLine("Account Id: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Opening Balance: " + Balance);
        }

        public void Deposit(decimal amount)
        {
            Balance = Balance + amount;
            Console.WriteLine("{0} Deposited", amount);
        }

        public void Withdraw(decimal amount)
        {
            if(Balance - amount<100)
            {
                Console.WriteLine("Oops! Insufficient Balance");
            }
            else
            {
                Balance=Balance - amount;
                Console.WriteLine("{0} Withdrawn", amount);
            }
        }
    }
}