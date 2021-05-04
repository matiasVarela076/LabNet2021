using Ejercicio4.EF.Logic;
using Ejercicio5.Linq.Data;
using Ejercicio5.Linq.Entitites;
using Ejercicio5.Linq.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.LINQ.UI
{
    class Program 
    {
        

        static void Main(string[] args)
        {
       
            ProductosLogica productos = new ProductosLogica();
            CustomersLogica clientes = new CustomersLogica();
            OrdersLogica ordenes = new OrdersLogica();
            CategoriesLogica categoria = new CategoriesLogica();


            //1.Query para devolver objeto customer

             var query1 = clientes.GetAll();
             clientes.ListaClientes(query1);

            //2.Query para devolver todos los productos sin stock
             var query2 = productos.GetAll().Where(s => s.UnitsInStock == 0);
              productos.ListaProductos(query2);

            /*3.Query para devolver todos los productos que
            tienen stock y que cuestan más de 3 por unidad*/

                var query3 = from produc in productos.GetAll()
                where (produc.UnitsInStock > 3 && produc.UnitsInStock != 0)
                select produc;
                productos.ListaProductos(query3);


            //4.Query para devolver todos los customers de Washington

             var query4 = from clie in clientes.GetAll()
              where (clie.Region == "WA")
              select clie;
             clientes.ListaClientes(query4);


            /*5.Query para devolver el primer elemento o nulo de una lista de productos donde el ID de
               producto sea igual a 789*/

             var query5 = productos.GetAll().FirstOrDefault(p => p.ProductID == 789);

            /*6.Query para devolver los nombre de los Customers.Mostrarlos en Mayuscula y en Minuscula.*/
            
              var query6 = clientes.GetAll();
             clientes.UpperAndLowerCustomers(query6);

            /*7. Query para devolver Join entre Customers y Orders donde los customers sean de
            Washington y la fecha de orden sea mayor a 1/1/1997.*/
            
              var query7 = from clie in clientes.GetAll()
                           join order in ordenes.GetAll()
                           on clie.CustomerID equals order.CustomerID
                           where clie.Region == "WA" && order.OrderDate > new DateTime(1997,1,1)
                           select clie;
              clientes.ListaClientes(query7);

            //8.Query para devolver los primeros 3 Customers de Washington

            var query8 = clientes.GetAll().Where(i => i.CustomerID == "WA");

            clientes.ListaClientes(query8);   //Todavia falta porque me trae a todos los clientes

       
            //9.Query para devolver lista de productos ordenados por nombre

            var query9 = productos.GetAll().OrderBy(n => n.ProductName)
                         .Select(n => n);
            productos.ListaNombres(query9);
            //10-Query para devolver lista de productos ordenados por unit in stock de mayor a menor.

            var query10 = from produ in productos.GetAll()
                          orderby produ.UnitsInStock descending
                          select produ;
            productos.ListaProductos(query10);

            //11.Query para devolver las distintas categorías asociadas a los productos
            var query11 = from produ in productos.GetAll()
                          select produ;
            productos.ListaProduCategoryID(query11);

                         

        }


    }
}
