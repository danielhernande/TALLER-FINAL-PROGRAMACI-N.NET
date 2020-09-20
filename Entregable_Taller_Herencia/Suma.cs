using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entregable_Taller_Herencia
{
   public class Suma : Calculo
    {
        public double suma()
        {
            return (this.getNumero1() + this.getNumero2());
        }

    }
}
