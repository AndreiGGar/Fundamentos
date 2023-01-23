namespace Fundamentos
{
    partial class Form23XMLObjeto
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
            this.label4 = new System.Windows.Forms.Label();
            this.raza = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.write = new System.Windows.Forms.Button();
            this.read = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Raza";
            // 
            // raza
            // 
            this.raza.Location = new System.Drawing.Point(27, 135);
            this.raza.Name = "raza";
            this.raza.Size = new System.Drawing.Size(191, 23);
            this.raza.TabIndex = 24;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(27, 55);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(191, 23);
            this.name.TabIndex = 23;
            // 
            // write
            // 
            this.write.Location = new System.Drawing.Point(291, 172);
            this.write.Name = "write";
            this.write.Size = new System.Drawing.Size(128, 40);
            this.write.TabIndex = 22;
            this.write.Text = "Guardar Dato";
            this.write.UseVisualStyleBackColor = true;
            this.write.Click += new System.EventHandler(this.write_Click);
            // 
            // read
            // 
            this.read.Location = new System.Drawing.Point(291, 87);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(128, 40);
            this.read.TabIndex = 21;
            this.read.Text = "Leer Dato";
            this.read.UseVisualStyleBackColor = true;
            this.read.Click += new System.EventHandler(this.read_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Edad";
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(27, 213);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(61, 23);
            this.age.TabIndex = 27;
            // 
            // Form23XMLObjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 278);
            this.Controls.Add(this.age);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.raza);
            this.Controls.Add(this.name);
            this.Controls.Add(this.write);
            this.Controls.Add(this.read);
            this.Controls.Add(this.label2);
            this.Name = "Form23XMLObjeto";
            this.Text = "Form23XMLObjeto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private TextBox raza;
        private TextBox name;
        private Button write;
        private Button read;
        private Label label2;
        private Label label1;
        private TextBox age;
    }
}