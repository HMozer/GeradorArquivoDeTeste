using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeradorArquivoDeTeste.Singleton;

namespace GeradorArquivoDeTeste.Modelos.Regras
{
    class RegraInteiro : Regra
    {
        private int Tamanho;
        private int ValorMaximo;

        public RegraInteiro(string nome, int tamanho) : base(nome)
        {
            ValidarTamanhoDoInteiro(tamanho);

            Tamanho = tamanho;
            DefinirValorMaximoPeloTamanho();
        }

        public override string GerarValorAleatorio()
        {
            int numeroAleatorio = GeradorDeNumeroAleatorio.GerarNumeroAleatorio(1, ValorMaximo);
            string valorAleatorio = FixadorDeTamanho.FixarTamanho(numeroAleatorio.ToString(), Tamanho);

            return valorAleatorio;
        }

        private void DefinirValorMaximoPeloTamanho()
        {
            int tamanhoMaximo = Tamanho - 1; // Remove o primeiro valor
            string valorMaximo = "1".PadRight(tamanhoMaximo, '1');

            ValorMaximo = int.Parse(valorMaximo) * 9;
        }

        private void ValidarTamanhoDoInteiro(int tamanho)
        {
            if (tamanho <= 0)
                throw new ArgumentException("O tamanho do inteiro não pode ser menor ou igual a 0 (zero).");
        }
    }
}