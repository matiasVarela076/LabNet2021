using Ejercicio4.EF.Entities;
using Ejercicio4.EF.Logic;
using Ejercicio4.EF.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ejercicio4.EF.MVC.Controllers
{
    public class ProductsController : Controller
    {
        ProductosLogica logica = new ProductosLogica();
        // GET: Products
        public ActionResult Index()
        {
            List<Products> producto = logica.GetAll(); //Traemos la entidad territories
            List<ProductsView> productsViews = producto.Select(t => new ProductsView
            {
                ID = t.ProductID,//traigo de la entidad lo que necesito y lo asigno a el view de territorio
                NombreProdu = t.ProductName,
                Precio = t.UnitPrice

            }).ToList();

            return View(productsViews);
        }
        public ActionResult Insert()
        {
            return View(); 
        }

        [HttpPost]
        public ActionResult Insert(ProductsView produView)
        {
            try
            {

                if (produView.ID.Equals(null))
                {
               
                    {
                        Products ProductsEntity = new Products
                        {

                            //a la entidad le seteo los parametros del view
                            ProductName = produView.NombreProdu,
                            UnitPrice = produView.Precio
                        };

                        logica.Add(ProductsEntity);  //Lo agrego

                        return RedirectToAction("Index", "Products"); // vuelve al index para mostrar el nuevo campo
                    }
                }
                else
                {
                    Products ProductsEntity = new Products
                    {
                        ProductID = produView.ID,
                        ProductName = produView.NombreProdu,
                        UnitPrice = produView.Precio
                    };

                    logica.Update(ProductsEntity);

                    return RedirectToAction("Index", "Products");
                }

            }

            catch (Exception)
            {

                return RedirectToAction("Index", "Error");
            }
           
        }
    
     
        public ActionResult Delete(int id)
        {
            logica.Delete(id); //Borramos el ID

            return RedirectToAction("Index"); //Una ves terminado vuelva a la pagina principal
        }
    }
}