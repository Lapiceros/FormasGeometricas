using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas.Models
{
    internal class Triangulo : Poligono
    {
        private int _lado;
        public Triangulo(int lado)
        { 
            _numeroLados = 3;
            _lado = lado;
        }

        public override double GetArea()
        {
            double altura = (Math.Sqrt(3) / 2) * _lado;
            return _lado * altura / 2;
        }

        public override double GetPerimeter()
        {
            return _lado * 3;
        }

        public override string ToString()
        {
            return $"Las propiedades del triangulo son: tamaño de los lados: {_lado} | Area: {GetArea():F2} | Perimetro: {GetPerimeter():F2}";
        }
    }
}
