using Factory.RefBooks;

namespace Factory.Cars
{
    public class DeutschGolf : Car
    {
        public DeutschGolf()
        {
            Name = CarTypes.Golf;
            Body = BodyCarTypes.Hatchback;
            Engine = EngineTypes.Diesel;
        }
    }
}
