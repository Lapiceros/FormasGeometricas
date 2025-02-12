using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas.Models
{
    internal class Rectangulo : Poligono
    {
        protected double _ladoX;
        protected double _ladoY;
        public Rectangulo(int ladoX, int ladoY) 
        { 
            _numeroLados = 4;
            _ladoX = ladoX;
            _ladoY = ladoY;
        }
        public override double GetArea()
        {
            return _ladoX * _ladoY;
        }

        public override double GetPerimeter()
        {
            return 2*(_ladoX + _ladoY);
        }

        public override string ToString()
        {
            return $"Las propiedades del rectangulo son ladoX: {_ladoX} ladoY:{_ladoY} | Area: {GetArea():F2} | Perimetro: {GetPerimeter():F2}";
        }
    }
}
