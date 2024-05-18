namespace _12_ejercicio
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
            btnMayorAMenor = new Button();
            label3 = new Label();
            txtResultado = new TextBox();
            txtNumeros = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnMayorAMenor
            // 
            btnMayorAMenor.Image = (Image)resources.GetObject("btnMayorAMenor.Image");
            btnMayorAMenor.Location = new Point(416, 191);
            btnMayorAMenor.Name = "btnMayorAMenor";
            btnMayorAMenor.Size = new Size(149, 163);
            btnMayorAMenor.TabIndex = 63;
            btnMayorAMenor.Text = "Ordenar de Mayor a Menor";
            btnMayorAMenor.TextAlign = ContentAlignment.BottomCenter;
            btnMayorAMenor.UseVisualStyleBackColor = true;
            btnMayorAMenor.Click += btnMayorAMenor_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 111);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 62;
            label3.Text = "Resultado";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(12, 143);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(336, 239);
            txtResultado.TabIndex = 61;
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(12, 59);
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(518, 27);
            txtNumeros.TabIndex = 60;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(345, 20);
            label1.TabIndex = 59;
            label1.Text = "Ingrese el conjunto de numeros que desea ordenar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 417);
            Controls.Add(btnMayorAMenor);
            Controls.Add(label3);
            Controls.Add(txtResultado);
            Controls.Add(txtNumeros);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMayorAMenor;
        private Label label3;
        private TextBox txtResultado;
        private TextBox txtNumeros;
        private Label label1;
    }
}
