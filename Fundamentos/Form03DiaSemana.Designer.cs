﻿namespace Fundamentos
{
    partial class Form03DiaSemana
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.day = new System.Windows.Forms.TextBox();
            this.month = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Día";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Año";
            // 
            // day
            // 
            this.day.Location = new System.Drawing.Point(83, 33);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(100, 23);
            this.day.TabIndex = 4;
            // 
            // month
            // 
            this.month.Location = new System.Drawing.Point(83, 67);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(100, 23);
            this.month.TabIndex = 5;
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(83, 100);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(100, 23);
            this.year.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 61);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calcular día";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(162, 147);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(29, 15);
            this.result.TabIndex = 8;
            this.result.Text = "DÍA:";
            // 
            // Form03DiaSemana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 215);
            this.Controls.Add(this.result);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.year);
            this.Controls.Add(this.month);
            this.Controls.Add(this.day);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form03DiaSemana";
            this.Text = "Form03DiaSemana";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox day;
        private TextBox month;
        private TextBox year;
        private Button button1;
        private Label result;
    }
}