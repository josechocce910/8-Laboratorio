namespace _6_ejercicio
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
            btnEncontrarUnicos = new Button();
            label3 = new Label();
            txtResultado = new TextBox();
            txtNumeros2 = new TextBox();
            label2 = new Label();
            txtNumeros1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnEncontrarUnicos
            // 
            btnEncontrarUnicos.Image = (Image)resources.GetObject("btnEncontrarUnicos.Image");
            btnEncontrarUnicos.Location = new Point(12, 258);
            btnEncontrarUnicos.Name = "btnEncontrarUnicos";
            btnEncontrarUnicos.Size = new Size(149, 163);
            btnEncontrarUnicos.TabIndex = 27;
            btnEncontrarUnicos.Text = "Encontrar Únicos";
            btnEncontrarUnicos.TextAlign = ContentAlignment.BottomCenter;
            btnEncontrarUnicos.UseVisualStyleBackColor = true;
            btnEncontrarUnicos.Click += btnEncontrarUnicos_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(615, 115);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 26;
            label3.Text = "Resultado";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(615, 138);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(336, 283);
            txtResultado.TabIndex = 25;
            // 
            // txtNumeros2
            // 
            txtNumeros2.Location = new Point(12, 138);
            txtNumeros2.Name = "txtNumeros2";
            txtNumeros2.Size = new Size(518, 27);
            txtNumeros2.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 115);
            label2.Name = "label2";
            label2.Size = new Size(418, 20);
            label2.TabIndex = 23;
            label2.Text = "Ingrese el segundo conjunto de números separados por coma";
            // 
            // txtNumeros1
            // 
            txtNumeros1.Location = new Point(12, 56);
            txtNumeros1.Name = "txtNumeros1";
            txtNumeros1.Size = new Size(518, 27);
            txtNumeros1.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(411, 20);
            label1.TabIndex = 21;
            label1.Text = "Ingrese el primer conjunto de números separados por comas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 450);
            Controls.Add(btnEncontrarUnicos);
            Controls.Add(label3);
            Controls.Add(txtResultado);
            Controls.Add(txtNumeros2);
            Controls.Add(label2);
            Controls.Add(txtNumeros1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEncontrarUnicos;
        private Label label3;
        private TextBox txtResultado;
        private TextBox txtNumeros2;
        private Label label2;
        private TextBox txtNumeros1;
        private Label label1;
    }
}
