using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerpientesyEscaleras
{
    class Jugador: Tablero
    {
        private int _posicion;
        private string _nomjug;
        public int posicion
        {
            get { return _posicion; }
        }
        public string  nomjug
        {
            get { return _nomjug; }
        }
        public Jugador(string nom)
        {
            _nomjug = nom;
            _posicion = 0;
        }
        public void avanzar(int random)
        {
            _posicion += random;
            if(_posicion > 100)
            {
                _posicion = 100;
            }
            else
            {
                _posicion += vec[_posicion];
            }
        }
    }
}
