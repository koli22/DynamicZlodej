using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicZlodej
{
    abstract class AllAlgs()
    {
        public abstract Sperk[] findSolPrivate(int bagSize, Sperk[] sperkyVBatohu);

        public void findSolution(int bagSize, Sperk[] sperkyVBatohu) {
            Sperk[] sperky = findSolPrivate(bagSize, sperkyVBatohu);

            int totalSize = 0;
            int totalValue = 0;

            foreach (Sperk s in sperky)
            {
                totalSize += s.space;
                totalValue += s.value;
            }

            if (totalSize > bagSize)
                throw new Exception("Prekrocen limit batohu");

            Console.WriteLine();
            Console.WriteLine("Hodnota | sperk");

            foreach (Sperk s in sperky)
                Console.WriteLine(s.ToString());


            Console.WriteLine($"zabrano misto: {totalSize}, hodnota: {totalValue}");
        }
    }
}
