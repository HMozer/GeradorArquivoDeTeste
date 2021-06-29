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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgw_coluna_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgw_coluna_tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgw_coluna_mascara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgw_coluna_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txb_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_tipos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl_string = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_string_tamanho = new System.Windows.Forms.TextBox();
            this.txb_descricao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnl_string.SuspendLayout();
            this.SuspendLayout();
            // 
            // BotaoGerador
            // 
            this.BotaoGerador.Location = new System.Drawing.Point(913, 533);
            this.BotaoGerador.Margin = new System.Windows.Forms.Padding(4);
            this.BotaoGerador.Name = "BotaoGerador";
            this.BotaoGerador.Size = new System.Drawing.Size(145, 48);
            this.BotaoGerador.TabIndex = 0;
            this.BotaoGerador.Text = "Gera Arquivo de Teste";
            this.BotaoGerador.UseVisualStyleBackColor = true;
            this.BotaoGerador.Click += new System.EventHandler(this.BotaoGerador_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gerador de Arquivos de Teste";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgw_coluna_nome,
            this.dgw_coluna_tipo,
            this.dgw_coluna_mascara,
            this.dgw_coluna_descricao});
            this.dataGridView1.Location = new System.Drawing.Point(19, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(555, 440);
            this.dataGridView1.TabIndex = 2;
            // 
            // dgw_coluna_nome
            // 
            this.dgw_coluna_nome.HeaderText = "Nome";
            this.dgw_coluna_nome.MinimumWidth = 6;
            this.dgw_coluna_nome.Name = "dgw_coluna_nome";
            this.dgw_coluna_nome.Width = 125;
            // 
            // dgw_coluna_tipo
            // 
            this.dgw_coluna_tipo.HeaderText = "Tipo";
            this.dgw_coluna_tipo.MinimumWidth = 6;
            this.dgw_coluna_tipo.Name = "dgw_coluna_tipo";
            this.dgw_coluna_tipo.Width = 125;
            // 
            // dgw_coluna_mascara
            // 
            this.dgw_coluna_mascara.HeaderText = "Máscara";
            this.dgw_coluna_mascara.MinimumWidth = 6;
            this.dgw_coluna_mascara.Name = "dgw_coluna_mascara";
            this.dgw_coluna_mascara.Width = 125;
            // 
            // dgw_coluna_descricao
            // 
            this.dgw_coluna_descricao.HeaderText = "Descrição";
            this.dgw_coluna_descricao.MinimumWidth = 6;
            this.dgw_coluna_descricao.Name = "dgw_coluna_descricao";
            this.dgw_coluna_descricao.Width = 125;
            // 
            // txb_nome
            // 
            this.txb_nome.Location = new System.Drawing.Point(583, 88);
            this.txb_nome.Name = "txb_nome";
            this.txb_nome.Size = new System.Drawing.Size(172, 22);
            this.txb_nome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(580, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // cb_tipos
            // 
            this.cb_tipos.FormattingEnabled = true;
            this.cb_tipos.Location = new System.Drawing.Point(772, 84);
            this.cb_tipos.Name = "cb_tipos";
            this.cb_tipos.Size = new System.Drawing.Size(173, 24);
            this.cb_tipos.TabIndex = 5;
            this.cb_tipos.SelectedIndexChanged += new System.EventHandler(this.cb_tipos_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(772, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo";
            // 
            // pnl_string
            // 
            this.pnl_string.Controls.Add(this.txb_string_tamanho);
            this.pnl_string.Controls.Add(this.label4);
            this.pnl_string.ImeMode = System.Windows.Forms.ImeMode.On;
            this.pnl_string.Location = new System.Drawing.Point(583, 131);
            this.pnl_string.Name = "pnl_string";
            this.pnl_string.Size = new System.Drawing.Size(475, 240);
            this.pnl_string.TabIndex = 7;
            this.pnl_string.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tamanho";
            // 
            // txb_string_tamanho
            // 
            this.txb_string_tamanho.Location = new System.Drawing.Point(7, 25);
            this.txb_string_tamanho.Name = "txb_string_tamanho";
            this.txb_string_tamanho.Size = new System.Drawing.Size(168, 22);
            this.txb_string_tamanho.TabIndex = 1;
            // 
            // txb_descricao
            // 
            this.txb_descricao.Location = new System.Drawing.Point(583, 418);
            this.txb_descricao.Multiline = true;
            this.txb_descricao.Name = "txb_descricao";
            this.txb_descricao.Size = new System.Drawing.Size(472, 87);
            this.txb_descricao.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(583, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Descrição";
            // 
            // PainelPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 598);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_descricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_tipos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_nome);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotaoGerador);
            this.Controls.Add(this.pnl_string);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PainelPrincipal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnl_string.ResumeLayout(false);
            this.pnl_string.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotaoGerador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgw_coluna_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgw_coluna_tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgw_coluna_mascara;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgw_coluna_descricao;
        private System.Windows.Forms.TextBox txb_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_tipos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnl_string;
        private System.Windows.Forms.TextBox txb_string_tamanho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_descricao;
        private System.Windows.Forms.Label label5;
    }
}

