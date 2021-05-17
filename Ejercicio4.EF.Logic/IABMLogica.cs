using Ejercicio4.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.EF.Logic
{
    interface IABMLogica <T>
    {
         List<T> GetAll();
        void Add(T nuevoCampo);
        void Update(T nuevoCampo);
       
    }
}
