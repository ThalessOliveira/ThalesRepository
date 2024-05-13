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
    public partial class frmExercicio04 : Form
    {
        public frmExercicio04()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double celsius, fahrenheit, kelvin;

            celsius = Convert.ToDouble(txtCelsius.Text);

            fahrenheit = celsius * 1.8 + 32;

            kelvin = celsius + 273;


            MessageBox.Show("A temperatura em Fahrenheit é: " + fahrenheit.ToString("0.00") + Environment.NewLine +
                "A temperatura em Kelvin é: " + kelvin.ToString("0.00") + Environment.NewLine +
                (celsius <= 10 ? "Hoje está FRIO!" + Environment.NewLine : "") +
                (celsius >= 40 ? "Hoje está CALOR!" + Environment.NewLine : "") +
                (celsius > 10 && celsius < 40 ? "Hoje está FRESCO!" + Environment.NewLine : ""), "Resultado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTempVoltar_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            this.Hide();
            frmPrincipal.Show();
        }
    }
}
