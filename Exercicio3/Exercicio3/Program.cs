using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 0;
            double horas = 0;
            double valorHora = 0;
            double salarioBruto = 0;
            double salarioReceber = 0;
            double imposto = 0.03;

            Console.WriteLine("Digite o salário minimo: ");
            salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite as horas trabalhadas: ");
            horas = double.Parse(Console.ReadLine());

            valorHora = (salario * 0.1);
            salarioBruto = (valorHora * horas);

            salarioReceber = (salarioBruto - (salarioBruto * imposto));

            Console.Write("Salario a receber: " + salarioReceber + "\n");

            Console.ReadKey();
        }
    }
}
