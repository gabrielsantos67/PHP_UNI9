using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Troca_de_tela
{
    public partial class Form2 : Form
    {
        public Form2(string mensagem)
        {
            InitializeComponent();

            // Exibe a mensagem recebida no Label
            lblMensagem.Text = mensagem;
        }

        private void lblMensagem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Fecha o Form2
            this.Close();

            // Cria uma nova instância de Form1
            Form1 form1 = new Form1("");

            // Exibe o Form1
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Cria uma instância do Form2
            Form1 form1 = new Form1(txtMensagem2.Text);

            // Exibe o Form2
            form1.Show();

            this.Hide();
        }
    }
}
