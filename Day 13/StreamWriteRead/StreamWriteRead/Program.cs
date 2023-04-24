using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StreamWriteRead
{
     class WriteAndRead
    {
        static string file = @"D:\.NET UST\Day 13\poem.txt";
        static void Main()
        {
            Write();
            Read();
        }
        static void Write()
        {
            StreamWriter filestream = new StreamWriter(file);
            filestream.WriteLine("What is the life if, full of care,");
            filestream.WriteLine("We have time to stand and stare.");
            filestream.Close();
        }
        static void Read() 
        {
            StreamReader filestream = new StreamReader(file);
            string s= null;
            while((s = filestream.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
            filestream.Close();
        }
    }
}