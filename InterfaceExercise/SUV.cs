using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class SUV : ICompany, IVehicle
    {

        public bool IsCrossOver { get; set; }

        public bool FourWheelDrive { get; set; }



        //IVehicle inheritance
        public string make { get; set; }
        public string EngineType { get; set; }
        public string model { get; set; }
        public string Ignitiontype { get; set; }


        //IComapny inheritance
        public string Country { get; set; }
        public string Logo { get; set; }
    }
}
