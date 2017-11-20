using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Cars;
using Factory.RefBooks;

namespace Factory.Factory
{
    public class SimpleFactory
    {
        public Car GetCar(CarTypes type)
        {
            Car car = new Car();

            switch (type)
            {
                case CarTypes.Golf:
                    car = new Golf();
                    break;
                case CarTypes.Passat:
                    car = new Passat();
                    break;
                case CarTypes.Tiguan:
                    car = new Tiguan();
                    break;
                case CarTypes.Tuareg:
                    car = new Tuareg();
                    break;
                default: throw new Exception($"Типа {type} не существует");
            }


            car.Configure();
            car.AssembleBody();
            car.InstallEngine();
            car.Paint();
            car.InstallWheels();

            return car;
        }
    }
}
