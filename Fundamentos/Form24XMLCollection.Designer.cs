namespace Fundamentos
{
    partial class Form24XMLCollection
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
            this.age = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.raza = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.write = new System.Windows.Forms.Button();
            this.read = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.list = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(62, 295);
            this.age.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(69, 27);
            this.age.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Raza";
            // 
            // raza
            // 
            this.raza.Location = new System.Drawing.Point(62, 191);
            this.raza.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.raza.Name = "raza";
            this.raza.Size = new System.Drawing.Size(218, 27);
            this.raza.TabIndex = 32;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(62, 84);
            this.name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(218, 27);
            this.name.TabIndex = 31;
            // 
            // write
            // 
            this.write.Location = new System.Drawing.Point(363, 281);
            this.write.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.write.Name = "write";
            this.write.Size = new System.Drawing.Size(146, 53);
            this.write.TabIndex = 30;
            this.write.Text = "Guardar Registros";
            this.write.UseVisualStyleBackColor = true;
            this.write.Click += new System.EventHandler(this.write_Click);
            // 
            // read
            // 
            this.read.Location = new System.Drawing.Point(363, 177);
            this.read.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(146, 53);
            this.read.TabIndex = 29;
            this.read.Text = "Leer Registros";
            this.read.UseVisualStyleBackColor = true;
            this.read.Click += new System.EventHandler(this.read_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nombre";
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.ItemHeight = 20;
            this.list.Location = new System.Drawing.Point(574, 84);
            this.list.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(207, 344);
            this.list.TabIndex = 36;
            this.list.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(574, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Mascotas";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(363, 71);
            this.add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(146, 53);
            this.add.TabIndex = 39;
            this.add.Text = "Nueva Mascota";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(178, 295);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(329, 399);
            this.search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(95, 31);
            this.search.TabIndex = 41;
            this.search.Text = "Examinar...";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // Form24XMLCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 481);
            this.Controls.Add(this.search);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.list);
            this.Controls.Add(this.age);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.raza);
            this.Controls.Add(this.name);
            this.Controls.Add(this.write);
            this.Controls.Add(this.read);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form24XMLCollection";
            this.Text = "Form24XMLCollection";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox age;
        private Label label1;
        private Label label4;
        private TextBox raza;
        private TextBox name;
        private Button write;
        private Button read;
        private Label label2;
        private ListBox list;
        private Label label3;
        private Button add;
        private PictureBox pictureBox1;
        private Button search;
    }
}