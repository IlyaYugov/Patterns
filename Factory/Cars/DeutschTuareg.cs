using Factory.RefBooks;

namespace Factory.Cars
{
    public class DeutschTuareg : Car
    {
        public DeutschTuareg()
        {
            Name = CarTypes.Tuareg;
            Body = BodyCarTypes.BigCrossover;
            Engine = EngineTypes.Diesel;
        }
    }
}
