using Factory.RefBooks;

namespace Factory.Cars
{
    public class DeutschPassat: Car
    {
        public DeutschPassat()
        {
            Name = CarTypes.Passat;
            Body = BodyCarTypes.Sedan;
            Engine = EngineTypes.Diesel;
        }
    }
}
