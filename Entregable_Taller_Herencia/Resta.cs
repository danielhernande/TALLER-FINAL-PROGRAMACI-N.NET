using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entregable_Taller_Herencia
{
    public class Resta : Calculo
    {
        public double resta()
        {
            return (this.getNumero1() - this.getNumero2());
        }
    }
}
