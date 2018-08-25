using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 1000;
            double salarioFinal = 0;
            double aumento = 1.50;
            int anoInicial = 2006;
            int anoFinal = 2018;



            while (anoInicial < anoFinal)
            {
                salarioFinal = salario + (salario * aumento / 100);
                aumento = aumento * 2;
                anoInicial++;
            }

            Console.Write("Salario final: " + salarioFinal + "\n");

            Console.ReadKey();
        }
    }
}
