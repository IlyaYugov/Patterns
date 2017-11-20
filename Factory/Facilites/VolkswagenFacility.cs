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
    public class VolkswagenFacility
    {
        private SimpleFactory _factory;

        public VolkswagenFacility(SimpleFactory factory)
        {
            _factory = factory;
        }

        public Car GetCar(CarTypes type)
        {
            Car car = _factory.GetCar(type);

            car.Configure();
            car.AssembleBody();
            car.InstallEngine();
            car.Paint();
            car.InstallWheels();

            return car;
        }
    }
}
