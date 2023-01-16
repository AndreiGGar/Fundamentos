namespace Fundamentos
{
    partial class Form17Temperaturas
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
            this.generar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mostrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.average = new System.Windows.Forms.TextBox();
            this.min = new System.Windows.Forms.TextBox();
            this.max = new System.Windows.Forms.TextBox();
            this.meses = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // generar
            // 
            this.generar.Location = new System.Drawing.Point(311, 64);
            this.generar.Name = "generar";
            this.generar.Size = new System.Drawing.Size(148, 40);
            this.generar.TabIndex = 0;
            this.generar.Text = "Generar meses";
            this.generar.UseVisualStyleBackColor = true;
            this.generar.Click += new System.EventHandler(this.generar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Meses";
            // 
            // mostrar
            // 
            this.mostrar.Location = new System.Drawing.Point(311, 131);
            this.mostrar.Name = "mostrar";
            this.mostrar.Size = new System.Drawing.Size(148, 40);
            this.mostrar.TabIndex = 4;
            this.mostrar.Text = "Mostrar datos";
            this.mostrar.UseVisualStyleBackColor = true;
            this.mostrar.Click += new System.EventHandler(this.mostrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Temperatura máxima";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Temperatura mínima";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Temperatura media";
            // 
            // average
            // 
            this.average.Location = new System.Drawing.Point(348, 329);
            this.average.Name = "average";
            this.average.Size = new System.Drawing.Size(68, 23);
            this.average.TabIndex = 8;
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(348, 275);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(68, 23);
            this.min.TabIndex = 9;
            // 
            // max
            // 
            this.max.Location = new System.Drawing.Point(348, 222);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(68, 23);
            this.max.TabIndex = 10;
            // 
            // meses
            // 
            this.meses.Location = new System.Drawing.Point(31, 64);
            this.meses.Name = "meses";
            this.meses.Size = new System.Drawing.Size(200, 385);
            this.meses.TabIndex = 11;
            this.meses.TabStop = false;
            this.meses.Text = "Meses";
            // 
            // Form17Temperaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 485);
            this.Controls.Add(this.meses);
            this.Controls.Add(this.max);
            this.Controls.Add(this.min);
            this.Controls.Add(this.average);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mostrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generar);
            this.Name = "Form17Temperaturas";
            this.Text = "Form17Temperaturas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button generar;
        private Label label1;
        private Button mostrar;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox average;
        private TextBox min;
        private TextBox max;
        private GroupBox meses;
    }
}