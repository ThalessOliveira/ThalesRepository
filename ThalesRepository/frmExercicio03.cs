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
    public partial class frmExercicio03 : Form
    {
        public frmExercicio03()
        {
            InitializeComponent();
        }

        private void btnCalcSoma_Click(object sender, EventArgs e)
        {
            string v1, v2, v3, soma;

            v1 = (txtV1.Text);
            v2 = (txtV2.Text);
            v3 = (txtV3.Text);

            soma = v1 + v2 + v3;

            MessageBox.Show("A soma é de: " + soma + "!!!","Resultado",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }
    }
}
