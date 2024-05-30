using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_DI22113
{
    class Poligono_R:Figura
    {
        private float Caras;
        private float Hptm;
        public float c
        
            {
                set
            {
                    if (value < 0) { Caras = 5; } else { Caras = value; }
                }
                get
            {
                    return Caras;
                }
            }
        public float hpm
        {
            set
            {
                if (value < 0) { Hptm = 0; } else { Hptm = value; }
            }
            get
            {
                return Hptm;
            }
        }
        public Poligono_R(float Ldo_1, float Caras, float Hptm)
        {
            this.Lado1 = Ldo_1;
            this.Caras = c;
            this.Hptm = hpm;
        }
        public override float perimetro()
        {
            float Prmtro;
            Prmtro = Lado1* Caras;
            return Prmtro;
        }
        public override float area()
        {
            return (perimetro() * Hptm)/2;
        }
        public override float volumen()
        {
            throw new NotImplementedException();
        }
    }
}
