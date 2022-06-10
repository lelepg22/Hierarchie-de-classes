using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchie_de_classes
{
    public class Renault_Clio : Car_Template
    {
        public Car_Template templateCar;
        public Renault_Clio(Car_Template useIt)
        {
            templateCar = useIt;

            useIt.LicensePlate();
        }
         
       
    }
}
