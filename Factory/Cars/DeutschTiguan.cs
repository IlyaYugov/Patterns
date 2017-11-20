using Factory.RefBooks;

namespace Factory.Cars
{
    public class DeutschTiguan : Car
    {
        public DeutschTiguan()
        {
            Name = CarTypes.Tiguan;
            Body = BodyCarTypes.Crossover;
            Engine = EngineTypes.Diesel;
        }
    }
}
