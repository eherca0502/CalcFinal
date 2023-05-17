using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcFinal
{
    public abstract class Operacion
    {
        public static double numero1 = -1;
        public static double numero2 = -1;

       
        public double Numero1
        {
            get { return numero1; }
            set {numero1 = value;}
        }
        public double Numero2
        {
            get { return numero2; }
            set { numero2 = value;}
        }
        public abstract double Calcular();
    }
}
