using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public string make { get; set; }

        public string EngineType { get; set; }

        public string model { get; set; }

        public string Ignitiontype { get; set; }  
    }
}
