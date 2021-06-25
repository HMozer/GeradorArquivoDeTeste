namespace GeradorArquivoDeTeste
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_valor_gerado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BotaoGerador
            // 
            this.BotaoGerador.Location = new System.Drawing.Point(628, 371);
            this.BotaoGerador.Name = "BotaoGerador";
            this.BotaoGerador.Size = new System.Drawing.Size(109, 39);
            this.BotaoGerador.TabIndex = 0;
            this.BotaoGerador.Text = "Gera Arquivo de Teste";
            this.BotaoGerador.UseVisualStyleBackColor = true;
            this.BotaoGerador.Click += new System.EventHandler(this.BotaoGerador_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gerador de Arquivos de Teste";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor Gerado:";
            // 
            // lbl_valor_gerado
            // 
            this.lbl_valor_gerado.AutoSize = true;
            this.lbl_valor_gerado.Location = new System.Drawing.Point(195, 110);
            this.lbl_valor_gerado.Name = "lbl_valor_gerado";
            this.lbl_valor_gerado.Size = new System.Drawing.Size(35, 13);
            this.lbl_valor_gerado.TabIndex = 3;
            this.lbl_valor_gerado.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_valor_gerado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotaoGerador);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotaoGerador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_valor_gerado;
    }
}

