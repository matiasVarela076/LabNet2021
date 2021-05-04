using Ejercicio5.Linq.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.Linq.Logic
{
    public class CustomersLogica: BaseLogica, IABMLogica<Customers>
    {
        public void UpperAndLowerCustomers(IEnumerable<Customers> query)
        {
              foreach (var item in query)
            {
                Console.WriteLine($"Mayuscula- {item.ContactName.ToUpper()} - Minuscula- {item.ContactName.ToLower()}");
            }
            Console.ReadLine();
        }

     
        public void ListaClientes(IEnumerable<Customers> query)
        {
            foreach (var item in query)
            {
                Console.WriteLine($"Id- {item.CustomerID} - Nombre- {item.ContactName}- Región: {item.Region}");
            }
            Console.ReadLine();
        }

        public List<Customers> GetAll()
        {
            return context.Customers.ToList();
        }
    }
}
