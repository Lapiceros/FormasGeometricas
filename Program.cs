using FormasGeometricas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circulo circle = new Circulo(7);
            Console.WriteLine(circle.ToString());
           
            Console.ReadKey();
        }
    }
}
