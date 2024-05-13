namespace ThalesRepository
{
    public partial class frmLogin : Form
    {

        private int tentativas = 0;


        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (usuario == "Thales" && senha == "123")
            {
                frmPrincipal frm = new frmPrincipal();
                this.Hide();
                frm.Show();

                MessageBox.Show("Tentativa bem sucedida!!!");
            }
            else
            {
                MessageBox.Show("Tentativa Incorreta");

                tentativas++;
                AtualizarTentativasLabel();
            }
            if (tentativas > 3)
            {
                MessageBox.Show("Número de tentativas excedida!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AtualizarTentativasLabel()
        {
            lblTentativas.Text = "Tentativas " + tentativas.ToString();
        }
    }
}
