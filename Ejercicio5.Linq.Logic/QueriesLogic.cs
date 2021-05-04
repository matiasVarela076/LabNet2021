using Ejercicio4.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.Linq.Logic
{
   public class QueriesLogic : BaseLogica
    {
        ProductosLogica productos = new ProductosLogica();
        CustomersLogica clientes = new CustomersLogica();
        OrdersLogica ordenes = new OrdersLogica();
        CategoriesLogica categoria = new CategoriesLogica();


        var query1 = clientes.GetAll();
    }
}
