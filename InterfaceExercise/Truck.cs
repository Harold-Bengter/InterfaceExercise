using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {

        public string Gastype { get; set; }

        public bool CrewCab { get; set; }



        //IComopany Inheritance 
        public string Country { get; set; }
        public string Logo { get; set; }


        //Ivehicle Inheritance
        public string make { get; set; }
        public string EngineType { get; set; }
        public string model { get; set; }
        public string Ignitiontype { get; set; }
    }
}
