using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Truck : IVehicle, ICompany
    {
        public int BedSize { get; set; }
        public int HaulAmount { get; set; }

        public int NumWheels { get; set; }
        public int NumDoors { get; set; }
        public bool IsNew { get; set; }
        public bool IsElectric { get; set; }

        public string Name { get; set; }
        public string Logo { get; set; }
    }
}
