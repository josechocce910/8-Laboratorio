namespace _16_ejercicio
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnPalindromosOrdenados = new Button();
            label3 = new Label();
            txtResultado = new TextBox();
            txtPalabras = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnPalindromosOrdenados
            // 
            btnPalindromosOrdenados.Image = (Image)resources.GetObject("btnPalindromosOrdenados.Image");
            btnPalindromosOrdenados.Location = new Point(404, 126);
            btnPalindromosOrdenados.Name = "btnPalindromosOrdenados";
            btnPalindromosOrdenados.Size = new Size(150, 256);
            btnPalindromosOrdenados.TabIndex = 83;
            btnPalindromosOrdenados.Text = "c";
            btnPalindromosOrdenados.TextAlign = ContentAlignment.BottomCenter;
            btnPalindromosOrdenados.UseVisualStyleBackColor = true;
            btnPalindromosOrdenados.Click += btnPalindromosOrdenados_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 104);
            label3.Name = "label3";
            label3.Size = new Size(16, 20);
            label3.TabIndex = 82;
            label3.Text = "c";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(12, 136);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(336, 239);
            txtResultado.TabIndex = 81;
            txtResultado.Text = "c";
            // 
            // txtPalabras
            // 
            txtPalabras.Location = new Point(12, 52);
            txtPalabras.Name = "txtPalabras";
            txtPalabras.Size = new Size(518, 27);
            txtPalabras.TabIndex = 80;
            txtPalabras.Text = "c";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(16, 20);
            label1.TabIndex = 79;
            label1.Text = "c";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 415);
            Controls.Add(btnPalindromosOrdenados);
            Controls.Add(label3);
            Controls.Add(txtResultado);
            Controls.Add(txtPalabras);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Ejercicio 16";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPalindromosOrdenados;
        private Label label3;
        private TextBox txtResultado;
        private TextBox txtPalabras;
        private Label label1;
    }
}
