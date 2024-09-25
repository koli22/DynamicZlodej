using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicZlodej
{
    class DynamicAlg : AllAlgs
    {
        public override Sperk[] findSolPrivate(int bagSize, Sperk[] sperkyVBatohu)
        {
            int[,] table = this.createTable(sperkyVBatohu, bagSize);

            Sperk[] ret = this.backtrackValue(table, sperkyVBatohu);

            return ret;
        }

        private int[,] createTable(Sperk[] sperky, int maxBagSize)
        {
            int[,] table = new int[sperky.Length,maxBagSize];



            for (int x = 1; x < sperky.Length; x++)
            {
                for (int y = 1; y < maxBagSize; y++)
                {
                    if (sperky[x].space > y) table[x,y] = table[x-1,y]; // sperk moc velkej, beru velikost predtim

                    else
                    {
                        if (sperky[x].space <= y) { // sperk malej, vejde se 

                            if (sperky[x].value + table[x - 1, y - sperky[x].space] > table[x - 1, y]) table[x, y] = sperky[x].value + table[x - 1, y - sperky[x].space]; 
                            else table[x, y] = table[x - 1, y];
                        }
                    }
                }
            }


            return table;
        }


        private Sperk[] backtrackValue(int[,] table, Sperk[] sperky)
        {
            List<Sperk> result = new List<Sperk>();
            int pointer = table.GetLength(1) - 1;

            for (int x = table.GetLength(0) - 1; x >= 1; x--)
            {
                if (table[x,pointer] > table[x - 1, pointer])
                {
                    result.Add(sperky[x]);
                    pointer -= sperky[x].space;
                }
            }

            return result.ToArray();
        }
    }
}
