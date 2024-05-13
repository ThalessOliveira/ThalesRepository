namespace ThalesRepository
{
    partial class frmExercicio02
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEx01Voltar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtKm = new TextBox();
            txtHoras = new TextBox();
            btnVm = new Button();
            lblVm = new Label();
            SuspendLayout();
            // 
            // btnEx01Voltar
            // 
            btnEx01Voltar.Location = new Point(298, 359);
            btnEx01Voltar.Name = "btnEx01Voltar";
            btnEx01Voltar.Size = new Size(90, 53);
            btnEx01Voltar.TabIndex = 1;
            btnEx01Voltar.Text = "Voltar";
            btnEx01Voltar.UseVisualStyleBackColor = true;
            btnEx01Voltar.Click += btnEx01Voltar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 71);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 2;
            label1.Text = "KMs Percorridos: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 136);
            label2.Name = "label2";
            label2.Size = new Size(141, 15);
            label2.TabIndex = 3;
            label2.Text = "Tempo gasto (em horas): ";
            // 
            // txtKm
            // 
            txtKm.Location = new Point(197, 71);
            txtKm.Name = "txtKm";
            txtKm.Size = new Size(129, 23);
            txtKm.TabIndex = 4;
            // 
            // txtHoras
            // 
            txtHoras.Location = new Point(197, 136);
            txtHoras.Name = "txtHoras";
            txtHoras.Size = new Size(129, 23);
            txtHoras.TabIndex = 5;
            // 
            // btnVm
            // 
            btnVm.Location = new Point(171, 200);
            btnVm.Name = "btnVm";
            btnVm.Size = new Size(179, 34);
            btnVm.TabIndex = 6;
            btnVm.Text = "Calcular Velocidade Média";
            btnVm.UseVisualStyleBackColor = true;
            btnVm.Click += btnVm_Click;
            // 
            // lblVm
            // 
            lblVm.AutoSize = true;
            lblVm.Location = new Point(35, 294);
            lblVm.Name = "lblVm";
            lblVm.Size = new Size(171, 15);
            lblVm.TabIndex = 7;
            lblVm.Text = "VELOCIDADE MÉDIA: __________";
            // 
            // frmExercicio02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 414);
            Controls.Add(lblVm);
            Controls.Add(btnVm);
            Controls.Add(txtHoras);
            Controls.Add(txtKm);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEx01Voltar);
            Name = "frmExercicio02";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmExercicio02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEx01Voltar;
        private Label label1;
        private Label label2;
        private TextBox txtKm;
        private TextBox txtHoras;
        private Button btnVm;
        private Label lblVm;
    }
}