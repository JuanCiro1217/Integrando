using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NachoOperaApp;

namespace Integrando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Presione ENTER para observar los demas resultados");

            long sma;
            sma = NachoOperaApp.Class1.sumar(10, 2);
            Console.WriteLine(sma.ToString());
            Console.ReadKey();

            long rta;
            rta = NachoOperaApp.Class1.restar(10, 2);
            Console.WriteLine(rta.ToString());
            Console.ReadKey();

            long mtl;
            mtl = NachoOperaApp.Class1.multiplicar(10, 2);
            Console.WriteLine(mtl.ToString());
            Console.ReadKey();

            long dvd;
            dvd = NachoOperaApp.Class1.dvidir(10, 2);
            Console.WriteLine(dvd.ToString());
            Console.ReadKey();
        }
    }
}
