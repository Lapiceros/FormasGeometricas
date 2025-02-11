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
        protected int _numeroLados;

        public int NumeroLados { get { return _numeroLados; } }

        public Poligono(){}

        public override double GetArea()
        {
            throw new NotImplementedException();
        }

        public override double GetPerimeter()
        {
            throw new NotImplementedException();
        }
    }
}
