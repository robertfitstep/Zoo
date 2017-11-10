using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    class Pes : Zviera
    {
        public Pes(string meno, int vek, bool chvost, float vaha) : base(meno, vek, chvost, vaha)
        {

        }

        public new void VydajZvuk()
        {
            Console.WriteLine("Haf");
        }
    }
}
