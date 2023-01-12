namespace Fundamentos
{
    partial class Form07SumarNumeros
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
            this.numbers = new System.Windows.Forms.TextBox();
            this.sum = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Introduzca números";
            // 
            // numbers
            // 
            this.numbers.Location = new System.Drawing.Point(34, 58);
            this.numbers.Name = "numbers";
            this.numbers.Size = new System.Drawing.Size(315, 23);
            this.numbers.TabIndex = 2;
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(111, 106);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(143, 35);
            this.sum.TabIndex = 3;
            this.sum.Text = "Sumar Números";
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(34, 173);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(59, 15);
            this.result.TabIndex = 4;
            this.result.Text = "Resultado";
            // 
            // Form07SumarNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 225);
            this.Controls.Add(this.result);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.numbers);
            this.Controls.Add(this.label1);
            this.Name = "Form07SumarNumeros";
            this.Text = "Form07SumarNumeros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox numbers;
        private Button sum;
        private Label result;
    }
}