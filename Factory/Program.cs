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
            SimpleFactory factory = new SimpleFactory();
            VolkswagenFacility facility = new VolkswagenFacility(factory);

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
