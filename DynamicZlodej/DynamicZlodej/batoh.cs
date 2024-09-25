using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicZlodej
{
    class Obchod
    {
        public Sperk[] sperkyVObchode;
        public int batohSize;
        private Random rd;
        private string[] sperky;

        public Obchod(int maxValue, int maxSize, int bagSize, int numOfVals)
        {
            sperky = new string[] {
            "Prsten",
    "Náhrdelník",
    "Náramek",
    "Náušnice",
    "Brož",
    "Přívěsek",
    "Řetízek",
    "Korále",
    "Manžetové knoflíky",
    "Diadém",
    "Koruna",
    "Čelenka",
    "Snubní prsten",
    "Zásnubní prsten",
    "Pečetní prsten"};


            rd = new Random();
            batohSize = bagSize;

            sperkyVObchode = new Sperk[numOfVals];


            for (int i = 0; i < numOfVals; i++)
                sperkyVObchode[i] = new Sperk(maxValue, maxSize, rd, sperky);
        }
    }
}
