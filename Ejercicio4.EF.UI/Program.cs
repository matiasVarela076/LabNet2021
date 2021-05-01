using Ejercicio4.EF.Entities;
using Ejercicio4.EF.Logic;  //Traemos la referencia para usar la capa Logic
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio4.EF.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4)Realizar una consulta simple de al menos dos Entidades diferentes que no sea Regiones,
             * y mostrar esta información de alguna manera.*/

            TerritoriosLogica territorios = new TerritoriosLogica();
          
            /*5)Hacer un Insert, Update, Delete.*/

               //INSERT (Territories)

               territorios.RefrescarLista(territorios); //Metodo para mostrar la lista
                Console.WriteLine("\n");
                Console.WriteLine("Lista con Insert\n");
                territorios.Add(new Territories
                  {
                      TerritoryID = "123",
                      TerritoryDescription = "Es un territorio lindo",
                      RegionID = 3
                  });

                territorios.RefrescarLista(territorios);

                //UPDATE (territories)

                territorios.RefrescarLista(territorios); 
                  Console.WriteLine("\n");

                  Console.WriteLine("Lista con Update\n");

                  territorios.Update(new Territories
                   {  TerritoryDescription= "Soy un territorio y tengo nueva descripción",
                       TerritoryID = "123",
                       RegionID = 3
                                       });
                       Console.WriteLine("\n");
                       territorios.RefrescarLista(territorios); 

               //DElETE (territories)

                  territorios.RefrescarLista(territorios);
                  Console.WriteLine("\n");

                  Console.WriteLine("Lista con Delete\n");
                  territorios.Delete("123");
                  territorios.RefrescarLista(territorios);

            //ADD(PRODUCT)
            ProductosLogica productos = new ProductosLogica();

            productos.RefrescarLista(productos);
            Console.WriteLine("\n");

            Console.WriteLine("Lista con Insert (PRODUCTOS)\n");
            productos.Add(new Products
            {

                ProductName = "Hamburguejas al vapor",
                SupplierID = 12,
                CategoryID = 2,
                UnitPrice = 20,
                UnitsInStock = 70,
                UnitsOnOrder = 0,
                ReorderLevel = 25,
                QuantityPerUnit = "12 a 16 hamburguejas",
                Discontinued = false,

            });

            productos.RefrescarLista(productos);

            //UPDATE(PRODUCTS)

              productos.RefrescarLista(productos);
              Console.WriteLine("\n");

              Console.WriteLine("Lista con Update\n");

              productos.Update(new Products
              {
                  ProductName= "Hamburguejas al vapor", 
                  UnitPrice= 200,
                  ProductID= 9
              });
              Console.WriteLine("\n");
              productos.RefrescarLista(productos);   

             //DELETE (PRODUCTS)

             productos.RefrescarLista(productos);
             Console.WriteLine("\n");

             Console.WriteLine("Lista con Delete (PRODUCTOS)\n");
             productos.Delete(80);
             productos.RefrescarLista(productos);

        }


}
}
