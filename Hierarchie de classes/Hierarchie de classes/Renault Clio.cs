using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchie_de_classes
{
    public class Renault_Clio : ICar 
    {
        public Car_Template templateCar;
        public Renault_Clio(Car_Template useIt)
        {
            templateCar = useIt;

            useIt.LicensePlate();

            useIt.MaxPassengerCount();
        }

        public int LicensePlate()
        {
            return ((IVehicle)templateCar).LicensePlate();
        }

        public int MaxLegalSpeed()
        {
            return ((IRoadVehicle)templateCar).MaxLegalSpeed();
        }

        public int MaxPassengerCount()
        {
            return ((ICar)templateCar).MaxPassengerCount();
        }
    }
}
