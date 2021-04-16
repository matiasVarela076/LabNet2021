using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_POO_Lab_Transporte
{
    public abstract class Transporte 
     //Implemento la interfaz para que tenga que me obligue (contrato) a usar los metodos
    
    {

        private int pasajeros;
        public Transporte(int pasajeros)
        {
            this.pasajeros = pasajeros;
        }

        public int GetPasajeros()
        {
            return pasajeros;
        }

        public abstract string Avanzar();

        public abstract string Detenerse();


    }
}
