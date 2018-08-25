using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            double tamanho = 0;
            double cobertura = 0;
            int valorTinta = 80;
            int latas = 0;

            Console.WriteLine("Informe o tamanho em metros quadrados a serem pintados: ");
            tamanho = double.Parse(Console.ReadLine());

            cobertura = (18 * 3);

            if (tamanho <= cobertura)
            {
                latas = 1;
            }
            else
            {
                latas = Convert.ToInt32(tamanho / cobertura);

                if (tamanho % cobertura != 0)
                {
                    latas = latas + 1;
                }

            }

            valorTinta = (latas * valorTinta);

            Console.Write("Latas a serem compradas: " + latas + "\n");

            Console.Write("Valor total das latas: " + valorTinta + "\n");

            Console.ReadKey();
        }
    }
}
