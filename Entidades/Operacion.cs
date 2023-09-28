using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Operacion
    {

        private Numeracion primerOperando;
        private Numeracion segundoOperando;


        public Operacion(Numeracion primerOperando, Numeracion segundoOperando)
        { 
            this.primerOperando = primerOperando;
            this.segundoOperando = segundoOperando;
        }

        public Numeracion PrimerOperando
        { 
            get 
            { 
                return this.primerOperando;
            }
            set 
            {
                if (value is not null)
                { 
                    this.primerOperando = value; 
                }
                 
            }
        }

        public Numeracion SegundoOperando
        { 
            get
            {
                return this.segundoOperando;
            }
            set
            {
                if (value is not null)
                {
                    this.segundoOperando = value;
                }
            }
        }

        public Numeracion Operar(char Operador)
        {
            //va a trabajr con primer y segundo operando
           
            //validar si el char ingresado es un caracter valido
            //realizar las operaciones correspondientes valiendonos de
            // las sobrecargas de operadores para Numeracion, etc.

            //Por defecto ejectua una suma++++, 
            //pero hay que validar 'operador' para casos - ,*, /

            return this.primerOperando;
        }












    }
}
