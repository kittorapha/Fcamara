using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroInicial, numeroFinal;
            string resultado;

            Console.WriteLine("Introduza o número inicial: ");
            numeroInicial = int.Parse(Console.ReadLine());

            if (numeroInicial < 0)
            {
                Console.Write("Numero inicial menor que 0");
            }
            else
                Console.WriteLine("Introduza o número final: ");
            numeroFinal = int.Parse(Console.ReadLine());

            if (numeroFinal < numeroInicial)
            {
                Console.Write("Numero final menor que numero inicial");
            }
            else

                for (int i = numeroInicial; i < numeroFinal; i++)
                {
                    if (i % 2 == 1)
                    {
                        resultado = Convert.ToString(i);
                        Console.Write(resultado + " ");
                    }

                }

            Console.ReadKey();

        }
    }
}
