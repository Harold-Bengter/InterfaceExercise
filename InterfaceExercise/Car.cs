using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public string TrunkSize { get; set; }

        public string TopType { get; set; }

        //Ivehicle Inheritance
        public string make { get; set; }
        public string EngineType { get; set; }
        public string model { get; set; }
        public string Ignitiontype { get; set; }

        //ICompany Inheritance
        public string Country { get; set; }
        public string Logo { get; set; }
    }
}
