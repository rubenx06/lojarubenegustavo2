using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lojarubenegustavo2
{
    public partial class Formlogin : Form
    {
        public Formlogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //limpar os campos 
            textBox1.ResetText();
            textBox2.ResetText();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //verificar se os campos estão vazios
            if (textBox1.Text ==null && textBox1.Text ==null)
            {
                MessageBox.Show("Digite o seu login e a senha", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                 textBox1.Focus();
                return;
            }
            //verificar se o login está vazio 
            if (textBox1.Text == "")
            {
                MessageBox.Show("Digite o seu login de utilizador", "Aviso");
                return;    
            }

            //verificar se a senha está vazia 
            if (textBox2.Text == "")
            {
                MessageBox.Show("Digite a sua senha de utilizador", "Aviso");
                return;
            }

            //verificar se está correto o login e a senha
            if (textBox1.Text.Equals("gustavo") && textBox2.Text.Equals("rubem"))
            {
                MessageBox.Show("Autenticado com sucesso.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Acesso invalido. Digite o login e a senha correta.", "Aviso",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
