using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GeradorArquivoDeTeste.Modelos.Regras;

namespace GeradorArquivoDeTeste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BotaoGerador_Click(object sender, EventArgs e)
        {
            Regra teste = new RegraInteiro("foda-se", 7);
            lbl_valor_gerado.Text = teste.GerarValorAleatorio();
        }
    }
}
