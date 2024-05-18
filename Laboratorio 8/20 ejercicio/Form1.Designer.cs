namespace _20_ejercicio
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
            btnPalindromosLongitudOrdenadas = new Button();
            label2 = new Label();
            txtResultado = new TextBox();
            txtPalabras = new TextBox();
            label4 = new Label();
            txtLongitud = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnPalindromosLongitudOrdenadas
            // 
            btnPalindromosLongitudOrdenadas.Image = (Image)resources.GetObject("btnPalindromosLongitudOrdenadas.Image");
            btnPalindromosLongitudOrdenadas.Location = new Point(405, 212);
            btnPalindromosLongitudOrdenadas.Name = "btnPalindromosLongitudOrdenadas";
            btnPalindromosLongitudOrdenadas.Size = new Size(289, 262);
            btnPalindromosLongitudOrdenadas.TabIndex = 111;
            btnPalindromosLongitudOrdenadas.Text = "Encontrar Palindromos de la misma Longitud Ordenadas de Menor a Mayor\r\n\r\n\r\n";
            btnPalindromosLongitudOrdenadas.TextAlign = ContentAlignment.BottomCenter;
            btnPalindromosLongitudOrdenadas.UseVisualStyleBackColor = true;
            btnPalindromosLongitudOrdenadas.Click += btnPalindromosLongitudOrdenadas_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 189);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 110;
            label2.Text = "Resultado";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(25, 212);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(350, 262);
            txtResultado.TabIndex = 109;
            // 
            // txtPalabras
            // 
            txtPalabras.Location = new Point(22, 47);
            txtPalabras.Name = "txtPalabras";
            txtPalabras.Size = new Size(904, 27);
            txtPalabras.TabIndex = 108;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 24);
            label4.Name = "label4";
            label4.Size = new Size(217, 40);
            label4.TabIndex = 107;
            label4.Text = "Ingrese el conjunto de palabras\r\n\r\n";
            // 
            // txtLongitud
            // 
            txtLongitud.Location = new Point(22, 120);
            txtLongitud.Name = "txtLongitud";
            txtLongitud.Size = new Size(904, 27);
            txtLongitud.TabIndex = 113;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 97);
            label1.Name = "label1";
            label1.Size = new Size(203, 40);
            label1.TabIndex = 112;
            label1.Text = "Ingrese la longitud especifica\r\n\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 515);
            Controls.Add(txtLongitud);
            Controls.Add(label1);
            Controls.Add(btnPalindromosLongitudOrdenadas);
            Controls.Add(label2);
            Controls.Add(txtResultado);
            Controls.Add(txtPalabras);
            Controls.Add(label4);
            Name = "Form1";
            Text = "Ejercicio 20";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPalindromosLongitudOrdenadas;
        private Label label2;
        private TextBox txtResultado;
        private TextBox txtPalabras;
        private Label label4;
        private TextBox txtLongitud;
        private Label label1;
    }
}
