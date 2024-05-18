namespace _18_ejercicio
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
            label1 = new Label();
            btnPalabrasConLetra = new Button();
            label2 = new Label();
            txtResultado = new TextBox();
            txtPalabras = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtLetra
            // 
            txtLetra.Location = new Point(12, 117);
            txtLetra.Name = "txtLetra";
            txtLetra.Size = new Size(518, 27);
            txtLetra.TabIndex = 101;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 94);
            label1.Name = "label1";
            label1.Size = new Size(177, 20);
            label1.TabIndex = 100;
            label1.Text = "Ingrese la letra específica\r\n";
            // 
            // btnPalabrasConLetra
            // 
            btnPalabrasConLetra.Image = (Image)resources.GetObject("btnPalabrasConLetra.Image");
            btnPalabrasConLetra.Location = new Point(382, 189);
            btnPalabrasConLetra.Name = "btnPalabrasConLetra";
            btnPalabrasConLetra.Size = new Size(184, 262);
            btnPalabrasConLetra.TabIndex = 99;
            btnPalabrasConLetra.Text = "Encontrar palabras de la misma Longitud Ordenadas de Mayor a Menor\r\n";
            btnPalabrasConLetra.TextAlign = ContentAlignment.BottomCenter;
            btnPalabrasConLetra.UseVisualStyleBackColor = true;
            btnPalabrasConLetra.Click += btnPalabrasConLetra_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 176);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 98;
            label2.Text = "Resultado";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(12, 199);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(336, 239);
            txtResultado.TabIndex = 97;
            // 
            // txtPalabras
            // 
            txtPalabras.Location = new Point(12, 39);
            txtPalabras.Name = "txtPalabras";
            txtPalabras.Size = new Size(518, 27);
            txtPalabras.TabIndex = 96;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 16);
            label4.Name = "label4";
            label4.Size = new Size(217, 20);
            label4.TabIndex = 95;
            label4.Text = "Ingrese el conjunto de palabras";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 450);
            Controls.Add(txtLetra);
            Controls.Add(label1);
            Controls.Add(btnPalabrasConLetra);
            Controls.Add(label2);
            Controls.Add(txtResultado);
            Controls.Add(txtPalabras);
            Controls.Add(label4);
            Name = "Form1";
            Text = "Ejercicio 18";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLetra;
        private Label label1;
        private Button btnPalabrasConLetra;
        private Label label2;
        private TextBox txtResultado;
        private TextBox txtPalabras;
        private Label label4;
    }
}
