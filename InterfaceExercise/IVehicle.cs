namespace InterfaceExercise
{
    internal interface IVehicle
    {
        //In your IVehicle

        /* Create 4 members that Car, Truck, & SUV all have in common.
         * Example: All vehicles have a number of wheels... for now..
         */
        public int NumWheels { get; set; }
        public int NumDoors { get; set; }
        public bool IsNew { get; set; }
        public bool IsElectric  { get; set; }
    }
}