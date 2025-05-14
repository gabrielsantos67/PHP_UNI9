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
    public partial class Form1 : Form
    {
        public Form1(string mensagem)
        {
            InitializeComponent();

            lblMenssagem2.Text = mensagem;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            // Cria uma instância do Form2
            Form2 form2 = new Form2(txtMensagem.Text);

            // Exibe o Form2
            form2.Show();

            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
