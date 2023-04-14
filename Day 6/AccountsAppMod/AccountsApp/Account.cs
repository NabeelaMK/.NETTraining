using System;
namespace AccountsApp
{
    public class Account
    {
       public int Id;
        private string _name;
       public string Name
        {
            get
            { return _name; }
            set
            {
                if (value.Length > 15)
                    throw new ArgumentException("Name is tooo Big");
                _name = value;
            }
        }
       private decimal _balance;
        public decimal Balance
        {
            get { return _balance; }
        }
       public Account()
        {

        }
        public void CreateAccount(int id, string name, decimal balance)
        {
            Id = id;
            _name = name;
            _balance = balance;

        }

        public void DisplayAccInfo()
        {
            Console.WriteLine("****** Application Information ******");
            Console.WriteLine("Account Id: " + Id);
            Console.WriteLine("Name: " + _name);
            Console.WriteLine("Opening Balance: " + _balance);
        }

        public void Deposit(decimal amount)
        {
            _balance = _balance + amount;
            Console.WriteLine("{0} Deposited", amount);
        }

        public void Withdraw(decimal amount)
        {
            if(_balance - amount<100)
            {
                Console.WriteLine("Oops! Insufficient Balance");
            }
            else
            {
                _balance=_balance - amount;
                Console.WriteLine("{0} Withdrawn", amount);
            }
        }
    }
}