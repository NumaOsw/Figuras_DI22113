using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_DI22113
{
   
    abstract class Figura
    //Clase Padre: Permite el ingreso de un lado, para poder cerar una nueva figura
    //Recuerda que una figura para existir requiere minimo un lado 
    //La clase abstrac es un molde, ella solo define el comportamiento de una figura
    {
        /*Declarando las variables que se va a pasar a las clases hijas, nos serviran para guardar en caja
        de memoria el valor del primer lado*/
        //La variable sera privada
        private float lado1; //Permitiendo decimales

        public float Lado1 //Creamos un atributo, constructor
        {
            set //colocar valor 
            {//if pregunta si el lado es menor a 0 regresa un valor a cero y no existen los lados negativos
                // Si no existen lados negativos else vuelve el valor del textbox
                if (value < 0) { lado1 = 0; } else { lado1 = value; }
            }
            get //Obtener el valor
            {
                return lado1; //regresa el valor de la variable lado1
            }
        }
        /*Defino métodos de la clase padre que tambien van a tener los hijos son del tipo publico para que todos 
         * los usen, metodos abstractos van vacios ya que cada hijo define sus operaciones*/
        public abstract float area();
        public abstract float perimetro();
        public abstract float volumen();
    }
}
