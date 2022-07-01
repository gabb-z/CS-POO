using System;
using System.Globalization;

namespace Poo7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a cotação do dólar: ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quanto dólares deseja comprar: ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = ConversorDeMoeda.DolarParaReal(quantidade, cotacao);

            Console.WriteLine("Valor a ser pago em reais: R$ " + resultado.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
