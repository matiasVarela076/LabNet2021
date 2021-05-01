using Ejercicio4.EF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.EF.Logic
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
