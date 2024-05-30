using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_DI22113
{
    class Cuadrado: Figura
    {
        public Cuadrado(float Part_A)
        {
            Lado1 = Part_A;
        }
        public override float area()
        {
            return Lado1 * Lado1;
        }
        public override float perimetro()
        {
            return Lado1 + Lado1 + Lado1 + Lado1;
        }
        public override float volumen()
        {
            throw new NotImplementedException();
        }
    }
}
