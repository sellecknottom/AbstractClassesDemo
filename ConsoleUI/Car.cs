using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Car : Vehicles
    {
        public bool HasTrunk;
        public Car() { }

        public Car(bool hastrunk)
        {
            HasTrunk = hastrunk;
        }

        public override void DriveAbstract()
        {
            Console.WriteLine("Picasso is ");
        }
    }
}
