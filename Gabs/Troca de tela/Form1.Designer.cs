namespace Troca_de_tela
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAbrirForm2 = new System.Windows.Forms.Button();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMenssagem2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAbrirForm2
            // 
            this.btnAbrirForm2.Location = new System.Drawing.Point(368, 204);
            this.btnAbrirForm2.Name = "btnAbrirForm2";
            this.btnAbrirForm2.Size = new System.Drawing.Size(75, 23);
            this.btnAbrirForm2.TabIndex = 0;
            this.btnAbrirForm2.Text = "Avançar";
            this.btnAbrirForm2.UseVisualStyleBackColor = true;
            this.btnAbrirForm2.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(131, 96);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(100, 20);
            this.txtMensagem.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite algo para enviar:";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(12, 204);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Devolutiva:";
            // 
            // lblMenssagem2
            // 
            this.lblMenssagem2.AutoSize = true;
            this.lblMenssagem2.Location = new System.Drawing.Point(161, 140);
            this.lblMenssagem2.Name = "lblMenssagem2";
            this.lblMenssagem2.Size = new System.Drawing.Size(0, 13);
            this.lblMenssagem2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 239);
            this.Controls.Add(this.lblMenssagem2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.btnAbrirForm2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirForm2;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMenssagem2;
    }
}

