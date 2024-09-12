using System;
using PrincipiosDiseño;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosDiseño
{
    public class CalcularArea
    {
        public double CalcularAreaCuadrado(double lado)
        {
            return lado * lado;
        }

        public double CalcularAreaCirculo(double radio)
        {
            return Math.PI * radio * radio;
        }

    }
    public class Circulo
    {
        public double Radio { get; set; }

        private CalcularArea _calcularArea;

        public Circulo(double radio, CalcularArea calcularArea)
        {
            Radio = radio;
            _calcularArea = calcularArea;
        }

        // Método para calcular el área utilizando CalcularArea

        public double CalcularArea()
        {
            return _calcularArea.CalcularAreaCirculo(Radio);
        }
    }
    public class Cuadrado
    {
        public double Lado { get; set; }

        private CalcularArea _calcularArea;

        public Cuadrado(double lado, CalcularArea calcularArea)
        {
            Lado = lado;
            _calcularArea = calcularArea;
        }

        // Método para calcular el área utilizando CalcularArea

        public double CalcularArea()
        {
            return _calcularArea.CalcularAreaCuadrado(Lado);
        }


    }

  

}
