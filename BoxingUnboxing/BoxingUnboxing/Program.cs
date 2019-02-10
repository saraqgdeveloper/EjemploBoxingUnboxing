using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejemplo de Boxing (Implícito)

            int numero = 40;
            object obj = numero;       
            
            //Ejemplo de Unboxing (Explícito)

            int i = (int)obj;

        }
    }
}
