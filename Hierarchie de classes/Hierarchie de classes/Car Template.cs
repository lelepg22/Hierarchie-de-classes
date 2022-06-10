using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchie_de_classes
{
    public class Car_Template : ICar

    {
        int IVehicle.LicensePlate()
        {
            throw new NotImplementedException();
        }

        int IRoadVehicle.MaxLegalSpeed()
        {
            throw new NotImplementedException();
        }

        int ICar.MaxPassengerCount()
        {
            throw new NotImplementedException();
        }
    }
}
