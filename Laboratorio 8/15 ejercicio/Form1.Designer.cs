﻿namespace _15_ejercicio
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
            btnNumerosPrimos = new Button();
            label3 = new Label();
            txtResultado = new TextBox();
            txtNumeros = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnNumerosPrimos
            // 
            btnNumerosPrimos.Image = (Image)resources.GetObject("btnNumerosPrimos.Image");
            btnNumerosPrimos.Location = new Point(411, 154);
            btnNumerosPrimos.Name = "btnNumerosPrimos";
            btnNumerosPrimos.Size = new Size(149, 163);
            btnNumerosPrimos.TabIndex = 78;
            btnNumerosPrimos.Text = "Encontrar números primos";
            btnNumerosPrimos.TextAlign = ContentAlignment.BottomCenter;
            btnNumerosPrimos.UseVisualStyleBackColor = true;
            btnNumerosPrimos.Click += btnNumerosPrimos_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 91);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 77;
            label3.Text = "Resultado";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(12, 123);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(336, 239);
            txtResultado.TabIndex = 76;
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(12, 39);
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(518, 27);
            txtNumeros.TabIndex = 75;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(221, 20);
            label1.TabIndex = 74;
            label1.Text = "Ingrese el conjunto de numeros ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 395);
            Controls.Add(btnNumerosPrimos);
            Controls.Add(label3);
            Controls.Add(txtResultado);
            Controls.Add(txtNumeros);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Ejercicio 15";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNumerosPrimos;
        private Label label3;
        private TextBox txtResultado;
        private TextBox txtNumeros;
        private Label label1;
    }
}
