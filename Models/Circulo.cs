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


        public override double GetArea()
        {
            return (Math.PI * RadioX*2)/2;
            
        }

        public override double GetPerimeter()
        {
           return 2 * RadioX * Math.PI;
            
        }

        public override string ToString()
        {
            return $"El radio del circulo es {RadioX:F2} | Area: {GetArea():F2} | Perimetro: {GetPerimeter():F2}";
        }
    }
}
