namespace Fundamentos
{
    partial class Form20TemperaturaAnual
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
            this.meses = new System.Windows.Forms.ListBox();
            this.max = new System.Windows.Forms.TextBox();
            this.min = new System.Windows.Forms.TextBox();
            this.average = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.generar = new System.Windows.Forms.Button();
            this.anyos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.maxA = new System.Windows.Forms.TextBox();
            this.minA = new System.Windows.Forms.TextBox();
            this.averageA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // meses
            // 
            this.meses.FormattingEnabled = true;
            this.meses.ItemHeight = 15;
            this.meses.Location = new System.Drawing.Point(12, 129);
            this.meses.Name = "meses";
            this.meses.Size = new System.Drawing.Size(186, 274);
            this.meses.TabIndex = 30;
            this.meses.SelectedIndexChanged += new System.EventHandler(this.meses_SelectedIndexChanged);
            // 
            // max
            // 
            this.max.Location = new System.Drawing.Point(329, 209);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(68, 23);
            this.max.TabIndex = 29;
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(329, 262);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(68, 23);
            this.min.TabIndex = 28;
            // 
            // average
            // 
            this.average.Location = new System.Drawing.Point(329, 316);
            this.average.Name = "average";
            this.average.Size = new System.Drawing.Size(68, 23);
            this.average.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "Media mensual";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Temperatura mínima";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Temperatura máxima";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Meses";
            // 
            // generar
            // 
            this.generar.Location = new System.Drawing.Point(356, 59);
            this.generar.Name = "generar";
            this.generar.Size = new System.Drawing.Size(148, 40);
            this.generar.TabIndex = 22;
            this.generar.Text = "Generar temperaturas";
            this.generar.UseVisualStyleBackColor = true;
            this.generar.Click += new System.EventHandler(this.generar_Click);
            // 
            // anyos
            // 
            this.anyos.FormattingEnabled = true;
            this.anyos.Location = new System.Drawing.Point(12, 59);
            this.anyos.Name = "anyos";
            this.anyos.Size = new System.Drawing.Size(186, 23);
            this.anyos.TabIndex = 31;
            this.anyos.SelectedIndexChanged += new System.EventHandler(this.anyos_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 32;
            this.label5.Text = "Años";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(292, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 15);
            this.label6.TabIndex = 33;
            this.label6.Text = "Datos del mes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(449, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 40;
            this.label7.Text = "Datos del año";
            // 
            // maxA
            // 
            this.maxA.Location = new System.Drawing.Point(486, 209);
            this.maxA.Name = "maxA";
            this.maxA.Size = new System.Drawing.Size(68, 23);
            this.maxA.TabIndex = 39;
            // 
            // minA
            // 
            this.minA.Location = new System.Drawing.Point(486, 262);
            this.minA.Name = "minA";
            this.minA.Size = new System.Drawing.Size(68, 23);
            this.minA.TabIndex = 38;
            // 
            // averageA
            // 
            this.averageA.Location = new System.Drawing.Point(486, 316);
            this.averageA.Name = "averageA";
            this.averageA.Size = new System.Drawing.Size(68, 23);
            this.averageA.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(463, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 36;
            this.label8.Text = "Media anual";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(463, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 15);
            this.label9.TabIndex = 35;
            this.label9.Text = "Temperatura mínima";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(463, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 15);
            this.label10.TabIndex = 34;
            this.label10.Text = "Temperatura máxima";
            // 
            // Form20TemperaturaAnual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 444);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.maxA);
            this.Controls.Add(this.minA);
            this.Controls.Add(this.averageA);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.anyos);
            this.Controls.Add(this.meses);
            this.Controls.Add(this.max);
            this.Controls.Add(this.min);
            this.Controls.Add(this.average);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generar);
            this.Name = "Form20TemperaturaAnual";
            this.Text = "Form20TemperaturaAnual";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox meses;
        private TextBox max;
        private TextBox min;
        private TextBox average;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button generar;
        private ComboBox anyos;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox maxA;
        private TextBox minA;
        private TextBox averageA;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}