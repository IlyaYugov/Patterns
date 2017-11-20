using Factory.Cars;
using Factory.RefBooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Factory;

namespace Factory.Facilites
{
    public abstract class VolkswagenFacility
    {
        public Car GetCar(CarTypes type)
        {
            Car car = CreateCar(type);

            car.Configure();
            car.AssembleBody();
            car.InstallEngine();
            car.Paint();
            car.InstallWheels();

            return car;
        }

        public abstract Car CreateCar(CarTypes type);
    }
}
