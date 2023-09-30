using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operacion
    {

        private Numeracion primerOperando;
        private Numeracion segundoOperando;

        /// <summary>
        /// Constructor, instancia un objeto Operacion con dos operandos de tipo Numeracion.
        /// </summary>
        /// <param name="primerOperando"></param>
        /// <param name="segundoOperando"></param>
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
        /// <summary>
        /// Ejectura la operacion correspondiente, retornando un obj numeracion con el resultado.
        /// </summary>
        /// <param name="operador"></param> indica la operacion a ejecutar.
        /// <returns></returns>
        public Numeracion Operar(char operador)
        {
            if (this.PrimerOperando != this.SegundoOperando)
            {
                return new Numeracion(double.MinValue, Esistema.Decimal);

            }
            else
            {
                switch (operador)
                {
                    case '-':
                        return this.PrimerOperando - this.SegundoOperando;

                    case '/':
                        if (this.SegundoOperando.Valor == "0" || this.PrimerOperando.Valor == "0")
                        {
                            return new Numeracion(double.MinValue, Esistema.Decimal);
                        }
                        else
                        {
                            return this.PrimerOperando / this.SegundoOperando;
                        }


                    case '*':
                        return this.PrimerOperando * this.SegundoOperando;


                    default:
                        return this.PrimerOperando + this.SegundoOperando;

                }


            }
            

        }












    }
}
