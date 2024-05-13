namespace ThalesRepository
{
    partial class frmExercicio03
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
            btnCalcSoma = new Button();
            label1 = new Label();
            label2 = new Label();
            txtV1 = new TextBox();
            txtV2 = new TextBox();
            label3 = new Label();
            txtV3 = new TextBox();
            SuspendLayout();
            // 
            // btnCalcSoma
            // 
            btnCalcSoma.Location = new Point(154, 222);
            btnCalcSoma.Name = "btnCalcSoma";
            btnCalcSoma.Size = new Size(86, 37);
            btnCalcSoma.TabIndex = 0;
            btnCalcSoma.Text = "Calcular";
            btnCalcSoma.UseVisualStyleBackColor = true;
            btnCalcSoma.Click += btnCalcSoma_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 77);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "Valor 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 119);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Valor 2";
            // 
            // txtV1
            // 
            txtV1.Location = new Point(154, 69);
            txtV1.Name = "txtV1";
            txtV1.Size = new Size(143, 23);
            txtV1.TabIndex = 3;
            // 
            // txtV2
            // 
            txtV2.Location = new Point(154, 116);
            txtV2.Name = "txtV2";
            txtV2.Size = new Size(143, 23);
            txtV2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 162);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 5;
            label3.Text = "Valor 3";
            // 
            // txtV3
            // 
            txtV3.Location = new Point(154, 162);
            txtV3.Name = "txtV3";
            txtV3.Size = new Size(143, 23);
            txtV3.TabIndex = 6;
            // 
            // frmExercicio03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 414);
            Controls.Add(txtV3);
            Controls.Add(label3);
            Controls.Add(txtV2);
            Controls.Add(txtV1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCalcSoma);
            Name = "frmExercicio03";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmExercicio03";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcSoma;
        private Label label1;
        private Label label2;
        private TextBox txtV1;
        private TextBox txtV2;
        private Label label3;
        private TextBox txtV3;
    }
}