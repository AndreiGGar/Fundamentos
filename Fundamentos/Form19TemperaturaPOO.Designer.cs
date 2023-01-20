namespace Fundamentos
{
    partial class Form19TemperaturaPOO
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
            this.max = new System.Windows.Forms.TextBox();
            this.min = new System.Windows.Forms.TextBox();
            this.average = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.generar = new System.Windows.Forms.Button();
            this.meses = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // max
            // 
            this.max.Location = new System.Drawing.Point(335, 167);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(68, 23);
            this.max.TabIndex = 20;
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(335, 220);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(68, 23);
            this.min.TabIndex = 19;
            // 
            // average
            // 
            this.average.Location = new System.Drawing.Point(335, 274);
            this.average.Name = "average";
            this.average.Size = new System.Drawing.Size(68, 23);
            this.average.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Temperatura media";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Temperatura mínima";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Temperatura máxima";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Meses";
            // 
            // generar
            // 
            this.generar.Location = new System.Drawing.Point(303, 48);
            this.generar.Name = "generar";
            this.generar.Size = new System.Drawing.Size(148, 40);
            this.generar.TabIndex = 12;
            this.generar.Text = "Generar meses";
            this.generar.UseVisualStyleBackColor = true;
            this.generar.Click += new System.EventHandler(this.generar_Click);
            // 
            // meses
            // 
            this.meses.FormattingEnabled = true;
            this.meses.ItemHeight = 15;
            this.meses.Location = new System.Drawing.Point(23, 48);
            this.meses.Name = "meses";
            this.meses.Size = new System.Drawing.Size(212, 379);
            this.meses.TabIndex = 21;
            this.meses.SelectedIndexChanged += new System.EventHandler(this.meses_SelectedIndexChanged);
            // 
            // Form19TemperaturaPOO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 457);
            this.Controls.Add(this.meses);
            this.Controls.Add(this.max);
            this.Controls.Add(this.min);
            this.Controls.Add(this.average);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generar);
            this.Name = "Form19TemperaturaPOO";
            this.Text = "Form19TemperaturaPOO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox max;
        private TextBox min;
        private TextBox average;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button generar;
        private ListBox meses;
    }
}