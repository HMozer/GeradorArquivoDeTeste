using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GeradorArquivoDeTeste.Singleton;

namespace GeradorArquivoDeTeste.Modelos.Tipos
{
    class TipoDecimal : Tipo
    {
        private int QteCasasInteiro;
        private int QteCasasDecimais;
        private int EspacoDoSeparador = 1;
        private char SeparadorDecimal;

        public TipoDecimal(string nome, int tamanho, int qteCasasDecimais, char separadorDecimal = ',') : base(nome)
        {
            ValidarParametros(tamanho, qteCasasDecimais);

            QteCasasInteiro = tamanho - qteCasasDecimais - EspacoDoSeparador;
            QteCasasDecimais = qteCasasDecimais;
            SeparadorDecimal = separadorDecimal;
        }

        public override string GerarValorAleatorio()
        {
            string valorAleatorioInteiro = DefinirValorAleatorio(QteCasasInteiro);
            string valorAleatorioDecimal = DefinirValorAleatorio(QteCasasDecimais);

            return valorAleatorioInteiro + SeparadorDecimal + valorAleatorioDecimal;
        }

        private void ValidarParametros(int tamanho, int qteCasasDecimais)
        {
            if (!ValidarSeNumeroEPositivo(tamanho))
                throw new ArgumentException("O tamanho deve ser um número maior que 0(zero).");

            if (!ValidarSeNumeroEPositivo(qteCasasDecimais))
                throw new ArgumentException("A quantidade de casas decimais deve ser um número maior que 0(zero).");
        }

        private string DefinirValorAleatorio(int tamanho)
        {
            int valorMaximoPossivel = DefinirValorMaximoPeloTamanho(tamanho);
            int valorAleatorioInteiro = GeradorDeNumeroAleatorio.Gerar(0, valorMaximoPossivel);

            return FixadorDeTamanho.Fixar(valorAleatorioInteiro.ToString(), tamanho);
        }
    }
}