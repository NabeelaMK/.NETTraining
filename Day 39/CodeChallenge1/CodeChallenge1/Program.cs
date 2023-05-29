/*Code Challenge1

FEE COLLECTION

Write a program to determine the fee amount to be collected from a student. The input to the program is the type of the student, tuition fee, bus fee, hostel fee.

Refer the table below for fee details.

Student Type										Student Type denoted as									Fee Details

Merit Seat Day Scholar						MSDS																	Tuition fee + Bus fee

Merit Seat Hosteller							MSH																	Tuition fee + Hostel fee

Management Seat Day Scholar			MGSDS																150% of Tuition fee + Bus fee

Management 	150% of Tuition fee + Hostel fee
Input and Output Format:
Input consists of a string (student type), tuition fee(float), bus fee(float) and hostel fee(float). 
All floating-point numbers are displayed correct to 2 decimal places.
Refer sample input and output for formatting specifications.
All text in bold corresponds to input and the rest corresponds to output.
Sample Input and Output:
Enter the student type
MSH
Enter tuition fee
40000
Enter bus fee
12000
Enter hostel fee
50000
The fees to be paid by the student is Rs.90000*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CodeChallenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.MSDS ");
            Console.WriteLine("2.MSH: ");
            Console.WriteLine("3.MGSDS: ");
            Console.WriteLine("4.MGSH: ");
            Console.WriteLine("Enter choice:");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter tution fee: ");
            float tutfee= float.Parse(Console.ReadLine());
            Console.WriteLine("Enter bus fee: ");
            float busfee = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter hostel fee: ");
            float hostelfee = float.Parse(Console.ReadLine());
            float totfee = 0;

            switch(choice)
            {
                case 1:
                    if (choice == 1)
                    {
                        totfee=tutfee+busfee;             
                    }
                    break;

                case 2:
                    if (choice == 2)
                    {
                        totfee = tutfee + hostelfee;                       
                    }
                    break;

                case 3:
                    if (choice == 3)
                    {
                        totfee = (1.5f * tutfee) + busfee;                      
                    }
                    break;

                case 4:
                    if (choice == 3)
                    {
                        totfee = (1.5f * tutfee) + hostelfee;                       
                    }
                    break;

                default:
                    Console.WriteLine("InValid choice");
                    break;
            }

            Console.WriteLine(totfee);





        }
    }
}
