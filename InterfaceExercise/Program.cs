using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            List<IVehicle> Cars = new List<IVehicle>(){};



            var Subaru = new Car()
            {
                make = "Subaru",
                model = "Impreza",
                EngineType = "V6",
                Ignitiontype = "Push to start",
                Country = "Japan",
                Logo = "Stars",
                TrunkSize = "Six Feet",
                TopType = "HardTop"
            };
            Cars.Add(Subaru);

            var Honda = new SUV()
            {
                make = "Honda",
                model = "CRV",
                EngineType = "V4",
                Ignitiontype = "Keyless",
                Country = "Japan",
                Logo = "Big H",
                IsCrossOver = true,
                FourWheelDrive = true
            };
            Cars.Add(Honda);

            var Dodge = new Truck()
            {
                make = "Dodge",
                model = "Ram",
                EngineType = "Diesel",
                Ignitiontype = "Key",
                Country = "USA",
                Logo = "Sylized Ram",
                Gastype = "Diesel",
                CrewCab = true
            };
            Cars.Add(Dodge);

            Console.WriteLine("The vehicles I have listed are:");
            foreach(var Car in Cars)
            {
                Console.WriteLine($"The make is: {Car.make}. The Model is: {Car.model} and the engine type is a {Car.EngineType} engine. " +
                                  $"It uses {Car.Ignitiontype} to start.");               
            }
                             //Subaru Info
            Console.WriteLine("Additional info for the Impreza: ");
            Console.WriteLine($"Country of Origin: {Subaru.Country}." +
                              $" Logo: {Subaru.Logo}." +
                              $" Trunk size: {Subaru.TrunkSize}." +
                              $" Top type:{Subaru.TopType}");


                             //Dodge Info
            Console.WriteLine("Additional info for the Ram: ");
            Console.WriteLine($"Country of Origin: {Dodge.Country}." +
                              $" Logo: {Dodge.Logo}." +
                              $" Gas type: {Dodge.Gastype}." +
                              $" Crew Cab option: {Dodge.CrewCab}");
           
            
            
                              //Honda Info
            Console.WriteLine("Additional info for the CRV: ");
            Console.WriteLine($"Country of Origin: {Honda.Country}." +
                              $" Logo: {Honda.Logo}." +
                              $" Cross over option: {Honda.IsCrossOver}." +
                              $" Four Wheel drive Option: {Honda.FourWheelDrive}.");


        }
    }
}
