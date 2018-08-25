using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeCorrentista;
            int conta;
            double saldo;
            int transacao;
            string nomeNovo;
            double valorDeposito;
            double valorSaque;



            ContaCorrente novaConta = new ContaCorrente();


            Console.WriteLine("Digite o nome do correntista: ");
            nomeCorrentista = Console.ReadLine();


            Console.WriteLine("Digite o numero da conta: ");
            conta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o saldo: ");
            saldo = double.Parse(Console.ReadLine());


            novaConta.Nome = nomeCorrentista;
            novaConta.Saldo = saldo;
            novaConta.Conta = conta;


            Console.WriteLine("1 - Alterar Nome / 2 - Depositar / 3 - Sacar ");
            transacao = int.Parse(Console.ReadLine());

            if (transacao == 1)
            {
                Console.WriteLine("Digite o novo nome: ");
                nomeNovo = Console.ReadLine();

                novaConta.AlterarNome(nomeNovo);

                Console.WriteLine("Nome: " + novaConta.Nome);
                Console.WriteLine("Conta: " + novaConta.Conta);
                Console.WriteLine("Saldo: " +novaConta.Saldo);

            }
            else
            {
                if (transacao == 2)
                {
                    Console.WriteLine("Digite o valor para deposito: ");
                    valorDeposito = double.Parse(Console.ReadLine());

                    novaConta.Deposito(valorDeposito);

                    Console.WriteLine("Nome: " + novaConta.Nome);
                    Console.WriteLine("Conta: " + novaConta.Conta);
                    Console.WriteLine("Saldo: " + novaConta.Saldo);
                }
                else
                {
                    if (transacao == 3)
                    {
                        Console.WriteLine("Digite o valor para saque: ");
                        valorSaque = double.Parse(Console.ReadLine());

                        novaConta.Saque(valorSaque);

                        Console.WriteLine("Nome: " + novaConta.Nome);
                        Console.WriteLine("Conta: " + novaConta.Conta);
                        Console.WriteLine("Saldo: " + novaConta.Saldo);
                    }
                }
            }



            Console.ReadKey();
        }
    }
}
