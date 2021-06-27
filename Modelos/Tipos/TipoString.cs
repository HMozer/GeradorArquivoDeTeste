using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeradorArquivoDeTeste.Singleton;

namespace GeradorArquivoDeTeste.Modelos.Tipos
{
    class Tipostring : Tipo
    {
        private string Caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        private int TamanhoString;
        
        public Tipostring(string nome, int tamanho) : base(nome)
        {
            VerificarTamanhoDaString(tamanho);
            TamanhoString = tamanho;
        }

        public override string GerarValorAleatorio()
        {
            string valorAleatorio = "";
            int tamanhoDaListagemDeCaracteres = Caracteres.Length - 2;

            for (int i = 0; i < TamanhoString; ++i)
            {
                int posicao = GeradorDeNumeroAleatorio.Gerar(0, tamanhoDaListagemDeCaracteres);
                valorAleatorio += RetornarNovoCaractere(posicao);
            }

            return valorAleatorio;
        }

        private string RetornarNovoCaractere(int posicao)
        {
            return Caracteres.Substring(posicao, 1);
        }

        private void VerificarTamanhoDaString(int tamanho)
        {
            if (tamanho <= 0)
                throw new ArgumentException("O tamanho da string não pode ser menor ou igual a 0 (zero).");
        }
    }
}