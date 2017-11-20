using Factory.RefBooks;

namespace Factory.Cars
{
    public class RussianTuareg : Car
    {
        public RussianTuareg()
        {
            Name = CarTypes.Tuareg;
            Body = BodyCarTypes.BigCrossover;
            Engine = EngineTypes.Gasoline;
        }
    }
}
