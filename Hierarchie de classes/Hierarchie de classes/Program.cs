using System;

namespace Hierarchie_de_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            ITruck mercedes = new Truck_Template();
            ICar renault = new Car_Template();
        }
    }
}
