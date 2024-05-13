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
    public partial class frmExercicio02 : Form
    {
        public frmExercicio02()
        {
            InitializeComponent();
        }

        private void btnEx01Voltar_Click(object sender, EventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();
            this.Hide();
            frm.Show();
        }

        private void btnVm_Click(object sender, EventArgs e)
        {
            double h, km, vm;

            km = double.Parse(txtKm.Text);
            h = double.Parse(txtHoras.Text);

            vm = km / h;

            lblVm.Text = "VELOCIDADE MÉDIA: " + vm.ToString("N2") + "Km/h";
            lblVm.ForeColor = Color.Blue;


            MessageBox.Show("A VELOCIDADE MÉDIA É DE:" + vm.ToString("N2") + "Km/h","Resultado",MessageBoxButtons.OK);


        }
    }
}
