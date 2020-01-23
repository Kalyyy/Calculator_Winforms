using System;

namespace Clases
{
    public class Operaciones
    {
        //atributos
        private Double primerNumero = 0;
        private Double segundoNumero = 0;
        private String operador;

        //propiedades
        public double PrimerNumero { get => primerNumero; set => primerNumero = value; }
        public double SegundoNumero { get => segundoNumero; set => segundoNumero = value; }
        public string Operador { get => operador; set => operador = value; }

        //Operaciones
        public double Sumar(double n1, double n2)
        {
            double suma;
            suma = n1 + n2;
            return suma;
        }
        public double Restar(double n1, double n2)
        {
            double resta;
            resta = n1 - n2;
            return resta;
        }
        public double Multiplicar(double n1, double n2)
        {
            double multi;
            multi = n1 * n2;
            return multi;
        }
        public double Dividir(double n1, double n2)
        {
            double dividir;
            dividir = n1 / n2;
            return dividir;
        }

    }
}
