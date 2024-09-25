using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicZlodej
{
    struct Sperk
    {
        private string _name { get; }
        public int value { get; }
        public int space { get; }

        public Sperk(int maxValue, int maxSpace, Random random, string[] namesJ)
        {
            this.value = random.Next(maxValue - 1) + 1;
            this.space = random.Next(maxSpace - 1) + 1;

            this._name = namesJ[random.Next(namesJ.Length - 1)];
        }

        public override string ToString() =>
            $"{this._name}: ({this.value}; {this.space})";
    }
}
