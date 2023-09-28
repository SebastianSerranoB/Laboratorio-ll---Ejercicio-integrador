using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Numeracion
    {
        private Esistema sistema;
        private double valorNumerico;

        //objeto d etipo resultado , convertirA
        //aca elegis como se va a guardar, cuando recibis el input de la calculadora, lo recibis siempre instancia en decimal
        //los txtOperandos 

        
        public Numeracion(double valorNumerico, Esistema sistema) :  this(valorNumerico.ToString(), sistema) //este va a llamar a numeracion :this(valornumerico.tostring()) y valida e inicia el otro, aca en teoria podria ingresar un binario tambien por eso, pero no te enrosques con este tema
        {
        }
        public Numeracion(string valor, Esistema sistema)
        {
            InicializarValores(valor, sistema);
        }
        

        public Esistema Sistema
        {
            get { return this.sistema; }
        }
        public string Valor
        {
            get 
            {
                if (Sistema == Esistema.Binario)
                {
                    return DecimalABinario((int)this.valorNumerico);
                    // return DecimalABinario(this.valorNumerico.ToString());
                }
                else
                {
                    return this.valorNumerico.ToString();
                }
            }
               
        }

        private void InicializarValores(string valor, Esistema sistema)
        {
            this.valorNumerico = double.MinValue;
            this.sistema = Esistema.Decimal;
            //por defecto
            
            /*
            if (EsBinario(valor)) // si aca te pasan un 10, te lo guarda como un 2, error
            {
                this.valorNumerico = BinarioADecimal(valor);
            }
            else if ((decimal.TryParse(valor, out decimal valorIngresado)))
            {
                this.valorNumerico = (double)valorIngresado;
            }

            if (sistema == Esistema.Binario)
            {
                this.sistema = Esistema.Binario;
            }
            else
            {
                this.sistema = Esistema.Decimal;
            }
            */


            


            if (sistema == Esistema.Binario)
            {
                this.sistema = Esistema.Binario;
                //si bien el metodo BinarioADecimal hace esta validacion, binarioADecimal retorna 0 en el error, a mi me interesa diferencia cuando es error, y cuando es un 0 valido.
                //como se si el usuario ingreso en decimales o en binario, decimal(10) binario = 2; unos y ceros. O asumimos que siempre ingresa en decimal?
                //El metodo BinarioADecimal y EsBinario estaria pintado si nunca ingresan binarios. 
                if (EsBinario(valor)) 
                {
                    this.valorNumerico = BinarioADecimal(valor);
                }
                else
                {
                    if ((decimal.TryParse(valor, out decimal valorIngresado)))
                    { 
                        this.valorNumerico = (double)valorIngresado;
                    }
                }
            }
             else if ((decimal.TryParse(valor, out decimal valorIngresado)))
            {
                    this.valorNumerico = (double)valorIngresado;
            }

        }

        private double BinarioADecimal(string valor)
        {
            double valorDecimal = 0;
          
           
            if (EsBinario(valor))
            {
                int longitudValor = valor.Length;
                int digito;
                

                for (int i = 0; i < longitudValor; i++)
                {
                    //los caracteres '0' y '1' tienen valores ASCII consecutivos
                    //codigo ascci de 0 == 48, codigo ascci de 1 == 49;
                    //si valor[i] es '0' 48-48 digito = 0; si es '1', 49 -48 digito = 1;
                    //transformamos el valor representando en char a el valor integer correspondiente;
                    digito = valor[i] - '0';

                    //multiplicamos digito por 2 elevado a cada una de las posiciones del binario, como siempre es el 2 el que se eleva,
                    //es indistinto que posicion se eleva primero, en este caso, comenzamos desde la posicion mas a la derecha(menos significativa) hacia la izquierda.
                    //el digito va desde la izquierda hacia la derecha comenzando en 0;
                    //elevamos y casteamos a integuer porque pow retorna un double y vamos a despreciar los decimales
                    //longitudValor - 1 - longitudValor -1 + i deberia funcionar tambien, si queres verlo de izquierda a derecha
                   // resultado += digito * (int)Math.Pow(2, longitudValor - 1 - longitudValor - 1 + i); no esto no arranca
                   //Los digitos son siempre 0 y 1, las elevaciones son siempre sobre el 2, y esto se va sumando con la interacion, asi que es indistinto, que un digito se multiplique por el 2 elevado a otra posicion, daria lo mismo
                   //Lo que pasa, es que la  cuenta manual, es mas logico hacerla posicion por posicion, pero aca se puede resolver asi.
                   // lo importante es que todos los digitos se multiplican y que todas las posiciones se elevan con el 2, es indistinto el orden
                    valorDecimal += digito * (int)Math.Pow(2, longitudValor - 1 - i);
                }

                return valorDecimal;
            }
            

            return valorDecimal;
        }
        private string DecimalABinario(string valor)
        {
            string valorBinario = "Numero invalido";

            //valido que sea un entero positivo;
            if (!(string.IsNullOrEmpty(valor)))
            {
                if (decimal.TryParse(valor, out decimal valorIngresado))
                {
                    
                    int numeroEntero = (int)valorIngresado;
                    //caso de que el decimal sea 0
                    if (numeroEntero == 0)
                    {
                        valorBinario = "0";
                    }
                    if (numeroEntero > 0)
                    {
                        int resto;
                        valorBinario = string.Empty;
                        while (numeroEntero > 0)
                        {

                            resto = numeroEntero % 2;
                            numeroEntero /= 2;
                            valorBinario = resto.ToString() + valorBinario;
                        }
                      
                    }
                }
            }



            return valorBinario;
        }
        //donde uso este metodo? lo puse en el getter de onda
        private string DecimalABinario(int valor)
        {
            return DecimalABinario(valor.ToString());
        }
        

        public string ConvertirA(Esistema sistema)
        {
            //por si el parametro fuera null is not null
            string retorno = "null";

            if (sistema == Esistema.Decimal)
            {
                retorno = this.valorNumerico.ToString();
            }
            else if(sistema == Esistema.Binario)
            {
                retorno = DecimalABinario(this.valorNumerico.ToString());
            }
           
            return retorno;
        }
        private bool EsBinario(string valor)
        {
            bool retorno = true;

            if (!(string.IsNullOrEmpty(valor) ) )
            {
                foreach (char c in valor)
                {
                    if (c != '0' && c != '1')
                    {
                        retorno = false;
                    }
                }
            }
            else
            {
                retorno = false;
            }


            return retorno;
        }


        public static bool operator ==(Esistema sistema, Numeracion numeracion)
        {
            return sistema == numeracion.Sistema;
        }
        public static bool operator !=(Esistema sistema, Numeracion numeracion)
        {
            return !(sistema == numeracion.Sistema);
        }

        public static bool operator ==(Numeracion n1, Numeracion n2)
        {
            return n1.Sistema == n2;
        }
        public static bool operator !=(Numeracion n1, Numeracion n2)
        {
            return !(n1.Sistema == n2);
        }

        public static Numeracion operator +(Numeracion n1, Numeracion n2)
        {
            return new Numeracion(n1.valorNumerico + n1.valorNumerico, n1.sistema);
        }

        public static Numeracion operator -(Numeracion n1, Numeracion n2)
        {
            return new Numeracion(n1.valorNumerico - n1.valorNumerico, n1.sistema);
        }

        public static Numeracion operator /(Numeracion n1, Numeracion n2)
        {
            return new Numeracion(n1.valorNumerico / n1.valorNumerico, n1.sistema);
        }
        public static Numeracion operator *(Numeracion n1, Numeracion n2)
        {
            return new Numeracion(n1.valorNumerico * n1.valorNumerico, n1.sistema);
        }

        





    }
}
