namespace Fundamentos
{
    partial class Form22Mascotas
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
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.content = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.write = new System.Windows.Forms.Button();
            this.read = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.raza = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mascotas";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(328, 52);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(191, 23);
            this.name.TabIndex = 16;
            // 
            // content
            // 
            this.content.Location = new System.Drawing.Point(31, 52);
            this.content.Multiline = true;
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(191, 189);
            this.content.TabIndex = 15;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(533, 78);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(71, 28);
            this.add.TabIndex = 14;
            this.add.Text = "Agregar";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // write
            // 
            this.write.Location = new System.Drawing.Point(78, 305);
            this.write.Name = "write";
            this.write.Size = new System.Drawing.Size(95, 40);
            this.write.TabIndex = 13;
            this.write.Text = "Guardar Registros";
            this.write.UseVisualStyleBackColor = true;
            this.write.Click += new System.EventHandler(this.write_Click);
            // 
            // read
            // 
            this.read.Location = new System.Drawing.Point(78, 259);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(95, 40);
            this.read.TabIndex = 12;
            this.read.Text = "Leer Registros";
            this.read.UseVisualStyleBackColor = true;
            this.read.Click += new System.EventHandler(this.read_Click);
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.ItemHeight = 15;
            this.list.Location = new System.Drawing.Point(328, 193);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(249, 184);
            this.list.TabIndex = 11;
            this.list.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Contenido File";
            // 
            // raza
            // 
            this.raza.Location = new System.Drawing.Point(328, 109);
            this.raza.Name = "raza";
            this.raza.Size = new System.Drawing.Size(191, 23);
            this.raza.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Raza";
            // 
            // Form22Mascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 398);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.raza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name);
            this.Controls.Add(this.content);
            this.Controls.Add(this.add);
            this.Controls.Add(this.write);
            this.Controls.Add(this.read);
            this.Controls.Add(this.list);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form22Mascotas";
            this.Text = "s";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private TextBox name;
        private TextBox content;
        private Button add;
        private Button write;
        private Button read;
        private ListBox list;
        private Label label2;
        private Label label1;
        private TextBox raza;
        private Label label4;
    }
}