using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3Exceptions
{
    public class Exceptions
    {
       
      
        public static void capturaDeException()  //Punto 3
        {
            try
            {
                DateTime? fechaNull = null;
                string fechaNueva = fechaNull.Value.ToString("MM/yy"); //Esto genera una Exception
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Exception capturada!!!\n\nDio un: {ex}");
                Console.ReadKey();

            }
            finally
            {
                Console.WriteLine("\nTermino el bloque try catch, este es el finally");
                Console.ReadKey();
            }
        }
        public static void miPropiaException() //Punto 4
        {

            try
            {
                throw new CustomException();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception propia capturada!!!\n\nDio una: {ex.Message}");
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

