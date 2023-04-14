using System;

namespace BankApp
{
    public class Locker
    {
        private int _number;
        private string _lockType;
        private string _password;
        private double _amount;
        private DateTime _lastOpend;

        public Locker() 
        {
        
        }

        public void CreateLocker(int number, string lockType, string password, double amount, DateTime lastOpened)
        {
            _number = number;
            _lockType = lockType;
            _password = password;
            _amount = amount;
            _lastOpend = lastOpened;
        }
    }
}