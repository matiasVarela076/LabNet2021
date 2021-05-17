using Ejercicio4.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.EF.Logic
{
    public class TerritoriosLogica : BaseLogica, IABMLogica<Territories> //Le digo a mi interfaz generica
    {                                                                           //Que implemente los metodo Tipo Territories

        public List<Territories> GetAll()
        {
            return context.Territories.ToList(); //Metodo que retorna toda la tabla Productos
        }
        public void Add(Territories nuevoTerritorio)
        {
            context.Territories.Add(nuevoTerritorio); //Paso al contexto el nuevo territorio
             context.SaveChanges(); //Guardo los cambios
        }

        public void Delete (string id)
        {
            var TerritorioAEliminar = context.Territories.Find(id); //Encuentramos el id

            context.Territories.Remove(TerritorioAEliminar); //Lo eliminamos
            context.SaveChanges(); //Guardamos cambios
        }

        public void Update(Territories territorio)
        {
            var TerritorioAModificar = context.Territories.Find(territorio.TerritoryID);

            TerritorioAModificar.TerritoryDescription = territorio.TerritoryDescription;

            context.SaveChanges(); //Guardamos cambios

        }
   

    }
}
