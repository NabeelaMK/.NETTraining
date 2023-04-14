using System;

namespace AccountsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ch;
            Account a = null;
            do {
                Console.WriteLine("\n\n#########################################");
                Console.WriteLine("####### Account Applications #######");
                Console.WriteLine("#########################################\n\n");
                Console.WriteLine("\n1. Create Account");
                Console.WriteLine("\n2. Display Account Info");
                Console.WriteLine("\n3. Deposit Account");
                Console.WriteLine("\n4. Withdraw Account");
                Console.WriteLine("\n5. Check Balance");
                Console.WriteLine("\n0. Quit");
                Console.WriteLine("\nEnter choice: ");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("\n\nCreate Accound Id: ");
                        int Id = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nEnter Name: ");
                        String Name = Console.ReadLine();
                        Console.WriteLine("\nEnter Opening Balance: ");
                        decimal Balance = decimal.Parse(Console.ReadLine());
                        a = new Account();
                        a.CreateAccount(Id, Name, Balance);
                        break;

                    case 2:
                        if (a != null)
                        {
                            a.DisplayAccInfo();
                        }
                        else
                        {
                            Console.WriteLine("\n\n****** Open Account First ******\n\n");
                        }
                        break;

                    case 3:
                        if (a != null)
                        {
                            a.Deposit(10000);
                        }
                        else
                        {
                            Console.WriteLine("\n\n****** Open Account First ******\n\n");
                        }
                        break;

                    case 4:
                        if (a != null)
                        {
                            a.Withdraw(10000);
                        }
                        else
                        {
                            Console.WriteLine("\n\n****** Open Account First ******\n\n");
                        }
                        break;
                    case 5:
                        if (a != null)
                        {
                            //Read
                            Console.WriteLine(a.Balance);

                            //Write
                            //a.Balance = 30000;
                        }
                        else
                        {
                            Console.WriteLine("\n\n****** Open Account First ******\n\n");
                        }
                        break;

                    case 0:
                        break;

                    default:
                        Console.WriteLine("\n\n****** Wrong Choice ******\n\n");
                        break;

                }
            }
            while (ch != 0);
            Console.WriteLine("\n\n****** Thanks For Using This Banking Operations ******\n\n");
           
        }
    }
}
