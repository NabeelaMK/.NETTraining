using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CarPoolingReq4
{
    public class Hatchback : Car
    {
        public bool PowerWindows { get; set; }
        public bool AutomaticGear { get; set; }
        // Constructor
        public Hatchback(long id, string name, bool powerWindows, bool automaticGear)
        {
            Id = id;
            Name = name;
            PowerWindows = powerWindows;
            AutomaticGear = automaticGear;
        }
        // Implementing abstract method from Car class
        public override double CalculateDriveCost(double km)
        {
            double cost = 0;
            if (AutomaticGear)
                cost = 12;
            else
                cost = 10;
            return cost * km;
        }
    }
}
