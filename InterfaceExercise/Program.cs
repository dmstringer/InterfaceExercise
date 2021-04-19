using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            Car myCar = new Car() { IsElectric = true, IsNew = true, Logo = "something", Name = "something else", NumDoors = 4, NumWheels = 4, NumberItSeats = 4, TrunkSize = 2 };

            Truck myTruck = new Truck() { IsElectric = true, IsNew = true, Logo = "something", Name = "something else", NumDoors = 4, NumWheels = 4, BedSize = 6, HaulAmount = 2000 };

            SUV mySUV = new SUV() { IsElectric = true, IsNew = true, Logo = "something", Name = "something else", NumDoors = 4, NumWheels = 4, CargoSize = 3, SeatsFold = true };
        }
    }
}
