using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorArquivoDeTeste.Modelos.Regras
{
    public abstract class Regra
    {
        public string Nome { get; }

        public Regra(string nome)
        {
            Nome = nome;
        }

        public abstract string GeraAleatorio();
    }
}
