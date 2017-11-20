using Factory.RefBooks;

namespace Factory.Cars
{
    public class Tuareg : Car
    {
        public Tuareg()
        {
            Name = CarTypes.Tuareg;
            Body = BodyCarTypes.BigCrossover;
        }
    }
}
