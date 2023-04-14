using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a base class, Telephone, and derive a class ElectronicPhone from it. In Telephone,
//create a protected string member phonetype and a public method Ring( ) which
//outputs a text message such as this: “Ringing the <phonetype>.” In ElectronicPhone,
//the constructor should set the phonetype to “Digital.”
//In the Run( ) method, call Ring( ) on the ElectronicPhone to test the inheritance.

namespace InheritTeleBemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ElectronicPhone ep = new ElectronicPhone();
            ep.Run();
    }
    }
    class Telephone
    {
        protected string phonetype;

        public void Ring()
        {
            Console.WriteLine("Ringing the " +phonetype +".");
        }
        public Telephone()
        {

        }

    }
    class ElectronicPhone: Telephone 
    {
        public ElectronicPhone() 
        {
            phonetype = "Digital";
            
        }
        public void Run()
        {
            Ring();
        }
    
    }
}
