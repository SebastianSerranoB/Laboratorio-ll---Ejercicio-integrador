﻿namespace Entidades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hola mundo");

           // Numeracion numPrueba = new Numeracion(200, 0);
            // Console.WriteLine(numPrueba.BinarioADecimal("11000011010100000"));


            //consultar por: division por 0(error?), conversion de enteros negativos a binario(mensaje de error?), conversor de decimales a binarios(truncamos?)
            //en el caso del metodo BinarioADecimal, que pasa si el numero ingresado es 0(la variable que utilizamos como error)
            //el metodo inicialiar valores tambien inicialia Esistema sistema?
            // Console.WriteLine(numPrueba.DecimalABinario(0));
            //deberia valdiar que sistema no sea null? en ConvertirA por ejemplo, o siempre lo controlaremos en la toma de datos de los textbox
            //los rdb binario y decimal por defecto esta en decimal pero el tema de logica aparte de vista se cumple aca?
            //decimalABinario que recibe integer como parametro, donde se usaria? lo estoy utilizando en el getter peor porque si

            //en la sobrecarga de operadores de +-*/ , retorna una nueva instancia de Numeracion, como se cual sistema le corresponde?


            /*Como yo lo interpreto, nunca tenes una instancia en la que sepas de que tipo es el valor que entra como parametro, 
             * porque el unico input de opción del usuario es en que sistema se muestra el resultado, no se si me explico, 
             * previo a inicializarValores, como sabes de que tipo es el valor que le envias como parametro.*/

            //Puede el usuario ingresar un binario como input?; si es asi como lo aclara? que pasa con inicializarValores?

            //FINALMENTE, NOSOTROS EN CADA OPERANDO RECIBIMOS SIEMPRE EN DECIMAL, validamos el binario al pedo

            //antes de sumar, igualas los sistemas de cada objeto numeracion. puedo sumar usar los igualadores, sino converti a decimal, y a l anueva instancia le pasas decimal
            //antes de operar hay que ver que sean del mismo sistema; si bien nosotros siempre vamos a trabajar con decimales porque recibimos el input desde el form, si trabajaramos en la consola, deberiamos poder
            //ver si ambos obj num son iguales, si lo son bien, si no no se hace ninguna operacion
            //resultado es un objt numeracion, 
            //numero invalido si quieren sumar dos sistemas distintos, le retornas por string un num invalido, tamien cuando divide por 0
            //operar por defecto es una suma, si ingresan cualquier cosa no valida, va a ser una suma
            //lo de dividir lo podemos controlar, como queramos ya que el profe no lo pidio, criterio nuestro, el profe ni se gasto pero esta bien
            //la logica deberia estar en operacion o en su defecto numeracion, en lo de dividir por 0, en el peor caso en la vista, tratar de hacer lo menos en la vista
            //si uno de los operandos es erroneo , retornas error o el minvalue

            //retornas un objeto con la propiedad minvalue, vos usa el minvalue para validar, porque si esta en minvalue significa error, ahi tiras el mensaje "numeroInvalidO"

            //las instancias
            //en valor podes hacer que te retorne un convertirA sist de numeracion, el error esta especificado en el momento que tratas de convertirA porque ese metodo llama a BinarioADecimal o DecimalABinario y estos retornan un tipo de valor con numero invalido

           

            //los ctor de numeracion reciben el valor y el tipo de numero que se supone que es (binario o decimal y el valor que recibe debe ser binario o decimal ) en el form, siempre va  aser decimal por defecto pero
            //tenemos que tener la logica para validar que si ingresa un bin corroroborar que sea un bin, sino le asignas min value y cuando operes verificas que no sea minValue

            //el metodo convertirA lo pdoes usar como validador siempre, convertirA , aunque el sistema sea el mismo te sirve apra validar, las validaciones estan en DecimalAabINARIO etc

            //ENUM metelo en la clase, va, si funciona no tiene problema el profesor, pero para el, tiene sentido que entre en Numeracion (metelo,) es entender donde va


            //EsBinario se usa solo si el valor es string
            //hay que validar




            //sobre la carga de constructores , uno llama al otro, hay que validar todo, 

            //evento de que se actualiza texto, al detectar uno de esos cambios, 
            //combobox rdb bina
            //tanto el cambio del combobox radiobuttons como los textbox actualizan el resultado, set resultado, si cambias se invoca  a set Resultado en el momento

            //actualizamos los getters y setters para que usen propiedades

            //si un num dice ser binario y entra un 23, es minvalue porque es mi forma de decir error
        }
    }
}