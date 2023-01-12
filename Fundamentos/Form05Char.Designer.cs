namespace Fundamentos
{
    partial class Form05Char
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
            this.label1 = new System.Windows.Forms.Label();
            this.letras = new System.Windows.Forms.TextBox();
            this.numeros = new System.Windows.Forms.TextBox();
            this.simbolos = new System.Windows.Forms.TextBox();
            this.puntuacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ascii = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Letras";
            // 
            // letras
            // 
            this.letras.Location = new System.Drawing.Point(50, 63);
            this.letras.Multiline = true;
            this.letras.Name = "letras";
            this.letras.Size = new System.Drawing.Size(196, 84);
            this.letras.TabIndex = 1;
            // 
            // numeros
            // 
            this.numeros.Location = new System.Drawing.Point(310, 63);
            this.numeros.Multiline = true;
            this.numeros.Name = "numeros";
            this.numeros.Size = new System.Drawing.Size(196, 84);
            this.numeros.TabIndex = 2;
            // 
            // simbolos
            // 
            this.simbolos.Location = new System.Drawing.Point(50, 194);
            this.simbolos.Multiline = true;
            this.simbolos.Name = "simbolos";
            this.simbolos.Size = new System.Drawing.Size(196, 84);
            this.simbolos.TabIndex = 3;
            // 
            // puntuacion
            // 
            this.puntuacion.Location = new System.Drawing.Point(310, 194);
            this.puntuacion.Multiline = true;
            this.puntuacion.Name = "puntuacion";
            this.puntuacion.Size = new System.Drawing.Size(196, 84);
            this.puntuacion.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Números";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Símbolos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Puntuación";
            // 
            // ascii
            // 
            this.ascii.Location = new System.Drawing.Point(206, 305);
            this.ascii.Name = "ascii";
            this.ascii.Size = new System.Drawing.Size(122, 23);
            this.ascii.TabIndex = 8;
            this.ascii.Text = "Recorrer ASCII";
            this.ascii.UseVisualStyleBackColor = true;
            this.ascii.Click += new System.EventHandler(this.ascii_Click);
            // 
            // Form05Char
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 340);
            this.Controls.Add(this.ascii);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.puntuacion);
            this.Controls.Add(this.simbolos);
            this.Controls.Add(this.numeros);
            this.Controls.Add(this.letras);
            this.Controls.Add(this.label1);
            this.Name = "Form05Char";
            this.Text = "Form05Char";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox letras;
        private TextBox numeros;
        private TextBox simbolos;
        private TextBox puntuacion;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button ascii;
    }
}