using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchie_de_classes
{
    public class Mercedes_Across : ITruck
    {

        public Mercedes_Across(ITruck mercedes)
        {

        }
        int IVehicle.LicensePlate()
        {
            throw new NotImplementedException();
        }

        int ITruck.MaxFreight()
        {
            throw new NotImplementedException();
        }

        int IRoadVehicle.MaxLegalSpeed()
        {
            throw new NotImplementedException();
        }
    }
}
