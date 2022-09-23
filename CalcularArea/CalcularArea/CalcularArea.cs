using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalcularArea
{
    public class CalcularArea
    {
        public decimal num1 { get; set; }
        public decimal num2 { get; set; }
        public decimal Cuadrado()
        {
            return num1 * num2;
        }
        public decimal Triangulo(decimal n1, decimal n2)
        {
            num1 = n1;
            num2 = n2;
            return num1 * num2 / 2;
        }
        public decimal Circulo(double n1)
        {
            num1 = (decimal)(double)n1;
            double var;
            double pi = 3.141592;
            var = pi * (n1 * n1);
            return (decimal)var;
        }
    }
}