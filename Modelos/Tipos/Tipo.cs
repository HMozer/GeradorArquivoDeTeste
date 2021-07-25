using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeradorArquivoDeTeste.Singleton;

namespace GeradorArquivoDeTeste.Modelos.Tipos
{
    public abstract class Tipo
    {
        public string Nome { get; }
        public string Descricao { get; set; }

        public Tipo(string nome)
        {
            Nome = nome;
        }

        protected int DefinirValorMaximoPeloTamanho(int tamanho)
        {
            string valorMaximo = "1".PadRight(tamanho, '1');
            return int.Parse(valorMaximo) * 9;
        }

        protected bool ValidarSeNumeroEPositivo(int numero)
        {
            if (numero > 0)
                return true;

            return false;
        }

        public abstract string GerarValorAleatorio();
    }
}