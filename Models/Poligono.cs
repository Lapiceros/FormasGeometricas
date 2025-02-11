using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas.Models
{
    internal class Poligono : Forma
    {
        private int _numeroLados;

        public int NumeroLados { get { return _numeroLados; } }

        public Poligono(int lados)
        {
            _numeroLados = lados;
            
        }
    }
}
