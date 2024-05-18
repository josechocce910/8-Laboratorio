namespace _17_ejercicio
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
            btnLongitudOrdenadas = new Button();
            label2 = new Label();
            txtResultado = new TextBox();
            txtPalabras = new TextBox();
            label4 = new Label();
            txtLongitud = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnLongitudOrdenadas
            // 
            btnLongitudOrdenadas.Image = (Image)resources.GetObject("btnLongitudOrdenadas.Image");
            btnLongitudOrdenadas.Location = new Point(404, 206);
            btnLongitudOrdenadas.Name = "btnLongitudOrdenadas";
            btnLongitudOrdenadas.Size = new Size(184, 262);
            btnLongitudOrdenadas.TabIndex = 92;
            btnLongitudOrdenadas.Text = "Encontrar palabras de la misma Longitud Ordenadas de Menor a Mayor";
            btnLongitudOrdenadas.TextAlign = ContentAlignment.BottomCenter;
            btnLongitudOrdenadas.UseVisualStyleBackColor = true;
            btnLongitudOrdenadas.Click += btnLongitudOrdenadas_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 193);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 91;
            label2.Text = "Resultado";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(34, 216);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(336, 239);
            txtResultado.TabIndex = 90;
            // 
            // txtPalabras
            // 
            txtPalabras.Location = new Point(34, 56);
            txtPalabras.Name = "txtPalabras";
            txtPalabras.Size = new Size(518, 27);
            txtPalabras.TabIndex = 89;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 33);
            label4.Name = "label4";
            label4.Size = new Size(217, 20);
            label4.TabIndex = 88;
            label4.Text = "Ingrese el conjunto de palabras";
            // 
            // txtLongitud
            // 
            txtLongitud.Location = new Point(34, 134);
            txtLongitud.Name = "txtLongitud";
            txtLongitud.Size = new Size(518, 27);
            txtLongitud.TabIndex = 94;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 111);
            label1.Name = "label1";
            label1.Size = new Size(199, 20);
            label1.TabIndex = 93;
            label1.Text = "Ingrese el número específico";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 480);
            Controls.Add(txtLongitud);
            Controls.Add(label1);
            Controls.Add(btnLongitudOrdenadas);
            Controls.Add(label2);
            Controls.Add(txtResultado);
            Controls.Add(txtPalabras);
            Controls.Add(label4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLongitudOrdenadas;
        private Label label2;
        private TextBox txtResultado;
        private TextBox txtPalabras;
        private Label label4;
        private TextBox txtLongitud;
        private Label label1;
    }
}
