using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class MassivVKvadrate
    {
        private int[] massiv;

        public MassivVKvadrate(int size)
        {
            massiv = new int[size];
        }

        public int this[int i]
        {
            get { return massiv[i]; }
            set { massiv[i] = value*value; }
        }
    }
}
