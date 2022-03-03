using System;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a quilometragem percorrida: ");
            //double kmPercorrido = Convert.ToDouble(Console.ReadLine());
            decimal.TryParse(Console.ReadLine(), out decimal kmPercorrido);

            Console.WriteLine("Informe a quantidade de litros gastos no trajeto: ");

            decimal.TryParse(Console.ReadLine(), out decimal litrosGastos);
            //double litrosGastos = Convert.ToDouble(Console.ReadLine());

            decimal mediaLitros = kmPercorrido / litrosGastos;

            Console.WriteLine($"Valor da média:  { mediaLitros}");

        }
    }
}
