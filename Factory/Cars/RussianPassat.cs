using Factory.RefBooks;

namespace Factory.Cars
{
    public class RussianPassat: Car
    {
        public RussianPassat()
        {
            Name = CarTypes.Passat;
            Body = BodyCarTypes.Sedan;
            Engine = EngineTypes.Gasoline;
        }
    }
}
