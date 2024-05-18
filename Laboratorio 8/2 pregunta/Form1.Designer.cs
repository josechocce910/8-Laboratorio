namespace _2_pregunta
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
            label1 = new Label();
            txtPalabras = new TextBox();
            txtLetra = new TextBox();
            label2 = new Label();
            btnFiltrarPalabras = new Button();
            txtResultado = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 29);
            label1.Name = "label1";
            label1.Size = new Size(285, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese las palabras separadas por comas";
            // 
            // txtPalabras
            // 
            txtPalabras.Location = new Point(22, 61);
            txtPalabras.Name = "txtPalabras";
            txtPalabras.Size = new Size(518, 27);
            txtPalabras.TabIndex = 1;
            txtPalabras.TextChanged += txtPalabras_TextChanged;
            // 
            // txtLetra
            // 
            txtLetra.Location = new Point(615, 61);
            txtLetra.Name = "txtLetra";
            txtLetra.Size = new Size(125, 27);
            txtLetra.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(615, 38);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 2;
            label2.Text = "Ingrese la letra";
            // 
            // btnFiltrarPalabras
            // 
            btnFiltrarPalabras.Image = (Image)resources.GetObject("btnFiltrarPalabras.Image");
            btnFiltrarPalabras.Location = new Point(600, 267);
            btnFiltrarPalabras.Name = "btnFiltrarPalabras";
            btnFiltrarPalabras.Size = new Size(122, 105);
            btnFiltrarPalabras.TabIndex = 4;
            btnFiltrarPalabras.Text = "Filtrar Palabras";
            btnFiltrarPalabras.TextAlign = ContentAlignment.BottomCenter;
            btnFiltrarPalabras.UseVisualStyleBackColor = true;
            btnFiltrarPalabras.Click += btnFiltrarPalabras_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(49, 172);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(389, 200);
            txtResultado.TabIndex = 5;
            txtResultado.TextChanged += txtResultado_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 149);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 6;
            label3.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(txtResultado);
            Controls.Add(btnFiltrarPalabras);
            Controls.Add(txtLetra);
            Controls.Add(label2);
            Controls.Add(txtPalabras);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPalabras;
        private TextBox txtLetra;
        private Label label2;
        private Button btnFiltrarPalabras;
        private TextBox txtResultado;
        private Label label3;
    }
}
