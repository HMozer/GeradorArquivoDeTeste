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
        private const int EspacamentoEntrePaineis = 5;

        public PainelPrincipal()
        {
            InitializeComponent();

            DefinirValoresDosComboBox();
            PosicionarPainel(pnl_descricao);
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
            Tipo novaLinha = RecuperarItemDoFormulario();
            dgw_lista_tipos.Rows.Add(novaLinha);
        }

        private void ckb_ano_vigente_CheckedChanged(object sender, EventArgs e)
        {
            MontarPainel(pnl_ano_minimo_maximo, !ckb_ano_vigente.Checked);
        }

        private void nud_ano_minimo_ValueChanged(object sender, EventArgs e)
        {
            if (nud_ano_minimo.Value > nud_ano_maximo.Value)
            {
                MessageBox.Show("O Ano Mínimo não pode ser maior que o Ano Máximo.", "Erro de Validação");
                nud_ano_minimo.Value = 1900;
            }
        }

        private void DefinirValoresDosComboBox()
        {
            cmb_tipos.Items.AddRange(Enum.GetNames(typeof(EnumTipo)));

            cmb_separador.Items.AddRange(Enum.GetNames(typeof(EnumSeparador)));
            cmb_separador.SelectedIndex = 0;
        }

        private void DefinirVisibilidadePainel(Panel painel, bool visibilidade)
        {
            if (painel.Name == pnl_descricao.Name)
                return;

            painel.Visible = visibilidade;
        }

        private int BuscarAlturaPainelBase()
        {
            return pnl_base.Location.Y + pnl_base.Height;
        }

        private int BuscarAlturaDosPaineisAbertos(Panel painel)
        {
            int alturaDosPaineis = 0;

            if (pnl_ano_minimo_maximo.Visible && pnl_ano_minimo_maximo.Name != painel.Name)
                alturaDosPaineis += pnl_ano_minimo_maximo.Height + EspacamentoEntrePaineis;

            if (pnl_data.Visible && pnl_data.Name != painel.Name)
                alturaDosPaineis += pnl_data.Height + EspacamentoEntrePaineis;

            if (pnl_decimal.Visible && pnl_decimal.Name != painel.Name)
                alturaDosPaineis += pnl_decimal.Height + EspacamentoEntrePaineis;

            if (pnl_tamanho.Visible && pnl_tamanho.Name != painel.Name)
                alturaDosPaineis += pnl_tamanho.Height + EspacamentoEntrePaineis;

            return alturaDosPaineis;
        }

        private void PosicionarPainel(Panel painel)
        {
            int espacoPainelBase = BuscarAlturaPainelBase();
            int espacoPaineisAbertos = BuscarAlturaDosPaineisAbertos(painel);
            int posicaoY = espacoPainelBase + EspacamentoEntrePaineis + espacoPaineisAbertos;

            painel.Location = new Point(pnl_base.Location.X, posicaoY);

            if (painel.Name != pnl_descricao.Name)
                PosicionarPainel(pnl_descricao);
        }

        private void MontarPainel(Panel painel, bool visibilidade = true)
        {
            DefinirVisibilidadePainel(painel, visibilidade);
            PosicionarPainel(painel);
        }

        private void EsconderTodosOsPaineis()
        {
            DefinirVisibilidadePainel(pnl_tamanho, false);
            DefinirVisibilidadePainel(pnl_decimal, false);
            DefinirVisibilidadePainel(pnl_data, false);
            DefinirVisibilidadePainel(pnl_ano_minimo_maximo, false);
        }

        private void ExibirPainelSelecionado(int tipoSelecionado)
        {
            EsconderTodosOsPaineis();
            EnumTipo tipo = (EnumTipo)tipoSelecionado;

            switch (tipo)
            {
                case EnumTipo.String:
                    {
                        MontarPainel(pnl_tamanho);
                        break;
                    }
                case EnumTipo.Inteiro:
                    {
                        MontarPainel(pnl_tamanho);
                        break;
                    }
                case EnumTipo.Decimal:
                    {
                        MontarPainel(pnl_tamanho);
                        MontarPainel(pnl_decimal);
                        break;
                    }
                case EnumTipo.Data:
                    {
                        
                        ckb_ano_vigente.Checked = true;
                        MontarPainel(pnl_data);
                        break;
                    }
                default:
                    return;
            }
        }
    
        private Tipo RecuperarItemDoFormulario()
        {
            EnumTipo tipo = (EnumTipo)cmb_tipos.SelectedIndex;
            Tipo novoTipo = null;

            switch (tipo)
            {
                case EnumTipo.String:
                    {
                        novoTipo = new TipoString(txb_nome.Text, (int)nud_tamanho.Value);
                        break;
                    }
                case EnumTipo.Inteiro:
                    {
                        novoTipo = new TipoInteiro(txb_nome.Text, (int)nud_tamanho.Value);
                        break;
                    }
                case EnumTipo.Decimal:
                    {
                        novoTipo = new TipoDecimal(txb_nome.Text,
                                (int)nud_tamanho.Value,
                                (int)nud_casas_decimais.Value);
                        break;
                    }
                case EnumTipo.Data:
                    {
                        if (ckb_ano_vigente.Checked)
                        {
                            novoTipo = new TipoData(txb_nome.Text,
                                    txb_mascara_data.Text,
                                    ckb_ano_vigente.Checked);
                            break;
                        }

                        novoTipo = new TipoData(txb_nome.Text,
                                txb_mascara_data.Text,
                                (int)nud_ano_minimo.Value,
                                (int)nud_ano_maximo.Value);
                        break;
                    }
                default:
                    throw new InvalidEnumArgumentException("O valor selecionado não é válido");
            }

            return novoTipo;
        }
    }
}