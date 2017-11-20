using Factory.RefBooks;

namespace Factory.Cars
{
    public class RussianGolf : Car
    {
        public RussianGolf()
        {
            Name = CarTypes.Golf;
            Body = BodyCarTypes.Hatchback;
            Engine = EngineTypes.Gasoline;
        }
    }
}
