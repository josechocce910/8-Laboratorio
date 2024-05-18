namespace _10_ejercicio
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
            txtLetra = new TextBox();
            label2 = new Label();
            btnLetraDeterminada = new Button();
            label3 = new Label();
            txtResultado = new TextBox();
            txtPalabras = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtLetra
            // 
            txtLetra.Location = new Point(43, 109);
            txtLetra.Name = "txtLetra";
            txtLetra.Size = new Size(518, 27);
            txtLetra.TabIndex = 53;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 86);
            label2.Name = "label2";
            label2.Size = new Size(312, 20);
            label2.TabIndex = 52;
            label2.Text = "Ingrese la letra que se buscara en las palabras";
            // 
            // btnLetraDeterminada
            // 
            btnLetraDeterminada.Image = (Image)resources.GetObject("btnLetraDeterminada.Image");
            btnLetraDeterminada.Location = new Point(438, 196);
            btnLetraDeterminada.Name = "btnLetraDeterminada";
            btnLetraDeterminada.Size = new Size(149, 163);
            btnLetraDeterminada.TabIndex = 51;
            btnLetraDeterminada.Text = "Filtrar por Letra";
            btnLetraDeterminada.TextAlign = ContentAlignment.BottomCenter;
            btnLetraDeterminada.UseVisualStyleBackColor = true;
            btnLetraDeterminada.Click += btnLetraDeterminada_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 154);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 50;
            label3.Text = "Resultado";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(43, 186);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(336, 239);
            txtResultado.TabIndex = 49;
            // 
            // txtPalabras
            // 
            txtPalabras.Location = new Point(43, 41);
            txtPalabras.Name = "txtPalabras";
            txtPalabras.Size = new Size(518, 27);
            txtPalabras.TabIndex = 48;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 18);
            label1.Name = "label1";
            label1.Size = new Size(285, 20);
            label1.TabIndex = 47;
            label1.Text = "Ingrese las palabras separadas por comas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtLetra);
            Controls.Add(label2);
            Controls.Add(btnLetraDeterminada);
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

        private TextBox txtLetra;
        private Label label2;
        private Button btnLetraDeterminada;
        private Label label3;
        private TextBox txtResultado;
        private TextBox txtPalabras;
        private Label label1;
    }
}
