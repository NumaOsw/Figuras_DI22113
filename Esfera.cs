using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_DI22113
{
    class Esfera : Figura
    {
        public Esfera(float radio) //radio se va a leer de la caja de txto con el boton guardar
        {
            Lado1 = radio;
        }
        //Vamos a usar metodos de la clase padre y sobreescribir (override) el comportamiento de esta
        public override float area()
        /*Agregamos F al final de un numero cuando es una constante no definida en una variable
         * previamente, asi el programa sabe que es un #*/
        {
            return 3.1416F * Lado1 * Lado1;
        }
        public override float perimetro()
        {
            throw new NotImplementedException();
        }
        public override float volumen()
        {
            return (4f * 3.1416f * Lado1) / 4;
        }
    }
}
