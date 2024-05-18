namespace _19_ejerciccio
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
            btnOrdenadosNoDuplicados = new Button();
            label2 = new Label();
            txtResultado = new TextBox();
            txtNumeros = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnOrdenadosNoDuplicados
            // 
            btnOrdenadosNoDuplicados.Image = (Image)resources.GetObject("btnOrdenadosNoDuplicados.Image");
            btnOrdenadosNoDuplicados.Location = new Point(366, 156);
            btnOrdenadosNoDuplicados.Name = "btnOrdenadosNoDuplicados";
            btnOrdenadosNoDuplicados.Size = new Size(235, 198);
            btnOrdenadosNoDuplicados.TabIndex = 106;
            btnOrdenadosNoDuplicados.Text = "Encontrar No Duplicadas Ordenados de Menor a Mayor\r\n\r\n";
            btnOrdenadosNoDuplicados.TextAlign = ContentAlignment.BottomCenter;
            btnOrdenadosNoDuplicados.UseVisualStyleBackColor = true;
            btnOrdenadosNoDuplicados.Click += btnOrdenadosNoDuplicados_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 109);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 105;
            label2.Text = "Resultado";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(16, 132);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(336, 239);
            txtResultado.TabIndex = 104;
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(12, 29);
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(518, 27);
            txtNumeros.TabIndex = 103;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 6);
            label4.Name = "label4";
            label4.Size = new Size(217, 20);
            label4.TabIndex = 102;
            label4.Text = "Ingrese el conjunto de números\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 413);
            Controls.Add(btnOrdenadosNoDuplicados);
            Controls.Add(label2);
            Controls.Add(txtResultado);
            Controls.Add(txtNumeros);
            Controls.Add(label4);
            Name = "Form1";
            Text = "Ejercicio 19";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOrdenadosNoDuplicados;
        private Label label2;
        private TextBox txtResultado;
        private TextBox txtNumeros;
        private Label label4;
    }
}
