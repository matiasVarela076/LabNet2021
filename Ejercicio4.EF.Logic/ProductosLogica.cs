
using Ejercicio4.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.EF.Logic
{
    public class ProductosLogica : BaseLogica, IABMLogica<Products>
                                                                  //Le digo a mi interfaz generica
    {                                                             //Que implemente los metodo Tipo Products

        public void Add(Products nuevoProducto)
        {
            context.Products.Add(nuevoProducto); //Paso al contexto el nuevo territorio
            context.SaveChanges(); //Guardo los cambios
        }

        public void Delete(int id) //nota: No lo puse en la interfaz porque products tiene id varchar 
                                   //Podria haber hecho una sobrecarga tambien. Pero opte por no hacerlo
        {
             var productoAEliminar = context.Products.Find(id); 
            context.Products.Remove(productoAEliminar); 
           context.SaveChanges(); 
        } 
       public List<Products> GetAll()
        {
            return context.Products.ToList(); //Metodo que retorna toda la tabla Productos
        }

        public void RefrescarLista(ProductosLogica  productos)  
        {
            foreach (Products listaProductos in productos.GetAll())
            {
                Console.WriteLine($"{listaProductos.ProductName} - {listaProductos.UnitPrice}");
            }
            Console.ReadKey();
        }

        public void Update(Products producto)
        {
            var productoAModificar = context.Products.Find(producto.ProductID);
            
            productoAModificar.ProductName = producto.ProductName;
            productoAModificar.UnitPrice = producto.UnitPrice;
            context.SaveChanges(); //Guardamos cambios
        }
    }
}
