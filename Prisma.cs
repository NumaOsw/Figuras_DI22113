using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_DI22113
{
    class Prisma : Figura
    {
        public Prisma(float PrtOn)
        {
            Lado1 = PrtOn;
        }
        private float PrtMdo;
        private float PrtFnl;

        public float mDo
        {
            set
            {
                if (value < 0) { PrtMdo = 0; } else { PrtMdo = value; }
            }
            get
            {
                return PrtMdo;
            }
        }
        public float fnL
        {
            set
            {
                if (value < 0) { PrtFnl = 0; } else { PrtFnl = value; }
            }
            get
            {
                return PrtFnl;
            }
        }
        public Prisma(float PrtOn, float PrtMdo, float PrtFnl)
        {
            this.Lado1 = PrtOn;
            this.mDo = PrtMdo;
            this.fnL = PrtFnl;
        }
        public override float area()
        {
            throw new NotImplementedException();
        }
        public override float perimetro()
        {
            throw new NotImplementedException();
        }
        public override float volumen()
        {
            float A_bse, A_craltl_1, A_craltl_2, A_ttal;
            A_bse = Lado1 * mDo;
            A_craltl_1 = Lado1 * fnL;
            A_craltl_2 = mDo * fnL;
            A_ttal = A_craltl_1 + A_craltl_2;
            return A_ttal + A_bse;
            
        }

        class Rectangular :Figura //Intento de conectar 
        {
            public Rectangular(float Ldo)
            {
                Lado1 = Ldo;
            }
            public override float area() { throw new NotImplementedException(); }
            public override float perimetro()
            {
                throw new NotImplementedException ();
            }
            public override float volumen()
            {
                throw new NotImplementedException();
            }
        }
        class Cilindro : Figura
        {
            public Cilindro(float Ldo)
            {

                Lado1 = Ldo;
            }
            public override float area() { throw new NotImplementedException(); }
            public override float volumen()
            {
                throw new NotImplementedException();
            }
            public override float perimetro()
            {
                throw new NotImplementedException();
            }
        }
    }
}
