using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.RefBooks;

namespace Factory.Cars
{
    public class Car
    {
        protected CarTypes Name { get; set; }
        protected string Engine { get; set; } = "Diesel";
        protected string PaintColor { get; set; } = "White";
        protected string Wheels { get; set; } = "16 inch";
        protected BodyCarTypes Body { get; set; }

        public void Configure()
        {
            Console.WriteLine($"Configuring {Name.ToString()}");
            Console.WriteLine($"Engine is {Engine}");
            Console.WriteLine($"Body is {Body.ToString()}");
            Console.WriteLine($"PaintColor is {PaintColor}");
            Console.WriteLine($"Wheels are {Wheels}");
        }

        public void AssembleBody()
        {
            Console.WriteLine("Body is AssembleBody");
        }

        public void InstallEngine()
        {
            Console.WriteLine("Engine is in its place");
        }

        public void Paint()
        {
            Console.WriteLine("Car is paints");
        }

        public void InstallWheels()
        {
            Console.WriteLine("Wheels is installed");
        }
    }
}
