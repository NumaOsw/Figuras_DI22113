using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_DI22113
{
    class Triangulo : Figura
    {
        public Triangulo(float Bass) 
        {
            Lado1 = Bass;
        }
        private float Hra;
        public float hRa
        {
            set
            {
                if (value < 0) { Hra = 0; } else { Hra = value; }
            }
            get
            {
                return Hra;
            }
        }
        public Triangulo(float Bass, float Hra)
        {
            this.Lado1 = Bass;
            this.Hra = hRa;
        }
        public override float area()
        {
            return (Lado1 * Hra) / 2;
        }
        public override float perimetro()
        {
            return (Lado1 * Hra);
        }
        public override float volumen()
        {
            throw new NotImplementedException();
        }
    }
}
