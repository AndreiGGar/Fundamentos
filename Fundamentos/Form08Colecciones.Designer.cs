namespace Fundamentos
{
    partial class Form08Colecciones
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
            this.lstElementos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.element = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.deleteAll = new System.Windows.Forms.Button();
            this.lblIndex = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstElementos
            // 
            this.lstElementos.FormattingEnabled = true;
            this.lstElementos.ItemHeight = 15;
            this.lstElementos.Location = new System.Drawing.Point(64, 69);
            this.lstElementos.Name = "lstElementos";
            this.lstElementos.Size = new System.Drawing.Size(120, 184);
            this.lstElementos.TabIndex = 0;
            this.lstElementos.SelectedIndexChanged += new System.EventHandler(this.lstElementos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Elementos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nuevo elemento";
            // 
            // element
            // 
            this.element.Location = new System.Drawing.Point(258, 69);
            this.element.Name = "element";
            this.element.Size = new System.Drawing.Size(171, 23);
            this.element.TabIndex = 3;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(258, 107);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(171, 36);
            this.add.TabIndex = 4;
            this.add.Text = "Insertar";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(258, 164);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(171, 36);
            this.delete.TabIndex = 5;
            this.delete.Text = "Eliminar";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // deleteAll
            // 
            this.deleteAll.Location = new System.Drawing.Point(258, 217);
            this.deleteAll.Name = "deleteAll";
            this.deleteAll.Size = new System.Drawing.Size(171, 36);
            this.deleteAll.TabIndex = 6;
            this.deleteAll.Text = "Borrar todo";
            this.deleteAll.UseVisualStyleBackColor = true;
            this.deleteAll.Click += new System.EventHandler(this.deleteAll_Click);
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Location = new System.Drawing.Point(64, 270);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(49, 15);
            this.lblIndex.TabIndex = 7;
            this.lblIndex.Text = "lblIndex";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(64, 299);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(44, 15);
            this.lblItem.TabIndex = 8;
            this.lblItem.Text = "lblItem";
            // 
            // Form08Colecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 334);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.deleteAll);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.element);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstElementos);
            this.Name = "Form08Colecciones";
            this.Text = "Form08Colecciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstElementos;
        private Label label1;
        private Label label2;
        private TextBox element;
        private Button add;
        private Button delete;
        private Button deleteAll;
        private Label lblIndex;
        private Label lblItem;
    }
}