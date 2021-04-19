using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Car : IVehicle, ICompany
    {
        public int TrunkSize { get; set; }
        public int NumberItSeats { get; set; }

        public int NumWheels { get; set; }
        public int NumDoors { get; set; }
        public bool IsNew { get; set; }
        public bool IsElectric { get; set; }

        public string Name { get; set; }
        public string Logo { get; set; }
    }
}
