using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicles
    {
        public bool HasSideCar;

        public Motorcycle() { }
        public Motorcycle(bool hasSideCar) 
        {
            HasSideCar = hasSideCar;
        }

        public override void DriveAbstract()
        {
            Console.WriteLine("Salvador Dali on a motorcycle");
        }
        public override void DriveVirtual()
        {
            base.DriveVirtual();
        }
    }
}
