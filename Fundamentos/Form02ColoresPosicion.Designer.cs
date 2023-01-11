namespace Fundamentos
{
    partial class Form02ColoresPosicion
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.posicionX = new System.Windows.Forms.TextBox();
            this.posicionY = new System.Windows.Forms.TextBox();
            this.red = new System.Windows.Forms.TextBox();
            this.green = new System.Windows.Forms.TextBox();
            this.blue = new System.Windows.Forms.TextBox();
            this.coord = new System.Windows.Forms.Button();
            this.fondo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Posicion X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Posicion Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Red";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Green";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Blue";
            // 
            // posicionX
            // 
            this.posicionX.Location = new System.Drawing.Point(112, 50);
            this.posicionX.Name = "posicionX";
            this.posicionX.Size = new System.Drawing.Size(100, 23);
            this.posicionX.TabIndex = 5;
            // 
            // posicionY
            // 
            this.posicionY.Location = new System.Drawing.Point(112, 79);
            this.posicionY.Name = "posicionY";
            this.posicionY.Size = new System.Drawing.Size(100, 23);
            this.posicionY.TabIndex = 6;
            // 
            // red
            // 
            this.red.Location = new System.Drawing.Point(112, 114);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(100, 23);
            this.red.TabIndex = 7;
            // 
            // green
            // 
            this.green.Location = new System.Drawing.Point(112, 143);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(100, 23);
            this.green.TabIndex = 8;
            // 
            // blue
            // 
            this.blue.Location = new System.Drawing.Point(112, 172);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(100, 23);
            this.blue.TabIndex = 9;
            // 
            // coord
            // 
            this.coord.Location = new System.Drawing.Point(278, 53);
            this.coord.Name = "coord";
            this.coord.Size = new System.Drawing.Size(140, 37);
            this.coord.TabIndex = 10;
            this.coord.Text = "Cambiar coordenadas";
            this.coord.UseVisualStyleBackColor = true;
            this.coord.Click += new System.EventHandler(this.coord_Click);
            // 
            // fondo
            // 
            this.fondo.Location = new System.Drawing.Point(278, 143);
            this.fondo.Name = "fondo";
            this.fondo.Size = new System.Drawing.Size(140, 37);
            this.fondo.TabIndex = 11;
            this.fondo.Text = "Cambiar fondo";
            this.fondo.UseVisualStyleBackColor = true;
            this.fondo.Click += new System.EventHandler(this.fondo_Click);
            // 
            // Form02ColoresPosicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 340);
            this.Controls.Add(this.fondo);
            this.Controls.Add(this.coord);
            this.Controls.Add(this.blue);
            this.Controls.Add(this.green);
            this.Controls.Add(this.red);
            this.Controls.Add(this.posicionY);
            this.Controls.Add(this.posicionX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form02ColoresPosicion";
            this.Text = "Form02ColoresPosicion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox posicionX;
        private TextBox posicionY;
        private TextBox red;
        private TextBox green;
        private TextBox blue;
        private Button coord;
        private Button fondo;
    }
}