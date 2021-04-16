using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_POO_Lab_Transporte
{
    class Program
    {
        static void Main(string[] args)
        
       
        
        {   
            
             List<Transporte> ListaDeTrasportes = new List<Transporte>
             {
                 new Avion(100),
                 new Avion(30),
                 new Avion(10),
                 new Avion(40),
                 new Avion(50),    //List de 5 aviones y 5 automoviles
                 new Automovil(2),
                 new Automovil(4),
                 new Automovil(6),
                 new Automovil(8),
                 new Automovil(10)

             };

            foreach (var item in ListaDeTrasportes)
            {
                Console.WriteLine(item.ToString());
                Console.ReadKey();
            }
             

        }
    }
}
