using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchie_de_classes
{
    public class Renault_Clio : ICar
    {

        public Renault_Clio(ICar renault) { 
        }
        public int LicensePlate()
        {
            throw new NotImplementedException();
        }

        public int MaxLegalSpeed()
        {
            throw new NotImplementedException();
        }

        public int MaxPassengerCount()
        {
            throw new NotImplementedException();
        }
    }
}
