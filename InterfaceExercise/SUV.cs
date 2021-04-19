using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class SUV : IVehicle, ICompany
    {
        public int CargoSize { get; set; }
        public bool SeatsFold { get; set; }

        public int NumWheels { get; set; }
        public int NumDoors { get; set; }
        public bool IsNew { get; set; }
        public bool IsElectric { get; set; }

        public string Name { get; set; }
        public string Logo { get; set; }
    }

}
