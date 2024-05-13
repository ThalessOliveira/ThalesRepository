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
    public partial class frmExercicio01 : Form
    {
        public frmExercicio01()
        {
            InitializeComponent();
        }

        private void btnEx01Voltar_Click(object sender, EventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();
            this.Hide();
            frm.Show();
        }

        private void btnCalcularNotas_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, n4, m;

            n1 = double.Parse(txtNota1.Text);
            n2 = double.Parse(txtNota2.Text);
            n3 = double.Parse(txtNota3.Text);
            n4 = double.Parse(txtNota4.Text);

            m = (n1 + n2 + n3 + n4) / 5;

            if (n1 > 10 || n2 > 10 || n3 > 10 || n4 > 10)
            {
                MessageBox.Show("A nota precisa ser menor que 10", "Nota Inválida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (m > 7) 
            {

                MessageBox.Show("A média das notas é: " + m.ToString("N2"));
                lblResultado.Text = "APROVADO !!!";
                lblResultado.ForeColor = Color.Blue;
            }
            else
            {
                MessageBox.Show("A média das notas é: " + m.ToString("N2"));
                lblResultado.Text = "REPROVADO !!!";
                lblResultado.ForeColor = Color.Red;
            }



        }
    }
}
