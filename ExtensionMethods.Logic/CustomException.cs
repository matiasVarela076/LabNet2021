using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3Exceptions
{
    public class CustomException: Exception
    {
        public CustomException() : base("Custom Exception realizada por Matías Varela")
        {

        }
    }
}

