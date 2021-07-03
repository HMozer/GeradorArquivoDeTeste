using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GeradorArquivoDeTeste.Modelos.Enum;

using GeradorArquivoDeTeste.Modelos.Tipos;

namespace GeradorArquivoDeTeste
{
    public partial class PainelPrincipal : Form
    {
        private const int PosicaoXPainel = 436;
        private const int PosicaoYPainel = 102;

        public PainelPrincipal()
        {
            InitializeComponent();

            DefinirValoresDosComboBox();
            PosicionarInicialmentePainel(pnl_descricao);
        }

        private void BotaoGerador_Click(object sender, EventArgs e)
        {
            Console.WriteLine("ok");
        }

        private void cb_tipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExibirPainelSelecionado(cmb_tipos.SelectedIndex);
        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException("To do");
        }

        private void ckb_ano_vigente_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_ano_vigente.Checked)
            {
                DefinirVisibilidadePainel(pnl_ano_minimo_maximo);
                MoverPainelDescricao(pnl_data.Height);
                return;
            }

            ExibirCamposAnoMinimoMaximo();
        }

        private void DefinirValoresDosComboBox()
        {
            cmb_tipos.Items.AddRange(Enum.GetNames(typeof(EnumTipo)));

            cmb_separador.Items.AddRange(Enum.GetNames(typeof(EnumSeparador)));
            cmb_separador.SelectedIndex = 0;
        }

        private void ExibirCamposAnoMinimoMaximo()
        {
            int posicaoX = PosicaoXPainel;
            int posicaoY = pnl_data.Height + PosicaoYPainel;

            pnl_ano_minimo_maximo.Location = new Point(posicaoX, posicaoY);
            DefinirVisibilidadePainel(pnl_ano_minimo_maximo, true);

            int distanciaDosPaineis = pnl_data.Height + pnl_ano_minimo_maximo.Height;
            MoverPainelDescricao(distanciaDosPaineis);
            return;
        }

        private void PosicionarInicialmentePainel(Panel painel)
        {
            painel.Location = new Point(PosicaoXPainel, PosicaoYPainel);
        }

        private void DefinirVisibilidadePainel(Panel painel, bool visibilidade = false)
        {
            painel.Visible = visibilidade;
        }

        private void EsconderTodosOsPaineis()
        {
            DefinirVisibilidadePainel(pnl_tamanho);
            DefinirVisibilidadePainel(pnl_decimal);
            DefinirVisibilidadePainel(pnl_data);
            DefinirVisibilidadePainel(pnl_ano_minimo_maximo);
        }

        private void MoverPainelDescricao(int tamanhoPainel)
        {
            int novaPosicaoY = tamanhoPainel + PosicaoYPainel;
            pnl_descricao.Location = new Point(PosicaoXPainel, novaPosicaoY);
        }

        private void OrganizarPainelSelecionado(Panel painelSelecionado)
        {
            PosicionarInicialmentePainel(painelSelecionado);
            MoverPainelDescricao(painelSelecionado.Height);
            DefinirVisibilidadePainel(painelSelecionado, true);
        }

        private void ExibirPainelSelecionado(int tipoSelecionado)
        {
            EsconderTodosOsPaineis();
            EnumTipo tipo = (EnumTipo)tipoSelecionado;

            switch (tipo)
            {
                case EnumTipo.String:
                    {
                        OrganizarPainelSelecionado(pnl_tamanho);
                        break;
                    }
                case EnumTipo.Inteiro:
                    {
                        OrganizarPainelSelecionado(pnl_tamanho);
                        break;
                    }
                case EnumTipo.Decimal:
                    {
                        OrganizarPainelSelecionado(pnl_decimal);
                        break;
                    }
                case EnumTipo.Data:
                    {
                        ckb_ano_vigente.Checked = true;
                        OrganizarPainelSelecionado(pnl_data);
                        break;
                    }
                default:
                    return;
            }
        }
    }
}