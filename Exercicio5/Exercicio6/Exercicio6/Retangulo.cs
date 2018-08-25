using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    class Retangulo
    {
        public double Largura{ get; set; }
        public double Comprimento{ get; set; }
        public double Area{ get; set; }
        public double Perimetro{ get; set; }
        public double Piso { get; set; }
        public double Rodape { get; set; }

        public void MudarLados(double larguraNovo, double comprimentoNovo)
        {
            this.Largura = larguraNovo;
            this.Comprimento = comprimentoNovo;
        }

        public void RetornarLados(double largura, double comprimento)
        {
            this.Largura = largura;
            this.Comprimento = comprimento;
        }

        public void CalculoArea(double largura, double comprimento)
        {
            this.Area = (largura * comprimento);
        }

        public void CalculoPerimetro(double largura, double comprimento)
        {
            this.Perimetro = (largura + comprimento) * 2;
        }

        public void CalculoPiso(double largura, double comprimento)
        {
            this.Piso = Convert.ToInt32((largura * comprimento) / (Largura * Comprimento));
        }

        public void CalculoRodape(double larguraLocal)
        {
            this.Rodape = Convert.ToInt32((2 * larguraLocal) / ((2 * Largura)/100));
        }
    }
}
