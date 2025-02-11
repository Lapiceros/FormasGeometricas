using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas.Models
{
    internal class Circulo : Elipse
    {
        public Circulo(int radio) : base(radio, radio) 
        { 
            RadioX = radio;

        }


        public override double CalculateArea()
        {
            return (Math.PI * RadioX*2)/2;
            
        }

        public override double CalculatePerimeter()
        {
           return 2 * RadioX * Math.PI;
            
        }

        public override string ToString()
        {
            return $"El radio del circulo es {RadioX:F2} | Area: {CalculateArea():F2} | Perimetro: {CalculatePerimeter():F2}";
        }
    }
}
