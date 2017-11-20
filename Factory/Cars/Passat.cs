using Factory.RefBooks;

namespace Factory.Cars
{
    public class Passat: Car
    {
        public Passat()
        {
            Name = CarTypes.Passat;
            Body = BodyCarTypes.Sedan;
        }
    }
}
