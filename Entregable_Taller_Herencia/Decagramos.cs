using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entregable_Taller_Herencia
{
    public class Decagramos :Conversion
    {
        public double decagra()
        {
            return (this.getKilos() * 100);
        }

    }
}
