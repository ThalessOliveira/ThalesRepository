using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThalesRepository
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnPrinFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void exercicio01ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmExercicio01 frm = new frmExercicio01();
            frm.ShowDialog();
        }

        private void exercicio02ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio02 frm = new frmExercicio02();
            frm.ShowDialog();
        }

        private void exercicio03ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio03 frm = new frmExercicio03();
            frm.ShowDialog();
        }

        private void exercicio04ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio04 frm = new frmExercicio04();
            frm.ShowDialog();
        }
    }
}
