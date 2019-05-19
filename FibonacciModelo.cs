using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class FibonacciModelo
    {

  
        public void Datos(int numero)
        {           
            
           
            int a = 0; int b = 1; int c;

            for (int i = 0; i < numero; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.Write(a + ",");

            }

 

        }

    }
    
}
