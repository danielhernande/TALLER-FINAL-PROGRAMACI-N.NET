using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entregable_Taller_Herencia
{
    public class Multiplicacion : Calculo
    {
        public double multiplicacion()
        {
            return (this.getNumero1() * this.getNumero2());
        }
    }
}
