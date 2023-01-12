namespace Fundamentos
{
    partial class Form10Random
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
            this.list = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.generate = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.TextBox();
            this.even = new System.Windows.Forms.TextBox();
            this.odd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.ItemHeight = 15;
            this.list.Location = new System.Drawing.Point(40, 56);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(120, 154);
            this.list.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Números";
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(237, 56);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(75, 23);
            this.generate.TabIndex = 2;
            this.generate.Text = "Generar";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(237, 94);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(75, 23);
            this.data.TabIndex = 3;
            this.data.Text = "Mostrar datos";
            this.data.UseVisualStyleBackColor = true;
            this.data.Click += new System.EventHandler(this.data_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Suma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pares";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Impares";
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(263, 147);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(100, 23);
            this.sum.TabIndex = 7;
            // 
            // even
            // 
            this.even.Location = new System.Drawing.Point(263, 179);
            this.even.Name = "even";
            this.even.Size = new System.Drawing.Size(100, 23);
            this.even.TabIndex = 8;
            // 
            // odd
            // 
            this.odd.Location = new System.Drawing.Point(263, 211);
            this.odd.Name = "odd";
            this.odd.Size = new System.Drawing.Size(100, 23);
            this.odd.TabIndex = 9;
            // 
            // Form10Random
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 309);
            this.Controls.Add(this.odd);
            this.Controls.Add(this.even);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.data);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list);
            this.Name = "Form10Random";
            this.Text = "Form10Random";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox list;
        private Label label1;
        private Button generate;
        private Button data;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox sum;
        private TextBox even;
        private TextBox odd;
    }
}