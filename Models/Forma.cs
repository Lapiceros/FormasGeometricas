using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas.Models
{
    internal abstract class Forma
    {
        protected double _area;
        protected double _perimeter;
        public double Area { get => _area; }
        public double Perimeter { get => _perimeter; }

        public abstract double GetArea();
        public abstract double GetPerimeter();
    }
}
