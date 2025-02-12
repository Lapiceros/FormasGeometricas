using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas.Models
{
    internal class Elipse : Forma
    {
        protected double _radioY;
        protected double _radioX;

        public double RadioY { get { return _radioY; } set { _radioY = value; } }
        public double RadioX { get { return _radioX; } set { _radioX = value; } }
       

        public Elipse(double radioY, double radioX) 
        {
            RadioX = radioX;
            RadioY = radioY;
           
        }

        public override double GetArea()
        {
            return Math.PI * RadioX * RadioY;
           
        }

        public override double GetPerimeter()
        {
             return Math.PI*(3*(RadioY + RadioX) - Math.Sqrt((3 * RadioY + RadioX) * (RadioY + RadioX * 3)));
         
        }

        public override string ToString()
        {
            return $"Las propiedades de la elipse son Radio 1: {RadioX} | Radio 2: {RadioY} | Area: {GetArea():F2} | Perimetro: {GetPerimeter():F2}";
        }
    }
}
