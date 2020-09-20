using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entregable_Taller_Herencia
{
   public class Miligramos : Conversion
    {
        public double mili()
        {
            return (this.getKilos() / 0.0000010000);
        }
    }
}
