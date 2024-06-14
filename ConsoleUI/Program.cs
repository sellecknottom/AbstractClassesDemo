using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties: Year, Make, and Model
             * Set the defaults of the properties to something generic in the Vehicle class
             * Vehicle class shall have an abstract method called DriveAbstract with no implementation.
             * Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            List<Vehicles> Vehicles = new List<Vehicles>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties values with object initializer syntax
             */
            Car car1 = new Car(true)
            {
                Year = 1967,
                Make = "Chevy",
                Model = "Mustang"
            };
            Motorcycle motorcycle1 = new Motorcycle(false)
            {
                Year = 1958,
                Make = "Royal Enfield",
                Model = "Indian"
            };
            Vehicles car2 = new Car()
            {
                Year = 2024,
                Make = "Buick",
                Model = "Enclave"
            };
            Vehicles motorcycle2 = new Motorcycle()
            {
                Year = 2024,
                Make = "Harley",
                Model = "CVO Road Glide"
            };
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */
            Vehicles.Add(car1);
            Vehicles.Add(car2);
            Vehicles.Add(motorcycle1);
            Vehicles.Add(motorcycle2);

            foreach (var vehicle in Vehicles.OfType<Car>()) 
            {
                Console.WriteLine(vehicle.Make);
                Console.WriteLine(vehicle.Model);
                Console.WriteLine(vehicle.Year);
                Console.WriteLine(vehicle.HasTrunk);
                Console.WriteLine();
                Console.WriteLine();
            }
            foreach (var vehicle in Vehicles.OfType<Motorcycle>())
            {
                Console.WriteLine(vehicle.Make);
                Console.WriteLine(vehicle.Model);
                Console.WriteLine(vehicle.Year);
                Console.WriteLine(vehicle.HasSideCar);
                Console.WriteLine();
                Console.WriteLine();
            }

            // Call each of the drive methods for one car and one motorcycle
            car1.DriveAbstract();
            motorcycle1.DriveVirtual();

            #endregion            
            Console.ReadLine();
        }
    }
}
