﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcFinal
{
    public class Multiplicacion : Operacion
    {
        public override double Calcular()
        {
            return Numero1 * Numero2;
        }
    }
}
