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
    public partial class FormMDI : Form
    {
        public FormMDI()
        {
            InitializeComponent();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f=new Form1();
            f.MdiParent = this;
            f.Show();

        }

        private void registoDeAvariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.MdiParent = this;
            f.Show();

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Formlogin f= new Formlogin();
            f.MdiParent = this;
            f.Show();

        }
    }
}
