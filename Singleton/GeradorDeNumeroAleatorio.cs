using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorArquivoDeTeste.Singleton
{
    public class GeradorDeNumeroAleatorio
    {
        private static readonly Random getrandom = new Random();

        public static int Gerar(int min, int max)
        {
            lock (getrandom) // synchronize
            {
                return getrandom.Next(min, max + 1);
            }
        }
    }
}