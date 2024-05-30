using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_DI22113
{
    class Cubo: Figura
    {
        public Cubo(float Medas)
        {
            Lado1 = Medas;
        }
        public override float area()
        {
            return (Lado1* Lado1)*6;
        }
        public override float perimetro()
        {
            return Lado1;
        }
        public override float volumen()
        {
            return (Lado1 * Lado1 * Lado1);
        }
    }
}
