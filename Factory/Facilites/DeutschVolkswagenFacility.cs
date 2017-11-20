using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Cars;
using Factory.RefBooks;

namespace Factory.Facilites
{
    public class DeutschVolkswagenFacility : VolkswagenFacility
    {
        public override Car CreateCar(CarTypes type)
        {
            Car car = new Car();

            switch (type)
            {
                case CarTypes.Golf:
                    car = new DeutschGolf();
                    break;
                case CarTypes.Passat:
                    car = new DeutschPassat();
                    break;
                case CarTypes.Tiguan:
                    car = new DeutschTiguan();
                    break;
                case CarTypes.Tuareg:
                    car = new DeutschTuareg();
                    break;
                default: throw new Exception($"Типа {type} не существует");
            }
            return car;
        }
    }
}
