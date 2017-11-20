using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Cars;
using Factory.Factory;
using Factory.RefBooks;

namespace Factory.Facilites
{
    public class RussianVolkswagenFacility : VolkswagenFacility
    {
        public override Car CreateCar(CarTypes type)
        {
            Car car = new Car();

            switch (type)
            {
                case CarTypes.Golf:
                    car = new RussianGolf();
                    break;
                case CarTypes.Passat:
                    car = new RussianPassat();
                    break;
                case CarTypes.Tiguan:
                    car = new RussianTiguan();
                    break;
                case CarTypes.Tuareg:
                    car = new RussianTuareg();
                    break;
                default: throw new Exception($"Типа {type} не существует");
            }
            return car;
        }
    }
}
