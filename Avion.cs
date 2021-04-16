using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_POO_Lab_Transporte
{
    public class Avion : Transporte, Volador
    {

      static int cantAviones = 0;
        public Avion(int pasajeros) : base(pasajeros)
        {
           this.GetPasajeros(); 
        }

      
        public override string Avanzar()
        {
            return "Soy un avion, avanzo";
        }

        public override string Detenerse()
        {
            return "Soy un avion, y estoy frenando";
        }

        public string tipoVolador()
        {
            return "Soy de tipo volador, y puedo surcar los cielos"; //Interfaz Volador implementada
        }

        public override string ToString(){
            return $"Avión {++cantAviones}: {GetPasajeros()} pasajeros";
        }

    }
}
