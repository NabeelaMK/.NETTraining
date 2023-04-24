using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPoolingRqmt5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Enter the number of members:");
            num = int.Parse(Console.ReadLine());
            ArrayList al = new ArrayList();
            try
            {
                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine("Enter member {0} details:", i + 1);
                    string[] s = Console.ReadLine().Split(',');
                    int id = int.Parse(s[0]);
                    string firstname = s[1];
                    string lastname = s[2];
                    string email = s[3];
                    long phone = long.Parse(s[4]);
                    string licensenumber = s[5];
                    DateTime licensestartdate = DateTime.Parse(s[6]);
                    DateTime licenseexpirydate = DateTime.Parse(s[7]);
                    //Member m = new Member(long.Parse(s[0]), s[1], s[2], s[3], s[4], s[5], DateTime.ParseExact(s[6], "dd-MM-yyyy", null), DateTime.ParseExact(s[7], "dd-MM-yyyy", null));
                    Member m = new Member(id, firstname, lastname, email, phone, licensenumber, licensestartdate, licenseexpirydate);
                    al.Add(m);
                    if (!email.Contains("@") || (!email.EndsWith(".com") && !email.EndsWith(".org")))
                    {
                        throw new InvalidEmailException("InvalidEmailException: Invalid Email for " + firstname);
                    }
                }

            }
            catch (InvalidEmailException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();
            int j = 1;
            foreach (var item in al)
            {
                Console.WriteLine("Member {0}: ", j);
                Console.WriteLine(item.ToString());
                j++;
            }
        }
    }
}

