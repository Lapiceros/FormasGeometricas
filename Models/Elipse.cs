using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas.Models
{
    internal class Elipse : Forma
    {
        private int _radioY;
        private int _radioX;

        protected double _area;
        protected double _perimeter;
        public int RadioY { get { return _radioY; } set { _radioY = value; } }
        public int RadioX { get { return _radioX; } set { _radioX = value; } }
        public double Area { get => _area; }
        public double Perimeter { get => _perimeter; }

        public Elipse(int radioY, int radioX) 
        {
            RadioX = radioX;
            RadioY = radioY;
            CalculateArea();
            CalculatePerimeter();
        }

        public virtual double CalculateArea()
        {
            _area = Math.PI * RadioX * RadioY;
            return _area;
        }

        public virtual double CalculatePerimeter()
        {
             _perimeter = Math.PI*(3*(RadioY + RadioX) - Math.Sqrt((3 * RadioY + RadioX) * (RadioY + RadioX * 3)));
            return _perimeter;
        }

        public override string ToString()
        {
            return $"los radios de la elipse son Radio 1:{RadioX} | Radio 2: {RadioY} | Area: {Area:F2} | Perimetro:{Perimeter:F2}";
        }
    }
}
