using Factory.Facilites;
using System;
using Factory.Factory;
using Factory.RefBooks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {

            VolkswagenFacility facility = new RussianVolkswagenFacility();

            facility.GetCar(CarTypes.Golf);
            Console.WriteLine();
            facility.GetCar(CarTypes.Passat);
            Console.WriteLine();
            facility.GetCar(CarTypes.Tiguan);
            Console.WriteLine();
            facility.GetCar(CarTypes.Tuareg);

            Console.ReadKey();
        }
    }
}
