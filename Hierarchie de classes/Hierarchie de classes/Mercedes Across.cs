using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchie_de_classes
{
    public class Mercedes_Across : Truck_Template
    {
        public Truck_Template template;
        public Mercedes_Across(Truck_Template useIt)
        {
            template = useIt;

            useIt.LicensePlate();


            useIt.MaxFreight();


            useIt.MaxLegalSpeed();
            
        }

    }

}
