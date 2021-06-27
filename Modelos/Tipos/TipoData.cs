using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GeradorArquivoDeTeste.Singleton;

namespace GeradorArquivoDeTeste.Modelos.Tipos
{
    public class TipoData : Tipo
    {
        public string Mascara { get; }

        private int AnoMin = 1900;
        private int AnoMax = DateTime.Now.Year + 100;

        private const int ValorMinimoDiaEMes = 1;
        private const int MesMax = 12;
        private int DiaMax;

        public TipoData(string nome, string mascara, bool anoCorrente = true) : base(nome)
        {
            Mascara = mascara;
            DefinirLimitesDoAno(anoCorrente);
        }

        public TipoData(string nome, string mascara, int anoMin, int anoMax) : this(nome, mascara, false)
        {
            ValidarParametrosAnos(anoMin, anoMax);
            DefinirLimitesDoAno(false, anoMin, anoMax);
        }

        public override string GerarValorAleatorio()
        {
            string ano = GerarAnoAleatorio();
            string mes = GerarMesAleatorio();
            string dia = GerarDiaAleatorio(int.Parse(ano), int.Parse(mes));

            string dataAleatoria = RetornarValorFormatadoNaMascara(Mascara, ano, mes, dia);
            return dataAleatoria;
        }

        private void DefinirLimitesDoAno(bool anoCorrente, int anoMin = 0, int anoMax = 0)
        {
            if (anoCorrente)
                DefinirLimiteAnoCorrente();

            if (ValidarLimitesDefinidos(anoMin, anoMax))
            {
                AnoMin = anoMin;
                AnoMax = anoMax;

                return;
            }
        }

        private string RetornarValorFormatadoNaMascara(string mascara, string ano, string mes, string dia)
        {
            string novaString = mascara.Replace("AAAA", ano)
                .Replace("MM", mes)
                .Replace("DD", dia);

            return novaString;
        }

        private void DefinirDiaMaximo(int ano, int mes)
        {
            DiaMax = DateTime.DaysInMonth(ano, mes);
        }

        private void DefinirLimiteAnoCorrente()
        {
            AnoMax = AnoMin = DateTime.Now.Year;
        }

        private string GerarDiaAleatorio(int ano, int mes)
        {
            DefinirDiaMaximo(ano, mes);
            int diaAleatorio = GeradorDeNumeroAleatorio.Gerar(ValorMinimoDiaEMes, DiaMax);

            return FixadorDeTamanho.Fixar(diaAleatorio.ToString(), 2);
        }

        private string GerarMesAleatorio()
        {
            int mesAleatorio = GeradorDeNumeroAleatorio.Gerar(ValorMinimoDiaEMes, MesMax);
            return FixadorDeTamanho.Fixar(mesAleatorio.ToString(), 2);
        }

        private string GerarAnoAleatorio()
        {
            return GeradorDeNumeroAleatorio.Gerar(AnoMin, AnoMax).ToString();
        }

        private bool ValidarLimitesDefinidos(int anoMin, int anoMax)
        {
            return (anoMin > 0 && anoMax > 0);
        }

        private bool ValidarLimiteMinimoAno(int anoMin)
        {
            if (anoMin < AnoMin)
                return false;

            return true;
        }

        private bool ValidarLimiteMaximoAnoMaxQueAnoMin(int anoMin, int anoMax)
        {
            if (anoMin > anoMax)
                return false;

            return true;
        }

        private void ValidarParametrosAnos(int anoMin, int anoMax)
        {
            if (!ValidarLimiteMinimoAno(anoMin))
                throw new ArgumentException(string.Format("O limite inferior do ano não pode ser menor que {0}", AnoMin));

            if (!ValidarLimiteMaximoAnoMaxQueAnoMin(anoMin, anoMax))
                throw new ArgumentException("O limite superior do ano não pode ser menor que o limite inferior");
        }
    }
}