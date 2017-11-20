using Factory.RefBooks;

namespace Factory.Cars
{
    public class RussianTiguan : Car
    {
        public RussianTiguan()
        {
            Name = CarTypes.Tiguan;
            Body = BodyCarTypes.Crossover;
            Engine = EngineTypes.Gasoline;
        }
    }
}
