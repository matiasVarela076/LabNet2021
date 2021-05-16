using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercicio4.EF.MVC.Models
{
    public class ProductsView
    {
       public int ID { get; set; }
        public String NombreProdu { get; set; }
        public decimal? Precio { get; set; }

    }
}