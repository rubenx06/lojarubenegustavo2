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
    public partial class Form2 : Form
    {
        public Form2()

        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.IsMdiContainer = true;
            Form1 f = new Form1();
            f.MdiParent = this;
            f.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //limpar os campos 
            textBox1.ResetText();
            textBox2.ResetText();
        }
    }
}
