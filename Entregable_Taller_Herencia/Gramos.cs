using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entregable_Taller_Herencia
{
    public class Gramos : Conversion
    {

        public double gramos()
        {
            return (this.getKilos() * 1000); 
        }

    }
}
