namespace _8_ejercicio
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
            btnCalcularPalindromos = new Button();
            label3 = new Label();
            txtResultado = new TextBox();
            txtPalabras = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCalcularPalindromos
            // 
            btnCalcularPalindromos.Image = (Image)resources.GetObject("btnCalcularPalindromos.Image");
            btnCalcularPalindromos.Location = new Point(433, 195);
            btnCalcularPalindromos.Name = "btnCalcularPalindromos";
            btnCalcularPalindromos.Size = new Size(149, 163);
            btnCalcularPalindromos.TabIndex = 39;
            btnCalcularPalindromos.Text = "Encontrar Paalindromos";
            btnCalcularPalindromos.TextAlign = ContentAlignment.BottomCenter;
            btnCalcularPalindromos.UseVisualStyleBackColor = true;
            btnCalcularPalindromos.Click += btnCalcularPalindromos_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 118);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 38;
            label3.Text = "Resultado";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(38, 141);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(336, 283);
            txtResultado.TabIndex = 37;
            // 
            // txtPalabras
            // 
            txtPalabras.Location = new Point(38, 40);
            txtPalabras.Name = "txtPalabras";
            txtPalabras.Size = new Size(518, 27);
            txtPalabras.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 17);
            label1.Name = "label1";
            label1.Size = new Size(285, 20);
            label1.TabIndex = 35;
            label1.Text = "Ingrese las palabras separadas por comas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 450);
            Controls.Add(btnCalcularPalindromos);
            Controls.Add(label3);
            Controls.Add(txtResultado);
            Controls.Add(txtPalabras);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcularPalindromos;
        private Label label3;
        private TextBox txtResultado;
        private TextBox txtPalabras;
        private Label label1;
    }
}
