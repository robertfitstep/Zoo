using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Macka Zofka = new Macka("Žofka", 3, true, 3.1F);
            Zofka.VydajZvuk();

            Pes Rex = new Pes("Rex", 4, true, 25.7F);
            Rex.VydajZvuk();

            Console.ReadLine();
        }
    }
}
