using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailFolderApp
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            Console.WriteLine("Enter the name of the folder: ");
            string folderName=Console.ReadLine();
            MailFolder folder = new MailFolder(folderName);
            int ch;
            do
            {
                Console.WriteLine("\n1. Add Mail");
                Console.WriteLine("\n2. Delete Mail");
                Console.WriteLine("\n3. Display Mails");
                Console.WriteLine("\n4. Exit");
                Console.WriteLine("\nEnter choice: ");
                ch = int.Parse(Console.ReadLine());
                switch(ch)
                {
                    case 1:
                        Console.WriteLine("\nEnter the details of mail in CSV format: ");
                        string[] s = Console.ReadLine().Split(',');
                        long _id = long.Parse(s[0]);
                        string _from = s[1];
                        string _to = s[2];
                        string _subject = s[3];
                        string _content = s[4];
                        DateTime _receivedDate = DateTime.Parse(s[5]);
                        double _size = double.Parse(s[6]);
                        Mail mail = new Mail(_id, _from, _to, _subject, _content, _receivedDate, _size);
                        folder.AddMailToFolder(mail);
                        break;

                    case 2:
                        Console.WriteLine("\nEnter the id of the mail to be deleted");
                        long mailId=long.Parse(Console.ReadLine());
                        folder.RemoveMailFromFolder(mailId);
                        break;

                    case 3:
                        folder.DisplayMails();
                        break;
                        
                    case 4:
                        break;

                    default:
                        Console.WriteLine("\nInvalid choice");
                        break;
                }
            }
            while (ch != 0);
            Console.WriteLine("*****Thank You:)*****");
        }
    }
}
