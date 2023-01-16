namespace Fundamentos
{
    partial class Form16TablaMultiplicar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mostrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabla = new System.Windows.Forms.GroupBox();
            this.numero = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tabla.SuspendLayout();
            this.SuspendLayout();
            // 
            // mostrar
            // 
            this.mostrar.Location = new System.Drawing.Point(12, 79);
            this.mostrar.Name = "mostrar";
            this.mostrar.Size = new System.Drawing.Size(118, 39);
            this.mostrar.TabIndex = 0;
            this.mostrar.Text = "Mostrar tabla";
            this.mostrar.UseVisualStyleBackColor = true;
            this.mostrar.Click += new System.EventHandler(this.mostrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número";
            // 
            // tabla
            // 
            this.tabla.Controls.Add(this.textBox5);
            this.tabla.Controls.Add(this.textBox4);
            this.tabla.Controls.Add(this.textBox3);
            this.tabla.Controls.Add(this.textBox1);
            this.tabla.Controls.Add(this.textBox2);
            this.tabla.Location = new System.Drawing.Point(207, 25);
            this.tabla.Name = "tabla";
            this.tabla.Size = new System.Drawing.Size(165, 214);
            this.tabla.TabIndex = 2;
            this.tabla.TabStop = false;
            this.tabla.Text = "Tabla Multiplicar";
            // 
            // numero
            // 
            this.numero.Location = new System.Drawing.Point(12, 43);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(67, 23);
            this.numero.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(49, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(67, 23);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 23);
            this.textBox1.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(49, 99);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(67, 23);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(49, 128);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(67, 23);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(49, 157);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(67, 23);
            this.textBox5.TabIndex = 9;
            // 
            // Form16TablaMultiplicar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 305);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.tabla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mostrar);
            this.Name = "Form16TablaMultiplicar";
            this.Text = "Form16TablaMultiplicar";
            this.tabla.ResumeLayout(false);
            this.tabla.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button mostrar;
        private Label label1;
        private GroupBox tabla;
        private TextBox numero;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}