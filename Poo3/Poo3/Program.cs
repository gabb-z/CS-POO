using System;
using System.Globalization;

namespace Poo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1, f2;
            double salarioMedio;

            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("Dados do 1º funcionário:");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do 2º funcionário:");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salarioMedio = (f1.Salario + f2.Salario) / 2.0;

            Console.WriteLine("Salario médio: R$ " + salarioMedio.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
