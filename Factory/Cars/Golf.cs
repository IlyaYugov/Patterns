using Factory.RefBooks;

namespace Factory.Cars
{
    public class Golf : Car
    {
        public Golf()
        {
            Name = CarTypes.Golf;
            Body = BodyCarTypes.Hatchback;
        }
    }
}
