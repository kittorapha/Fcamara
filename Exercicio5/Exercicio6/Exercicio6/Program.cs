using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            double larguraNovo;
            double comprimentoNovo;
            double largura;
            double comprimento;
            double larguraLocal;
            double comprimentoLocal;
            int operacao;



            Retangulo calculoLocal = new Retangulo();


            Console.WriteLine("Digite em cm a largura do piso: ");
            largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite em cm o comprimento do piso: ");
            comprimento = int.Parse(Console.ReadLine());



            calculoLocal.Largura = largura;
            calculoLocal.Comprimento = comprimento;


            Console.WriteLine("1 - Mudar Lados / 2 - Retornar Lados / 3 - Calcular Área / 4 - Calular Perimetro");
            operacao = int.Parse(Console.ReadLine());


                if (operacao == 1)
                {
                    Console.WriteLine("Digite em cm a largura do piso: ");
                    larguraNovo = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite em cm o comprimento do piso: ");
                    comprimentoNovo = int.Parse(Console.ReadLine());

                    calculoLocal.MudarLados(larguraNovo, comprimentoNovo);

                }
                else
                {
                    if (operacao == 2)
                    {

                        calculoLocal.RetornarLados(largura, comprimento);

                        Console.WriteLine("Largura: " + calculoLocal.Largura);
                        Console.WriteLine("Comprimento: " + calculoLocal.Comprimento);

                    }
                    else
                    {
                        if (operacao == 3)
                        {

                            calculoLocal.CalculoArea(largura, comprimento);

                            Console.WriteLine("Area: " + calculoLocal.Area);
                        }
                        else
                        {
                            if (operacao == 4)
                            {
                                calculoLocal.CalculoPerimetro(largura, comprimento);

                                Console.WriteLine("Perimetro: " + calculoLocal.Perimetro);
                            }

                        }
                    }
                    Console.WriteLine("Digite em cm a largura do local: ");
                    larguraLocal = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite em cm o comprimento do local: ");
                    comprimentoLocal = int.Parse(Console.ReadLine());


                    calculoLocal.CalculoPiso(larguraLocal, comprimentoLocal);
                    calculoLocal.CalculoRodape(larguraLocal);


                    Console.WriteLine("Pisos a comprar: " + calculoLocal.Piso);
                    Console.WriteLine("Rodapes a comprar: " + calculoLocal.Rodape);


                
                Console.ReadKey();
            }
        }
    }
}
