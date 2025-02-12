using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas.Models
{
    internal abstract class Poligono : Forma
    {
        protected int _numeroLados;

        public int NumeroLados { get { return _numeroLados; } }

        public Poligono(int nLados)
        {
            _numeroLados = nLados;
        }

    }
}
