using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerpientesyEscaleras
{
    class Tablero
    {
        protected int[] vec;
        public Tablero()
        {
            vec = new int [101];
            for (int i = 1; i < 102; i++)
            {
                vec[i] = 0;
            }
            vec[4] = 21;
            vec[13] = 23;
            vec[33] = 16;
            vec[42] = 21;
            vec[50] = 19;
            vec[55] = 12;
            vec[62] = 29;
            vec[74] = 18;
            vec[27] = -22;
            vec[40] = -37;
            vec[54] = -23;
            vec[66] = -32;
            vec[76] = -18;
            vec[89] = -36;
            vec[99] = -48;
        }
        


    }
}
