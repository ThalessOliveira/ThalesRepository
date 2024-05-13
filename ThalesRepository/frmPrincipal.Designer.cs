namespace ThalesRepository
{
    partial class frmPrincipal
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
            btnPrinFechar = new Button();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            exercicio01ToolStripMenuItem = new ToolStripMenuItem();
            exercicio01ToolStripMenuItem1 = new ToolStripMenuItem();
            exercicio02ToolStripMenuItem = new ToolStripMenuItem();
            exercicio03ToolStripMenuItem = new ToolStripMenuItem();
            exercicio04ToolStripMenuItem = new ToolStripMenuItem();
            bancoDeDadosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnPrinFechar
            // 
            btnPrinFechar.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrinFechar.Location = new Point(177, 352);
            btnPrinFechar.Name = "btnPrinFechar";
            btnPrinFechar.Size = new Size(95, 51);
            btnPrinFechar.TabIndex = 3;
            btnPrinFechar.Text = "Fechar";
            btnPrinFechar.UseVisualStyleBackColor = true;
            btnPrinFechar.Click += btnPrinFechar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 197);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(187, 15);
            label1.TabIndex = 2;
            label1.Text = "BEM VINDO AO MENU PRINCIPAL";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { exercicio01ToolStripMenuItem, bancoDeDadosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(430, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // exercicio01ToolStripMenuItem
            // 
            exercicio01ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exercicio01ToolStripMenuItem1, exercicio02ToolStripMenuItem, exercicio03ToolStripMenuItem, exercicio04ToolStripMenuItem });
            exercicio01ToolStripMenuItem.Name = "exercicio01ToolStripMenuItem";
            exercicio01ToolStripMenuItem.Size = new Size(81, 20);
            exercicio01ToolStripMenuItem.Text = "Algoritimos";
            // 
            // exercicio01ToolStripMenuItem1
            // 
            exercicio01ToolStripMenuItem1.Name = "exercicio01ToolStripMenuItem1";
            exercicio01ToolStripMenuItem1.Size = new Size(180, 22);
            exercicio01ToolStripMenuItem1.Text = "Exercicio 01";
            exercicio01ToolStripMenuItem1.Click += exercicio01ToolStripMenuItem1_Click;
            // 
            // exercicio02ToolStripMenuItem
            // 
            exercicio02ToolStripMenuItem.Name = "exercicio02ToolStripMenuItem";
            exercicio02ToolStripMenuItem.Size = new Size(180, 22);
            exercicio02ToolStripMenuItem.Text = "Exercicio 02";
            exercicio02ToolStripMenuItem.Click += exercicio02ToolStripMenuItem_Click;
            // 
            // exercicio03ToolStripMenuItem
            // 
            exercicio03ToolStripMenuItem.Name = "exercicio03ToolStripMenuItem";
            exercicio03ToolStripMenuItem.Size = new Size(180, 22);
            exercicio03ToolStripMenuItem.Text = "Exercicio 03";
            exercicio03ToolStripMenuItem.Click += exercicio03ToolStripMenuItem_Click;
            // 
            // exercicio04ToolStripMenuItem
            // 
            exercicio04ToolStripMenuItem.Name = "exercicio04ToolStripMenuItem";
            exercicio04ToolStripMenuItem.Size = new Size(180, 22);
            exercicio04ToolStripMenuItem.Text = "Exercicio 04";
            exercicio04ToolStripMenuItem.Click += exercicio04ToolStripMenuItem_Click;
            // 
            // bancoDeDadosToolStripMenuItem
            // 
            bancoDeDadosToolStripMenuItem.Name = "bancoDeDadosToolStripMenuItem";
            bancoDeDadosToolStripMenuItem.Size = new Size(103, 20);
            bancoDeDadosToolStripMenuItem.Text = "Banco de dados";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 440);
            Controls.Add(btnPrinFechar);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPrinFechar;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem exercicio01ToolStripMenuItem;
        private ToolStripMenuItem exercicio01ToolStripMenuItem1;
        private ToolStripMenuItem exercicio02ToolStripMenuItem;
        private ToolStripMenuItem exercicio03ToolStripMenuItem;
        private ToolStripMenuItem exercicio04ToolStripMenuItem;
        private ToolStripMenuItem bancoDeDadosToolStripMenuItem;
    }
}