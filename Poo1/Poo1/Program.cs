using System;
using System.Globalization;

namespace Poo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            double p, areaX, areaY;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            x.ladoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.ladoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.ladoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            y.ladoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.ladoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.ladoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            p = (x.ladoA + x.ladoB + x.ladoC) / 2.0;
            areaX = Math.Sqrt(p * (p - x.ladoA) * (p - x.ladoB) * (p - x.ladoC));

            p = (y.ladoA + y.ladoB + y.ladoC) / 2.0;
            areaY = Math.Sqrt(p * (p - y.ladoA) * (p - y.ladoB) * (p - y.ladoC));

            Console.WriteLine("Área de X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }
    }
}
