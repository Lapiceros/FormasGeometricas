using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas.Models
{
    internal class Diagrama
    {
        private List<Forma> _formas;
        private static Random _random = new Random();
        public List<Forma> Formas { get { return _formas; } }

        public Diagrama()
        {
            _formas = new List<Forma>();
            int cantidadFormas = _random.Next(1, 10);
            for (int i = 0; i < cantidadFormas; i++)
            {
                _formas.Add(GenerarFormas());
            }
        }
       
        private Forma GenerarFormas()
        {
            int tipoForma = _random.Next(5);
            switch (tipoForma)
            {
                case 0: return new Cuadrado(_random.Next(1, 10));
                case 1: return new Rectangulo(_random.Next(1, 10), _random.Next(1, 10));
                case 2: return new Circulo(_random.Next(1, 10));
                case 3: return new Elipse(_random.Next(1, 10), _random.Next(1, 10));
                case 4: return new Triangulo(_random.Next(1, 10));
                default: throw new Exception("Tipo de forma desconocido");
            }
        }
        
        private double GetTotal(Func<Forma, double> selector)
        {
            return _formas.Sum(selector);
        }
        public double GetAreaTotal() => GetTotal(f => f.GetArea());

        public double GetPerimetroTotal() => GetTotal(f => f.GetPerimeter());
       
        public override string ToString()
        {
            foreach (var item in _formas)
            {
                Console.WriteLine($"{item.ToString()}");
            }
            return $"El area total del diagrama es: {GetAreaTotal():F2} | perimetro total: {GetPerimetroTotal():F2}";
        }



    }
}
