using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //punto 1
            int numero = 10;
            numero.divisionPorCero();

            //punto 2

            int divisor = 5;
            int dividendo = 0;                        //Si dejamos asi nos da una exception.
            divisor.division(dividendo);             //Si cambiamos el dividendo la operación se realiza 
            
            //Punto 3
            ExtensionMethods.capturaDeException();
            
            //punto 4
            ExtensionMethods.miPropiaException();
            Console.WriteLine("Fin del programa");
            
        }
    }
}
