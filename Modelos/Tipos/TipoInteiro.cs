using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeradorArquivoDeTeste.Singleton;

namespace GeradorArquivoDeTeste.Modelos.Tipos
{
    class TipoInteiro : Tipo
    {
        private int Tamanho;

        public TipoInteiro(string nome, int tamanho) : base(nome)
        {
            ValidarParametros(tamanho);
            Tamanho = tamanho;
        }

        public override string GerarValorAleatorio()
        {
            int valorMaximoPossivel = DefinirValorMaximoPeloTamanho(Tamanho);
            int numeroAleatorio = GeradorDeNumeroAleatorio.Gerar(1, valorMaximoPossivel);

            return FixadorDeTamanho.Fixar(numeroAleatorio.ToString(), Tamanho);
        }

        private void ValidarParametros(int tamanho)
        {
            if (!ValidarSeNumeroEPositivo(tamanho))
                throw new ArgumentException("O tamanho deve ser um número maior que 0(zero).");
        }
    }
}