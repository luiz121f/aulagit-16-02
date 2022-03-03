using System;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um valor em dólar a ser convertido: ");
            string val = Console.ReadLine();
            decimal convertido = 0.00m;
            decimal cambio = 5.22m;

            decimal.TryParse(val, out convertido);

            decimal cambioConvertido = cambio * convertido;

            Console.WriteLine($"Valor convertido {cambioConvertido}");

            Console.ReadLine();
        }
    }
}
