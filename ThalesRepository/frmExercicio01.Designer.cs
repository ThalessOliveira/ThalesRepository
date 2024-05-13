namespace ThalesRepository
{
    partial class frmExercicio01
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNota1 = new TextBox();
            txtNota2 = new TextBox();
            txtNota3 = new TextBox();
            txtNota4 = new TextBox();
            btnCalcularNotas = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // btnEx01Voltar
            // 
            btnEx01Voltar.Location = new Point(299, 358);
            btnEx01Voltar.Name = "btnEx01Voltar";
            btnEx01Voltar.Size = new Size(90, 53);
            btnEx01Voltar.TabIndex = 0;
            btnEx01Voltar.Text = "Voltar";
            btnEx01Voltar.UseVisualStyleBackColor = true;
            btnEx01Voltar.Click += btnEx01Voltar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 40);
            label1.Name = "label1";
            label1.Size = new Size(141, 15);
            label1.TabIndex = 1;
            label1.Text = "Calcular Média das Notas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 74);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 2;
            label2.Text = "Nota 1: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 110);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 3;
            label3.Text = "Nota 2: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 148);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 4;
            label4.Text = "Nota 3:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 183);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 5;
            label5.Text = "Nota 4:";
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(121, 71);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(178, 23);
            txtNota1.TabIndex = 6;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(121, 107);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(178, 23);
            txtNota2.TabIndex = 7;
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(121, 145);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(178, 23);
            txtNota3.TabIndex = 8;
            // 
            // txtNota4
            // 
            txtNota4.Location = new Point(121, 180);
            txtNota4.Name = "txtNota4";
            txtNota4.Size = new Size(178, 23);
            txtNota4.TabIndex = 9;
            // 
            // btnCalcularNotas
            // 
            btnCalcularNotas.Location = new Point(149, 239);
            btnCalcularNotas.Name = "btnCalcularNotas";
            btnCalcularNotas.Size = new Size(85, 40);
            btnCalcularNotas.TabIndex = 10;
            btnCalcularNotas.Text = "Calcular";
            btnCalcularNotas.UseVisualStyleBackColor = true;
            btnCalcularNotas.Click += btnCalcularNotas_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.Location = new Point(44, 313);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(276, 28);
            lblResultado.TabIndex = 11;
            lblResultado.Text = "A média das notas é: __________";
            // 
            // frmExercicio01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 414);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcularNotas);
            Controls.Add(txtNota4);
            Controls.Add(txtNota3);
            Controls.Add(txtNota2);
            Controls.Add(txtNota1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEx01Voltar);
            Name = "frmExercicio01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmExercicio01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEx01Voltar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNota1;
        private TextBox txtNota2;
        private TextBox txtNota3;
        private TextBox txtNota4;
        private Button btnCalcularNotas;
        private Label lblResultado;
    }
}