using System;
using System.Security.Cryptography;

namespace BankApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Locker a = null;
            Bank b = null;
            do
            {
                Console.WriteLine("1. Add Locker");
                Console.WriteLine("2. Delete Locker");
                Console.WriteLine("3. Display Lockers");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter Choice: ");
                choice=int.Parse(Console.ReadLine());
                switch(choice) 
                {
                    case 1:
                        Console.WriteLine("Enter Number: ");
                        int _number=int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter LockType: ");
                        string _lockType=Console.ReadLine();
                        Console.WriteLine("Enter Passord: ");
                        string _password=Console.ReadLine();
                        Console.WriteLine("Enter Amount: ");
                        double _amount = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter LastOpen: ");
                        DateTime _lastOpened=DateTime.Parse(Console.ReadLine());
                        a = new Locker();
                        a.CreateLocker(_number, _lockType, _password, _amount, _lastOpened);
                        break;

                    case 2:
                        b= new Bank();
                        

                }

            }
    
          
        } 
    }     
}
