using Ejercicio5.Linq.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.Linq.Logic
{
    public class OrdersLogica : BaseLogica, IABMLogica<Orders>
    {
     

        public List<Orders> GetAll()
        {
            return context.Orders.ToList();
        }

        public void ListaOrdenes(IEnumerable<Orders> query)
        {
            foreach (var item in query)
            {
                Console.WriteLine($"Id- {item.OrderID} - Nombre- {item.OrderDate}");
            }
            Console.ReadLine();
        }
    }
}
