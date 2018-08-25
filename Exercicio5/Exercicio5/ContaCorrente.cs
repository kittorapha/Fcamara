using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class ContaCorrente
    {
        public String Nome { get; set; }
        public double Saldo { get; set; }
        public int Conta { get; set; }

        public void AlterarNome(string nomeNovo)
        {
            this.Nome = nomeNovo;
        }

        public void Deposito(double valor)
        {
            this.Saldo += valor;
        }

        public void Saque(double valor)
        {
            this.Saldo -= valor;
        }
    }
}
