using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3Exceptions
{
    public static class ExtensionMethods
    {
        public static void divisionPorCero(this int num) //Punto 1
        {
            try
            {
                int resultado = num / 0;

                Console.WriteLine($"El resultado es {resultado}");
                Console.WriteLine("Operacion exitosa");
                Console.ReadKey();

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("No se puede dividir por cero!!! :(");
                Console.WriteLine("Operación no exitosa");
                Console.ReadKey();
            }
            finally
            {
                Console.WriteLine("Pasa por el finally");
                Console.ReadKey();
            }

        }

        public static void division(this int divisor, int dividendo) //Punto 2
        {
            try
            {
                int resultado = divisor / dividendo;

                Console.WriteLine($"El resultado de la division es: {resultado}");
                Console.ReadKey();
            }

            catch (DivideByZeroException e)
            {

                Console.WriteLine($"Dio un: {e}");
                Console.ReadKey();
                Console.WriteLine("Mucho tiki tiki programando en la compu, pero no sabes que no se puede dividir por cero!");
                Console.ReadKey();

            }
            catch (Exception)
            {
                Console.WriteLine("Seguro Ingreso una letra o no ingreso nada!");
                Console.ReadKey();
            }
            finally
            {
                Console.WriteLine("Termino el bloque try catch");
                Console.ReadKey();
            }
        }

    }
}
