using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Unidimensional U = new Unidimensional(2.7);
            Bidimensional  B = new Bidimensional(3.1, 7.3);
            Tridimensional T = new Tridimensional(1.1, 2.2, 3.3);

            Console.WriteLine(U.imprimir());
            Console.WriteLine(B.imprimir());
            Console.WriteLine(T.imprimir());

            Console.ReadKey();
        }
    }
}
