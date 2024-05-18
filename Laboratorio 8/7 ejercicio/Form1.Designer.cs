namespace _7_ejercicio
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
            btnEncontrarAnagramas = new Button();
            label3 = new Label();
            txtResultado = new TextBox();
            txtPalabras = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnEncontrarAnagramas
            // 
            btnEncontrarAnagramas.Image = (Image)resources.GetObject("btnEncontrarAnagramas.Image");
            btnEncontrarAnagramas.Location = new Point(445, 209);
            btnEncontrarAnagramas.Name = "btnEncontrarAnagramas";
            btnEncontrarAnagramas.Size = new Size(149, 163);
            btnEncontrarAnagramas.TabIndex = 34;
            btnEncontrarAnagramas.Text = "Encontrar Anagramas";
            btnEncontrarAnagramas.TextAlign = ContentAlignment.BottomCenter;
            btnEncontrarAnagramas.UseVisualStyleBackColor = true;
            btnEncontrarAnagramas.Click += btnEncontrarAnagramas_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 132);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 33;
            label3.Text = "Resultado";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(50, 155);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(336, 283);
            txtResultado.TabIndex = 32;
            // 
            // txtPalabras
            // 
            txtPalabras.Location = new Point(50, 54);
            txtPalabras.Name = "txtPalabras";
            txtPalabras.Size = new Size(518, 27);
            txtPalabras.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 31);
            label1.Name = "label1";
            label1.Size = new Size(285, 20);
            label1.TabIndex = 28;
            label1.Text = "Ingrese las palabras separadas por comas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 450);
            Controls.Add(btnEncontrarAnagramas);
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

        private Button btnEncontrarAnagramas;
        private Label label3;
        private TextBox txtResultado;
        private TextBox txtPalabras;
        private Label label1;
    }
}
