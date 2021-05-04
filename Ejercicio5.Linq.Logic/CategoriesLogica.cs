using Ejercicio5.Linq.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.Linq.Logic
{
    public class CategoriesLogica : BaseLogica, IABMLogica<Categories>
    {
   
        public List<Categories> GetAll()
        {
            return context.Categories.ToList();
        }
        public void ListaCategorias(IEnumerable<Categories>  query)
        {
            foreach (var item in query)
            {
                Console.WriteLine($"ID- {item.CategoryID} - Nombre- {item.CategoryName} ");
            }
            Console.ReadLine();
        }
    }
}
