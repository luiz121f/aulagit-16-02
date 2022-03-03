using System;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a quilometragem percorrida: ");
            double kmPercorrido = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de litros gastos no trajeto: ");
            double litrosGastos = Convert.ToDouble(Console.ReadLine());

            double mediaLitros = kmPercorrido / litrosGastos;

            Console.WriteLine($"Valor da média:  { mediaLitros}");

        }
    }
}
