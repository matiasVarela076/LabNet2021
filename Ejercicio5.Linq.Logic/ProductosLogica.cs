

using Ejercicio5.Linq.Entitites;
using Ejercicio5.Linq.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.EF.Logic
{
    public class ProductosLogica : BaseLogica
                                                                  //Le digo a mi interfaz generica
    {                                                             //Que implemente los metodo Tipo Products

     
       public List<Products> GetAll()
        {
            return context.Products.ToList(); //Metodo que retorna toda la tabla Productos
        }

        public void ListaProductos(IEnumerable<Products> query)
        {
            foreach (var item in query)
            {
               Console.WriteLine($"Id- {item.ProductID} - Nombre- {item.ProductName} - Stock - { item.UnitsInStock}");
            }
            Console.ReadLine();
        }

        public void ListaNombres(IEnumerable<Products> query)
        {
            foreach (var item in query)
            {
                Console.WriteLine($"Id- {item.ProductID} - Nombre- {item.ProductName}");
            }
            Console.ReadLine();
        }

        public void ListaProduCategoryID(IEnumerable<Products> query)
        {
            foreach (var item in query)
            {
                Console.WriteLine($"{item.ProductName} - IDCategory- {item.CategoryID}");
            }
            Console.ReadLine();
        }





    }
}

