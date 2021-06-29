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
        public PainelPrincipal()
        {
            InitializeComponent();
            cb_tipos.Items.AddRange(Enum.GetNames(typeof(EnumTipo)));
        }

        private void BotaoGerador_Click(object sender, EventArgs e)
        {
            Console.WriteLine("ok");
        }

        private void cb_tipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExibirPainelSelecionado(cb_tipos.SelectedIndex);
        }

        private void EsconderTodosOsPaineis()
        {
            pnl_string.Visible = false;
        }

        private void ExibirPainelSelecionado(int tipoSelecionado)
        {
            EsconderTodosOsPaineis();
            EnumTipo tipo = (EnumTipo)tipoSelecionado;
            switch (tipo)
            {
                case EnumTipo.String:
                {
                    Console.WriteLine("teste");
                    pnl_string.Visible = true;
                    break;
                }
                default:
                    return;
            }

        }
    }
}