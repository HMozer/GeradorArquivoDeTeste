using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeradorArquivoDeTeste.Singleton;

namespace GeradorArquivoDeTeste.Modelos.Regras
{
    public class RegraData : Regra
    {
        public string Mascara { get; }
        public bool AnoCorrente { get; }

        private const int LimiteMaximoAno = 100;
        private int AnoMin = 1970;
        private int AnoMax = DateTime.Now.Year + LimiteMaximoAno;

        private const int ValorMinimoDiaEMes = 1;
        private int MesMax = 12;
        private int DiaMax = 31;

        public RegraData(string nome, string mascara, bool anoCorrente = true, int anoMin = 0, int anoMax = 0) : base(nome)
        {
            VerificaLimiteMinimoDoAno(anoMin);

            Mascara = mascara;
            AnoCorrente = anoCorrente;

            AnoMin = RetornaAnoSeDefinido(anoMin, AnoMin);
            AnoMax = RetornaAnoSeDefinido(anoMax, AnoMax);
        }

        public override string GeraAleatorio()
        {
            string ano = GeraAnoAleatorio();
            string mes = GeraMesAleatorio();
            string dia = GeraDiaAleatorio(int.Parse(ano), int.Parse(mes));

            string dataAleatoria = Mascara.Replace("AAAA", ano) +
                    Mascara.Replace("MM", mes) +
                    Mascara.Replace("DD", dia);

            return dataAleatoria;
        }

        private string GeraDiaAleatorio(int ano, int mes)
        {
            DefineDiaMaximo(ano, mes);
            int diaAleatorio = GeradorDeNumeroAleatorio.GeraNumeroAleatorio(ValorMinimoDiaEMes, DiaMax);

            return FixaTamanho.retornaStringTamanhoFixo(diaAleatorio.ToString(), 2);
        }

        private void DefineDiaMaximo(int ano, int mes)
        {
            DiaMax = DateTime.DaysInMonth(ano, mes);
        }

        private string GeraMesAleatorio()
        {
            int mesAleatorio = GeradorDeNumeroAleatorio.GeraNumeroAleatorio(ValorMinimoDiaEMes, MesMax);
            return FixaTamanho.retornaStringTamanhoFixo(mesAleatorio.ToString(), 2);
        }

        private string GeraAnoAleatorio()
        {
            return GeradorDeNumeroAleatorio.GeraNumeroAleatorio(AnoMin, AnoMax).ToString();
        }

        private int RetornaAnoSeDefinido(int anoLimite, int valorDeAnoFixo)
        {
            if (anoLimite == 0)
                return valorDeAnoFixo;

            return anoLimite;
        }

        private bool VerificaLimiteMinimoDoAno(int anoMin)
        {
            if (anoMin < 1900)
                throw new Exception("O valor do ano mínimo não pode ser menor que 1900");

            return false;
        }
    }
}