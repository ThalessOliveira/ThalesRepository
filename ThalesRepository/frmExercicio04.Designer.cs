namespace ThalesRepository
{
    partial class frmExercicio04
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExercicio04));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtCelsius = new TextBox();
            btnCalcular = new Button();
            btnTempVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(123, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(72, 238);
            label1.Name = "label1";
            label1.Size = new Size(262, 28);
            label1.TabIndex = 1;
            label1.Text = "Conversor de Temperatura";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(84, 300);
            label2.Name = "label2";
            label2.Size = new Size(240, 20);
            label2.TabIndex = 2;
            label2.Text = "Informe a temperatura em Celsius: ";
            // 
            // txtCelsius
            // 
            txtCelsius.Location = new Point(144, 338);
            txtCelsius.Name = "txtCelsius";
            txtCelsius.Size = new Size(114, 23);
            txtCelsius.TabIndex = 3;
            txtCelsius.TextChanged += textBox1_TextChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.Coral;
            btnCalcular.ForeColor = Color.DarkRed;
            btnCalcular.Location = new Point(123, 386);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(158, 37);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Converter a temperatura";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnTempVoltar
            // 
            btnTempVoltar.Location = new Point(324, 443);
            btnTempVoltar.Name = "btnTempVoltar";
            btnTempVoltar.Size = new Size(75, 23);
            btnTempVoltar.TabIndex = 5;
            btnTempVoltar.Text = "Voltar";
            btnTempVoltar.UseVisualStyleBackColor = true;
            btnTempVoltar.Click += btnTempVoltar_Click;
            // 
            // frmExercicio04
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 466);
            Controls.Add(btnTempVoltar);
            Controls.Add(btnCalcular);
            Controls.Add(txtCelsius);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "frmExercicio04";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exercicio 04";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtCelsius;
        private Button btnCalcular;
        private Button btnTempVoltar;
    }
}