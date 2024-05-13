namespace ThalesRepository
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            btnLogin = new Button();
            BtnFechar = new Button();
            lblTentativas = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 43);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuário:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 137);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Senha: ";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(64, 70);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(225, 23);
            txtUsuario.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(64, 164);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(225, 23);
            txtSenha.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(138, 222);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(89, 44);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // BtnFechar
            // 
            BtnFechar.Location = new Point(138, 284);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(89, 44);
            BtnFechar.TabIndex = 5;
            BtnFechar.Text = "Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // lblTentativas
            // 
            lblTentativas.AutoSize = true;
            lblTentativas.Location = new Point(21, 299);
            lblTentativas.Name = "lblTentativas";
            lblTentativas.Size = new Size(71, 15);
            lblTentativas.TabIndex = 6;
            lblTentativas.Text = "Tentativas: 0";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 406);
            Controls.Add(lblTentativas);
            Controls.Add(BtnFechar);
            Controls.Add(btnLogin);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Button btnLogin;
        private Button BtnFechar;
        private Label lblTentativas;
    }
}
