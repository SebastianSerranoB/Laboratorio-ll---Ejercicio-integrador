using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{   /// <summary> Class <c>Numeracion</c> Modela un numero, con su valor y el sistema numerico correspondiente. </summary>
    public class Numeracion
    {
        private Esistema sistema;
        private double valorNumerico;

        /// <summary>
        /// ctor, realiza las validaciones correspondientes
        /// </summary>
        /// <param name="valorNumerico"></param>
        /// <param name="sistema"></param>
        public Numeracion(double valorNumerico, Esistema sistema) :  this(valorNumerico.ToString(), sistema)
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
       
        /// <summary>
        /// Propiedad, retorna el valorNumerico en formato string en el Esistema correspondiente.
        /// </summary>
        public string Valor
        {
            get 
            {
                if (Sistema == Esistema.Binario)
                {
                     return DecimalABinario(this.valorNumerico.ToString());
                }
                else
                {
                    if (this.valorNumerico == double.MinValue)
                    {
                        return "Numero invalido";
                    }
                    else
                    {
                        return this.valorNumerico.ToString();
                    }
                    
                }
            }
               
        }
       
        /// <summary>
        /// Inicializa los valores Esistema y valorNumerico, validandolos previamente.
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="sistema"></param>
        private void InicializarValores(string valor, Esistema sistema)
        {
            this.valorNumerico = double.MinValue;
            this.sistema = Esistema.Decimal;
           
            
            if (sistema == Esistema.Binario)
            {
                this.sistema = Esistema.Binario;
                
                if (EsBinario(valor)) 
                {
                    this.valorNumerico = BinarioADecimal(valor);
                }
                else//permito que si ingreso un numero decimal, lo guarde y no tire error.
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


        /// <summary>
        /// Convierte un numero en sistema binario a decimal.
        /// </summary>
        /// <param name="valor"></param> numero en sistema binario
        /// <returns></returns>
        private double BinarioADecimal(string valor)
        {
            double valorDecimal = 0;
          
            if (EsBinario(valor))
            {
                int longitudValor = valor.Length;
                int digito;
                

                for (int i = 0; i < longitudValor; i++)
                { 
                    digito = valor[i] - '0';

                    valorDecimal += digito * (int)Math.Pow(2, longitudValor - 1 - i);
                }

                return valorDecimal;
            }
            
            return valorDecimal;
        }

        /// <summary>
        /// Convierte un numero en sistema decimal a binario y lo retorna.
        /// </summary>
        /// <param name="valor"></param>numero en sistema decimal.
        /// <returns></returns>
        private string DecimalABinario(string valor)
        {
            string valorBinario = "Numero invalido";

            if (!(string.IsNullOrEmpty(valor)))
            {
                if (decimal.TryParse(valor, out decimal valorIngresado))
                {
                    
                    int numeroEntero = (int)valorIngresado;
                    
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
       
        private string DecimalABinario(int valor)
        {
            return DecimalABinario(valor.ToString());
        }
        
        /// <summary>
        /// Convierte el valorNumerico a el sistema numerico recibido por parametro.
        /// </summary>
        /// <param name="sistema"></param>Enum Esistema
        /// <returns></returns>
        public string ConvertirA(Esistema sistema)
        {
            string retorno = "null";

            if (this.valorNumerico == double.MinValue)
            {
                retorno = "Numero invalido";
            }
            else
            {
                if (sistema == Esistema.Decimal)
                {
                    retorno = this.valorNumerico.ToString();
                }
                else if (sistema == Esistema.Binario)
                {
                    retorno = DecimalABinario(this.valorNumerico.ToString());
                }

            }

          
            return retorno;
        }
       
        /// <summary>
        /// Corrobora que el valor ingresado por parametro sea un numero en sist binario.
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
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



        /// <summary>
        /// retorna un valor booleando, comparando los enum Esistema.
        /// </summary>
        /// <param name="sistema"></param>
        /// <param name="numeracion"></param>
        /// <returns></returns>
        public static bool operator ==(Esistema sistema, Numeracion numeracion)
        {
            return sistema == numeracion.Sistema;
        }
        public static bool operator !=(Esistema sistema, Numeracion numeracion)
        {
            return !(sistema == numeracion.Sistema);
        }

        /// <summary>
        /// Retorna un valor booleano, comparando los Esistema de cada obj Numeracion.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
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
            return new Numeracion(n1.valorNumerico + n2.valorNumerico, n1.sistema);
        }

        public static Numeracion operator -(Numeracion n1, Numeracion n2)
        {
            return new Numeracion(n1.valorNumerico - n2.valorNumerico, n1.sistema);
        }

        /// <summary>
        /// Realiza una division entre dos obj Numeracion, la redondea a un maximo de 5 decimales.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static Numeracion operator /(Numeracion n1, Numeracion n2)
        {
            return new Numeracion(Math.Round(n1.valorNumerico / n2.valorNumerico,5), n1.sistema);
        }
        public static Numeracion operator *(Numeracion n1, Numeracion n2)
        {
            return new Numeracion(n1.valorNumerico * n2.valorNumerico, n1.sistema);
        }

        





    }
}
