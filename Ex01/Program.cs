using System;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um valor em real a ser convertido: ");
            string val = Console.ReadLine();
            decimal convertido = 0.0m;
            decimal cambio = 0.193259m;

            decimal.TryParse(val, out convertido);

            decimal cambioConvertido = cambio * convertido;

            Console.WriteLine($"Valor convertido {cambioConvertido}");

            Console.ReadLine();
        }
    }
}
