using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    class Zviera
    {
        private string meno;
        private int vek;
        private bool chvost;
        private float vyska;

        public Zviera(string meno, int vek, bool chvost, float vaha)
        {
            this.meno = meno;
            this.vek = vek;
            this.chvost = chvost;
            this.vyska = vaha;
        }

        public void VydajZvuk()
        {
            Console.WriteLine("Toto je obecný zvuk zvieraťa.");
        }
    }
}
