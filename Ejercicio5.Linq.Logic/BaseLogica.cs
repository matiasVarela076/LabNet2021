using Ejercicio5.Linq.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.Linq.Logic
{
    public class BaseLogica
    {
        protected readonly NorthwindContext context;

        public BaseLogica()
        {
            context = new NorthwindContext();
        }

    }
}
