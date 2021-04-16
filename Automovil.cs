using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_POO_Lab_Transporte
{
    class Automovil : Transporte, Terrestre
    {
        static int cantAutomovil = 0;
            public Automovil(int pasajeros): base(pasajeros)
        {
            this.GetPasajeros(); //Traigo el atributo de la clase padre y se lo paso a la clase Hija
        }
        public override string Avanzar()
        {
            return "Soy un automovil, y avanzo con mis 4 ruedas";
        }

        public override string Detenerse()
        {
            return "Soy un automovil, y puedo usar mis frenos";
        }

        public string tipoTierra()
        {
            return "Yo solo me puedo mover por tierra"; //Interfaz Terrestre implementada
        }

        public override string ToString(){
            return $"Automóvil {++cantAutomovil}: {GetPasajeros()} pasajeros";
        }


    }
}
