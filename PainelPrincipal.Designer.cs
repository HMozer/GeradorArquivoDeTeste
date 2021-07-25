using GeradorArquivoDeTeste.Modelos.Enum;
using System;

namespace GeradorArquivoDeTeste
{
    partial class PainelPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BotaoGerador = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgw_lista_tipos = new System.Windows.Forms.DataGridView();
            this.dgw_coluna_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgw_coluna_tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgw_coluna_mascara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgw_coluna_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txb_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_tipos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_incluir = new System.Windows.Forms.Button();
            this.pnl_base = new System.Windows.Forms.Panel();
            this.pnl_descricao = new System.Windows.Forms.Panel();
            this.txb_descricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnl_tamanho = new System.Windows.Forms.Panel();
            this.nud_tamanho = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.pnl_decimal = new System.Windows.Forms.Panel();
            this.nud_casas_decimais = new System.Windows.Forms.NumericUpDown();
            this.cmb_separador = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnl_data = new System.Windows.Forms.Panel();
            this.ckb_ano_vigente = new System.Windows.Forms.CheckBox();
            this.txb_mascara_data = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnl_ano_minimo_maximo = new System.Windows.Forms.Panel();
            this.nud_ano_maximo = new System.Windows.Forms.NumericUpDown();
            this.nud_ano_minimo = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_lista_tipos)).BeginInit();
            this.pnl_base.SuspendLayout();
            this.pnl_descricao.SuspendLayout();
            this.pnl_tamanho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_tamanho)).BeginInit();
            this.pnl_decimal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_casas_decimais)).BeginInit();
            this.pnl_data.SuspendLayout();
            this.pnl_ano_minimo_maximo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ano_maximo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ano_minimo)).BeginInit();
            this.SuspendLayout();
            // 
            // BotaoGerador
            // 
            this.BotaoGerador.Location = new System.Drawing.Point(19, 592);
            this.BotaoGerador.Margin = new System.Windows.Forms.Padding(4);
            this.BotaoGerador.Name = "BotaoGerador";
            this.BotaoGerador.Size = new System.Drawing.Size(184, 48);
            this.BotaoGerador.TabIndex = 0;
            this.BotaoGerador.Text = "Gera Arquivo de Teste";
            this.BotaoGerador.UseVisualStyleBackColor = true;
            this.BotaoGerador.Click += new System.EventHandler(this.BotaoGerador_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gerador de Arquivos de Teste";
            // 
            // dgw_lista_tipos
            // 
            this.dgw_lista_tipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_lista_tipos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgw_coluna_nome,
            this.dgw_coluna_tipo,
            this.dgw_coluna_mascara,
            this.dgw_coluna_descricao});
            this.dgw_lista_tipos.Location = new System.Drawing.Point(19, 65);
            this.dgw_lista_tipos.Name = "dgw_lista_tipos";
            this.dgw_lista_tipos.ReadOnly = true;
            this.dgw_lista_tipos.RowHeadersWidth = 51;
            this.dgw_lista_tipos.RowTemplate.Height = 24;
            this.dgw_lista_tipos.Size = new System.Drawing.Size(841, 440);
            this.dgw_lista_tipos.TabIndex = 2;
            // 
            // dgw_coluna_nome
            // 
            this.dgw_coluna_nome.HeaderText = "Nome";
            this.dgw_coluna_nome.MinimumWidth = 6;
            this.dgw_coluna_nome.Name = "dgw_coluna_nome";
            this.dgw_coluna_nome.ReadOnly = true;
            this.dgw_coluna_nome.Width = 125;
            // 
            // dgw_coluna_tipo
            // 
            this.dgw_coluna_tipo.HeaderText = "Tipo";
            this.dgw_coluna_tipo.MinimumWidth = 6;
            this.dgw_coluna_tipo.Name = "dgw_coluna_tipo";
            this.dgw_coluna_tipo.ReadOnly = true;
            this.dgw_coluna_tipo.Width = 125;
            // 
            // dgw_coluna_mascara
            // 
            this.dgw_coluna_mascara.HeaderText = "Máscara";
            this.dgw_coluna_mascara.MinimumWidth = 6;
            this.dgw_coluna_mascara.Name = "dgw_coluna_mascara";
            this.dgw_coluna_mascara.ReadOnly = true;
            this.dgw_coluna_mascara.Width = 125;
            // 
            // dgw_coluna_descricao
            // 
            this.dgw_coluna_descricao.HeaderText = "Descrição";
            this.dgw_coluna_descricao.MinimumWidth = 6;
            this.dgw_coluna_descricao.Name = "dgw_coluna_descricao";
            this.dgw_coluna_descricao.ReadOnly = true;
            this.dgw_coluna_descricao.Width = 125;
            // 
            // txb_nome
            // 
            this.txb_nome.Location = new System.Drawing.Point(6, 20);
            this.txb_nome.Name = "txb_nome";
            this.txb_nome.Size = new System.Drawing.Size(172, 22);
            this.txb_nome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // cmb_tipos
            // 
            this.cmb_tipos.FormattingEnabled = true;
            this.cmb_tipos.Location = new System.Drawing.Point(197, 18);
            this.cmb_tipos.Name = "cmb_tipos";
            this.cmb_tipos.Size = new System.Drawing.Size(173, 24);
            this.cmb_tipos.TabIndex = 5;
            this.cmb_tipos.SelectedIndexChanged += new System.EventHandler(this.cb_tipos_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo";
            // 
            // btn_incluir
            // 
            this.btn_incluir.Location = new System.Drawing.Point(866, 513);
            this.btn_incluir.Name = "btn_incluir";
            this.btn_incluir.Size = new System.Drawing.Size(101, 29);
            this.btn_incluir.TabIndex = 10;
            this.btn_incluir.Text = "Incluir Tipo";
            this.btn_incluir.UseVisualStyleBackColor = true;
            this.btn_incluir.Click += new System.EventHandler(this.btn_incluir_Click);
            // 
            // pnl_base
            // 
            this.pnl_base.Controls.Add(this.label2);
            this.pnl_base.Controls.Add(this.txb_nome);
            this.pnl_base.Controls.Add(this.cmb_tipos);
            this.pnl_base.Controls.Add(this.label3);
            this.pnl_base.Location = new System.Drawing.Point(866, 65);
            this.pnl_base.Name = "pnl_base";
            this.pnl_base.Size = new System.Drawing.Size(474, 51);
            this.pnl_base.TabIndex = 11;
            // 
            // pnl_descricao
            // 
            this.pnl_descricao.Controls.Add(this.txb_descricao);
            this.pnl_descricao.Controls.Add(this.label4);
            this.pnl_descricao.Location = new System.Drawing.Point(866, 375);
            this.pnl_descricao.Name = "pnl_descricao";
            this.pnl_descricao.Size = new System.Drawing.Size(474, 132);
            this.pnl_descricao.TabIndex = 12;
            // 
            // txb_descricao
            // 
            this.txb_descricao.Location = new System.Drawing.Point(6, 20);
            this.txb_descricao.Multiline = true;
            this.txb_descricao.Name = "txb_descricao";
            this.txb_descricao.Size = new System.Drawing.Size(462, 94);
            this.txb_descricao.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Descrição";
            // 
            // pnl_tamanho
            // 
            this.pnl_tamanho.Controls.Add(this.nud_tamanho);
            this.pnl_tamanho.Controls.Add(this.label5);
            this.pnl_tamanho.Location = new System.Drawing.Point(866, 123);
            this.pnl_tamanho.Name = "pnl_tamanho";
            this.pnl_tamanho.Size = new System.Drawing.Size(474, 56);
            this.pnl_tamanho.TabIndex = 13;
            this.pnl_tamanho.Visible = false;
            // 
            // nud_tamanho
            // 
            this.nud_tamanho.Location = new System.Drawing.Point(6, 21);
            this.nud_tamanho.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_tamanho.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_tamanho.Name = "nud_tamanho";
            this.nud_tamanho.Size = new System.Drawing.Size(172, 22);
            this.nud_tamanho.TabIndex = 1;
            this.nud_tamanho.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tamanho";
            // 
            // pnl_decimal
            // 
            this.pnl_decimal.Controls.Add(this.nud_casas_decimais);
            this.pnl_decimal.Controls.Add(this.cmb_separador);
            this.pnl_decimal.Controls.Add(this.label7);
            this.pnl_decimal.Controls.Add(this.label6);
            this.pnl_decimal.Location = new System.Drawing.Point(866, 185);
            this.pnl_decimal.Name = "pnl_decimal";
            this.pnl_decimal.Size = new System.Drawing.Size(474, 56);
            this.pnl_decimal.TabIndex = 14;
            this.pnl_decimal.Visible = false;
            // 
            // nud_casas_decimais
            // 
            this.nud_casas_decimais.Location = new System.Drawing.Point(6, 21);
            this.nud_casas_decimais.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_casas_decimais.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_casas_decimais.Name = "nud_casas_decimais";
            this.nud_casas_decimais.Size = new System.Drawing.Size(172, 22);
            this.nud_casas_decimais.TabIndex = 4;
            this.nud_casas_decimais.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmb_separador
            // 
            this.cmb_separador.FormattingEnabled = true;
            this.cmb_separador.Location = new System.Drawing.Point(197, 17);
            this.cmb_separador.Name = "cmb_separador";
            this.cmb_separador.Size = new System.Drawing.Size(173, 24);
            this.cmb_separador.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(194, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Separador";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Casas Decimais";
            // 
            // pnl_data
            // 
            this.pnl_data.Controls.Add(this.ckb_ano_vigente);
            this.pnl_data.Controls.Add(this.txb_mascara_data);
            this.pnl_data.Controls.Add(this.label8);
            this.pnl_data.Location = new System.Drawing.Point(866, 247);
            this.pnl_data.Name = "pnl_data";
            this.pnl_data.Size = new System.Drawing.Size(474, 56);
            this.pnl_data.TabIndex = 15;
            this.pnl_data.Visible = false;
            // 
            // ckb_ano_vigente
            // 
            this.ckb_ano_vigente.AutoSize = true;
            this.ckb_ano_vigente.Checked = true;
            this.ckb_ano_vigente.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_ano_vigente.Location = new System.Drawing.Point(197, 20);
            this.ckb_ano_vigente.Name = "ckb_ano_vigente";
            this.ckb_ano_vigente.Size = new System.Drawing.Size(107, 21);
            this.ckb_ano_vigente.TabIndex = 3;
            this.ckb_ano_vigente.Text = "Ano Vigente";
            this.ckb_ano_vigente.UseVisualStyleBackColor = true;
            this.ckb_ano_vigente.CheckedChanged += new System.EventHandler(this.ckb_ano_vigente_CheckedChanged);
            // 
            // txb_mascara_data
            // 
            this.txb_mascara_data.Location = new System.Drawing.Point(6, 20);
            this.txb_mascara_data.Name = "txb_mascara_data";
            this.txb_mascara_data.Size = new System.Drawing.Size(172, 22);
            this.txb_mascara_data.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mascara";
            // 
            // pnl_ano_minimo_maximo
            // 
            this.pnl_ano_minimo_maximo.Controls.Add(this.nud_ano_maximo);
            this.pnl_ano_minimo_maximo.Controls.Add(this.nud_ano_minimo);
            this.pnl_ano_minimo_maximo.Controls.Add(this.label10);
            this.pnl_ano_minimo_maximo.Controls.Add(this.label9);
            this.pnl_ano_minimo_maximo.Location = new System.Drawing.Point(866, 309);
            this.pnl_ano_minimo_maximo.Name = "pnl_ano_minimo_maximo";
            this.pnl_ano_minimo_maximo.Size = new System.Drawing.Size(474, 60);
            this.pnl_ano_minimo_maximo.TabIndex = 16;
            this.pnl_ano_minimo_maximo.Visible = false;
            // 
            // nud_ano_maximo
            // 
            this.nud_ano_maximo.Location = new System.Drawing.Point(197, 20);
            this.nud_ano_maximo.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nud_ano_maximo.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nud_ano_maximo.Name = "nud_ano_maximo";
            this.nud_ano_maximo.Size = new System.Drawing.Size(173, 22);
            this.nud_ano_maximo.TabIndex = 4;
            this.nud_ano_maximo.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // nud_ano_minimo
            // 
            this.nud_ano_minimo.Location = new System.Drawing.Point(6, 21);
            this.nud_ano_minimo.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nud_ano_minimo.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nud_ano_minimo.Name = "nud_ano_minimo";
            this.nud_ano_minimo.Size = new System.Drawing.Size(172, 22);
            this.nud_ano_minimo.TabIndex = 3;
            this.nud_ano_minimo.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nud_ano_minimo.ValueChanged += new System.EventHandler(this.nud_ano_minimo_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(194, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Ano Máximo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ano Mínimo";
            // 
            // PainelPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 653);
            this.Controls.Add(this.pnl_ano_minimo_maximo);
            this.Controls.Add(this.pnl_data);
            this.Controls.Add(this.pnl_decimal);
            this.Controls.Add(this.pnl_tamanho);
            this.Controls.Add(this.pnl_descricao);
            this.Controls.Add(this.pnl_base);
            this.Controls.Add(this.btn_incluir);
            this.Controls.Add(this.dgw_lista_tipos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotaoGerador);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PainelPrincipal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgw_lista_tipos)).EndInit();
            this.pnl_base.ResumeLayout(false);
            this.pnl_base.PerformLayout();
            this.pnl_descricao.ResumeLayout(false);
            this.pnl_descricao.PerformLayout();
            this.pnl_tamanho.ResumeLayout(false);
            this.pnl_tamanho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_tamanho)).EndInit();
            this.pnl_decimal.ResumeLayout(false);
            this.pnl_decimal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_casas_decimais)).EndInit();
            this.pnl_data.ResumeLayout(false);
            this.pnl_data.PerformLayout();
            this.pnl_ano_minimo_maximo.ResumeLayout(false);
            this.pnl_ano_minimo_maximo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ano_maximo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ano_minimo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotaoGerador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgw_lista_tipos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgw_coluna_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgw_coluna_tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgw_coluna_mascara;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgw_coluna_descricao;
        private System.Windows.Forms.TextBox txb_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_tipos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_incluir;
        private System.Windows.Forms.Panel pnl_base;
        private System.Windows.Forms.Panel pnl_descricao;
        private System.Windows.Forms.TextBox txb_descricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnl_tamanho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnl_decimal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_separador;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnl_data;
        private System.Windows.Forms.TextBox txb_mascara_data;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox ckb_ano_vigente;
        private System.Windows.Forms.Panel pnl_ano_minimo_maximo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nud_tamanho;
        private System.Windows.Forms.NumericUpDown nud_casas_decimais;
        private System.Windows.Forms.NumericUpDown nud_ano_maximo;
        private System.Windows.Forms.NumericUpDown nud_ano_minimo;
    }
}

