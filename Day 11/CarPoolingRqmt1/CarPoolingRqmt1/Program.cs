using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPoolingReq1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Member> list = new List<Member>();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Member {0}:", i + 1);
                Console.Write("Id: ");
                long id = long.Parse(Console.ReadLine());
                Console.Write("First Name: ");
                string firstName = Console.ReadLine();
                Console.Write("Last Name: ");
                string lastName = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Contact Number: ");
                string contactNumber = Console.ReadLine();
                Console.Write("License Number: ");
                string licenseNumber = Console.ReadLine();
                Console.Write("License Start Date (dd-MM-yyyy): ");
                DateTime licenseStartDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
                Console.Write("License Expiry Date (dd-MM-yyyy): ");
                DateTime licenseExpiryDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
                Member member1 = new Member(id, firstName, lastName, email, contactNumber, licenseNumber, licenseStartDate, licenseExpiryDate);
                list.Add(member1);
            }
            int j = 1;
            foreach (var item in list)
            {
                Console.WriteLine("Mail {0}: ", j);
                Console.WriteLine(item.ToString());
                j++;
            }
            if (list[0].Equals(list[1]))
            {
                Console.WriteLine("\nMember 1 is same as Member 2");
            }
            else
            {
                Console.WriteLine("\nMember 1 and Member 2 are different");
            }
            Console.ReadLine();
        }
    }
}



