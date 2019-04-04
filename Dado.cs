using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerpientesyEscaleras
{
    class Dado
    {
        private static Random ran = new Random();
        public int Lanzar()
        {
            int a = ran.Next(1, 7);
            return a;
        }
        
    }
}
