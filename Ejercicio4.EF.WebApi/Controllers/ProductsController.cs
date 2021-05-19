
using Ejercicio4.EF.Entities;
using Ejercicio4.EF.Logic;
using Ejercicio4.EF.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Ejercicio4.EF.WebAPI.Controllers
{
 
    public class ProductsController : Controller
    {
        ProductosLogica logic = new ProductosLogica();
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }
         
        // GET: api/Products
        public List<ProductsView> GetProducts()
        {
      
            List<Products> productos = logic.GetAll();

            List<ProductsView> listaProductos = productos.Select(p => new ProductsView
            {
                ID = p.ProductID,
                NombreProdu = p.ProductName,
                Precio = p.UnitPrice

            }).ToList();

            return listaProductos;
        }

        // GET: api/Products/5

        public void GetProducts(int id)
        {
            Products products = logic.BuscarProdu(id);
            var view = new ProductsView();

            view.ID = products.ProductID;
            view.NombreProdu = products.ProductName;
            view.Precio = products.UnitPrice;
            
        }

        // PUT: api/Products/5

        public void PutProducts(Products productsView)
        {

            Products ProductsEntity = new Products
            {
                ProductID = productsView.ProductID,
                ProductName = productsView.ProductName,
                UnitPrice = productsView.UnitPrice
            };

            logic.Update(ProductsEntity);
   
        }

        // POST: api/Products

        public void PostProducts(ProductsView productsView)
        {
           
            Products productsEntity = new Products
            {
                CategoryID = productsView.ID,
                ProductName = productsView.NombreProdu,
                UnitPrice = productsView.Precio


            };
            logic.Add(productsEntity);

            
        }

        // DELETE: api/Products/5
        public void DeleteProducts(int id)
        {

            logic.Delete(id);
        }
    }
}