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
        ProductosLogica logic = new ProductosLogica();
        // GET: Territories
        public ActionResult Index()
        {
            List<Products> producto = logic.GetAll(); //Traemos la entidad territories
            List<ProductsView> productsViews = producto.Select(t => new ProductsView
            {
                ID = t.ProductID,//traigo de la entidad lo que necesito y lo asigno a el view de territorio
                nombreProdu = t.ProductName,
                precio = t.UnitPrice

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
                Products ProductsEntity = new Products
                {
                      //a la entidad le seteo los parametros del view
                    ProductName = produView.nombreProdu,
                    UnitPrice = produView.precio
                };

                logic.Add(ProductsEntity);  //Lo agrego

                return RedirectToAction("Index", "Products"); // vuelve al index para mostrar el nuevo campo
            }
            catch (Exception)
            {

                return RedirectToAction("Index", "Error");
            }
        }
     
        public ActionResult Delete(int id)
        {
            logic.Delete(id); //Borramos el ID

            return RedirectToAction("Index"); //Una ves terminado vuelva a la pagina principal
        }
    }
}