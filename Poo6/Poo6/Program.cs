using System;
using System.Globalization;

namespace Poo6
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nFuncionário: " + f.Nome + ", R$ " + f.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));

            Console.Write("\nDigite a porcentagem para aumentar o salario: ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarSalario(porcent);

            Console.WriteLine("\nDados atualizados: " + f.Nome + ", R$ " + f.SalarioBruto.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
