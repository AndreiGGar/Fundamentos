namespace Fundamentos
{
    partial class Form12Metodos
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
            this.dobleValor = new System.Windows.Forms.Button();
            this.numero = new System.Windows.Forms.TextBox();
            this.dobleRef = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.objetoRef = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numbers = new System.Windows.Forms.TextBox();
            this.chars = new System.Windows.Forms.TextBox();
            this.box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número";
            // 
            // dobleValor
            // 
            this.dobleValor.Location = new System.Drawing.Point(71, 86);
            this.dobleValor.Name = "dobleValor";
            this.dobleValor.Size = new System.Drawing.Size(99, 33);
            this.dobleValor.TabIndex = 1;
            this.dobleValor.Text = "Doble() Valor";
            this.dobleValor.UseVisualStyleBackColor = true;
            this.dobleValor.Click += new System.EventHandler(this.dobleValor_Click);
            // 
            // numero
            // 
            this.numero.Location = new System.Drawing.Point(115, 39);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(100, 23);
            this.numero.TabIndex = 2;
            // 
            // dobleRef
            // 
            this.dobleRef.Location = new System.Drawing.Point(71, 135);
            this.dobleRef.Name = "dobleRef";
            this.dobleRef.Size = new System.Drawing.Size(99, 54);
            this.dobleRef.TabIndex = 3;
            this.dobleRef.Text = "Doble() Referencia";
            this.dobleRef.UseVisualStyleBackColor = true;
            this.dobleRef.Click += new System.EventHandler(this.dobleRef_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(88, 274);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(59, 15);
            this.result.TabIndex = 4;
            this.result.Text = "Resultado";
            // 
            // objetoRef
            // 
            this.objetoRef.Location = new System.Drawing.Point(71, 206);
            this.objetoRef.Name = "objetoRef";
            this.objetoRef.Size = new System.Drawing.Size(99, 54);
            this.objetoRef.TabIndex = 5;
            this.objetoRef.Text = "Objeto() Referencia";
            this.objetoRef.UseVisualStyleBackColor = true;
            this.objetoRef.Click += new System.EventHandler(this.objetoRef_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Números";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Letras";
            // 
            // numbers
            // 
            this.numbers.Location = new System.Drawing.Point(314, 92);
            this.numbers.Name = "numbers";
            this.numbers.Size = new System.Drawing.Size(158, 23);
            this.numbers.TabIndex = 8;
            this.numbers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbers_KeyPress);
            // 
            // chars
            // 
            this.chars.Location = new System.Drawing.Point(314, 132);
            this.chars.Name = "chars";
            this.chars.Size = new System.Drawing.Size(158, 23);
            this.chars.TabIndex = 9;
            this.chars.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chars_KeyPress);
            // 
            // box
            // 
            this.box.Location = new System.Drawing.Point(273, 187);
            this.box.Multiline = true;
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(174, 73);
            this.box.TabIndex = 10;
            this.box.MouseMove += new System.Windows.Forms.MouseEventHandler(this.box_MouseMove);
            // 
            // Form12Metodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 298);
            this.Controls.Add(this.box);
            this.Controls.Add(this.chars);
            this.Controls.Add(this.numbers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.objetoRef);
            this.Controls.Add(this.result);
            this.Controls.Add(this.dobleRef);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.dobleValor);
            this.Controls.Add(this.label1);
            this.Name = "Form12Metodos";
            this.Text = "Form12Metodos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button dobleValor;
        private TextBox numero;
        private Button dobleRef;
        private Label result;
        private Button objetoRef;
        private Label label2;
        private Label label3;
        private TextBox numbers;
        private TextBox chars;
        private TextBox box;
    }
}