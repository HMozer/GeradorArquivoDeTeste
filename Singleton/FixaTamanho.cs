using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorArquivoDeTeste.Singleton
{
    public static class FixaTamanho
    {
        public static string retornaStringTamanhoFixo(string valorASerFixado, int tamanhoString, char preenchimento = '0')
        {
            return valorASerFixado.PadLeft(tamanhoString, preenchimento);
        }
    }
}
