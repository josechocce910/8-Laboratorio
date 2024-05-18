namespace Laboratorio_8
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
            txtNumeros = new TextBox();
            btnMostrarPrimos = new Button();
            label2 = new Label();
            txtResultado = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 35);
            label1.Name = "label1";
            label1.Size = new Size(361, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese los números calculados separados por comas";
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(30, 58);
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(361, 27);
            txtNumeros.TabIndex = 1;
            txtNumeros.TextChanged += txtNumeros_TextChanged;
            // 
            // btnMostrarPrimos
            // 
            btnMostrarPrimos.Image = (Image)resources.GetObject("btnMostrarPrimos.Image");
            btnMostrarPrimos.Location = new Point(109, 216);
            btnMostrarPrimos.Name = "btnMostrarPrimos";
            btnMostrarPrimos.Size = new Size(142, 108);
            btnMostrarPrimos.TabIndex = 2;
            btnMostrarPrimos.Text = "Mostrar Primos";
            btnMostrarPrimos.TextAlign = ContentAlignment.BottomCenter;
            btnMostrarPrimos.UseVisualStyleBackColor = true;
            btnMostrarPrimos.Click += btnMostrarPrimos_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(438, 216);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 3;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(399, 140);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(376, 282);
            txtResultado.TabIndex = 4;
            txtResultado.TextChanged += txtResultado_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(399, 117);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 5;
            label3.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(txtResultado);
            Controls.Add(label2);
            Controls.Add(btnMostrarPrimos);
            Controls.Add(txtNumeros);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumeros;
        private Button btnMostrarPrimos;
        private Label label2;
        private TextBox txtResultado;
        private Label label3;
    }
}
