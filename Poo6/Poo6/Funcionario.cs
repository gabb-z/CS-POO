using System;
using System.Globalization;

namespace Poo6
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += ((10 * SalarioBruto) / 100) - Imposto;
        }
    }
}
