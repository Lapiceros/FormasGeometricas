using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas.Models
{
    internal class Cuadrado : Rectangulo
    {
        public Cuadrado(int lado) : base (lado, lado) 
        { 
            _ladoX = lado;
        }

        public override string ToString()
        {
            return $"Las propiedades del cuadrado son: tamaño de los lados: {_ladoX:F2} | Area: {GetArea():F2} | Perimetro: {GetPerimeter():F2}";
        }
    }
}
