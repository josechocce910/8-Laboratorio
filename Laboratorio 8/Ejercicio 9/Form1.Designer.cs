namespace _9_ejercicio
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
            btnFiltrarPorLongitud = new Button();
            label3 = new Label();
            txtResultado = new TextBox();
            txtPalabras = new TextBox();
            label1 = new Label();
            txtLongitud = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnFiltrarPorLongitud
            // 
            btnFiltrarPorLongitud.Image = (Image)resources.GetObject("btnFiltrarPorLongitud.Image");
            btnFiltrarPorLongitud.Location = new Point(427, 202);
            btnFiltrarPorLongitud.Name = "btnFiltrarPorLongitud";
            btnFiltrarPorLongitud.Size = new Size(149, 163);
            btnFiltrarPorLongitud.TabIndex = 44;
            btnFiltrarPorLongitud.Text = "Filtrar por Longitud";
            btnFiltrarPorLongitud.TextAlign = ContentAlignment.BottomCenter;
            btnFiltrarPorLongitud.UseVisualStyleBackColor = true;
            btnFiltrarPorLongitud.Click += btnFiltrarPorLongitud_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 160);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 43;
            label3.Text = "Resultado";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(32, 192);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(336, 239);
            txtResultado.TabIndex = 42;
            // 
            // txtPalabras
            // 
            txtPalabras.Location = new Point(32, 47);
            txtPalabras.Name = "txtPalabras";
            txtPalabras.Size = new Size(518, 27);
            txtPalabras.TabIndex = 41;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 24);
            label1.Name = "label1";
            label1.Size = new Size(285, 20);
            label1.TabIndex = 40;
            label1.Text = "Ingrese las palabras separadas por comas";
            // 
            // txtLongitud
            // 
            txtLongitud.Location = new Point(32, 115);
            txtLongitud.Name = "txtLongitud";
            txtLongitud.Size = new Size(518, 27);
            txtLongitud.TabIndex = 46;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 92);
            label2.Name = "label2";
            label2.Size = new Size(213, 20);
            label2.TabIndex = 45;
            label2.Text = "Ingrese en número de longitud";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 464);
            Controls.Add(txtLongitud);
            Controls.Add(label2);
            Controls.Add(btnFiltrarPorLongitud);
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

        private Button btnFiltrarPorLongitud;
        private Label label3;
        private TextBox txtResultado;
        private TextBox txtPalabras;
        private Label label1;
        private TextBox txtLongitud;
        private Label label2;
    }
}
