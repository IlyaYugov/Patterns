using Factory.RefBooks;

namespace Factory.Cars
{
    public class Tiguan : Car
    {
        public Tiguan()
        {
            Name = CarTypes.Tiguan;
            Body = BodyCarTypes.Crossover;
        }
    }
}
