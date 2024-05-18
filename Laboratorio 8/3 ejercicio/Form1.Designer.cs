namespace _3_ejercicio
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
            label3 = new Label();
            txtResultado = new TextBox();
            txtDivisor = new TextBox();
            label2 = new Label();
            txtNumeros = new TextBox();
            label1 = new Label();
            btnFiltrarNumeros = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 174);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 12;
            label3.Text = "Resultado";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(68, 197);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(389, 200);
            txtResultado.TabIndex = 11;
            // 
            // txtDivisor
            // 
            txtDivisor.Location = new Point(634, 86);
            txtDivisor.Name = "txtDivisor";
            txtDivisor.Size = new Size(125, 27);
            txtDivisor.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(634, 63);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 9;
            label2.Text = "Ingrese el divisor";
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(41, 86);
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(518, 27);
            txtNumeros.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 54);
            label1.Name = "label1";
            label1.Size = new Size(287, 20);
            label1.TabIndex = 7;
            label1.Text = "Ingrese los números separados por comas";
            // 
            // btnFiltrarNumeros
            // 
            btnFiltrarNumeros.Image = (Image)resources.GetObject("btnFiltrarNumeros.Image");
            btnFiltrarNumeros.Location = new Point(587, 235);
            btnFiltrarNumeros.Name = "btnFiltrarNumeros";
            btnFiltrarNumeros.Size = new Size(122, 105);
            btnFiltrarNumeros.TabIndex = 13;
            btnFiltrarNumeros.Text = "Filtrar Números";
            btnFiltrarNumeros.TextAlign = ContentAlignment.BottomCenter;
            btnFiltrarNumeros.UseVisualStyleBackColor = true;
            btnFiltrarNumeros.Click += btnFiltrarNumeros_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFiltrarNumeros);
            Controls.Add(label3);
            Controls.Add(txtResultado);
            Controls.Add(txtDivisor);
            Controls.Add(label2);
            Controls.Add(txtNumeros);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtResultado;
        private TextBox txtDivisor;
        private Label label2;
        private TextBox txtNumeros;
        private Label label1;
        private Button btnFiltrarNumeros;
    }
}
