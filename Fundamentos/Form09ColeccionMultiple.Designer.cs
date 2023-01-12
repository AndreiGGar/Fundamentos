namespace Fundamentos
{
    partial class Form09ColeccionMultiple
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
            this.lblItem = new System.Windows.Forms.Label();
            this.lblIndex = new System.Windows.Forms.Label();
            this.deleteAll = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.element = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstElementos = new System.Windows.Forms.ListBox();
            this.selecteds = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(218, 349);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(44, 15);
            this.lblItem.TabIndex = 17;
            this.lblItem.Text = "lblItem";
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Location = new System.Drawing.Point(218, 320);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(49, 15);
            this.lblIndex.TabIndex = 16;
            this.lblIndex.Text = "lblIndex";
            // 
            // deleteAll
            // 
            this.deleteAll.Location = new System.Drawing.Point(412, 267);
            this.deleteAll.Name = "deleteAll";
            this.deleteAll.Size = new System.Drawing.Size(171, 36);
            this.deleteAll.TabIndex = 15;
            this.deleteAll.Text = "Borrar todo";
            this.deleteAll.UseVisualStyleBackColor = true;
            this.deleteAll.Click += new System.EventHandler(this.deleteAll_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(412, 214);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(171, 36);
            this.delete.TabIndex = 14;
            this.delete.Text = "Eliminar";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(412, 157);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(171, 36);
            this.add.TabIndex = 13;
            this.add.Text = "Insertar";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // element
            // 
            this.element.Location = new System.Drawing.Point(412, 119);
            this.element.Name = "element";
            this.element.Size = new System.Drawing.Size(171, 23);
            this.element.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nuevo elemento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Elementos";
            // 
            // lstElementos
            // 
            this.lstElementos.FormattingEnabled = true;
            this.lstElementos.ItemHeight = 15;
            this.lstElementos.Location = new System.Drawing.Point(218, 119);
            this.lstElementos.Name = "lstElementos";
            this.lstElementos.Size = new System.Drawing.Size(120, 184);
            this.lstElementos.TabIndex = 9;
            // 
            // selecteds
            // 
            this.selecteds.Location = new System.Drawing.Point(412, 320);
            this.selecteds.Name = "selecteds";
            this.selecteds.Size = new System.Drawing.Size(171, 36);
            this.selecteds.TabIndex = 18;
            this.selecteds.Text = "Seleccionados";
            this.selecteds.UseVisualStyleBackColor = true;
            this.selecteds.Click += new System.EventHandler(this.selecteds_Click);
            // 
            // Form09ColeccionMultiple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selecteds);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.deleteAll);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.element);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstElementos);
            this.Name = "Form09ColeccionMultiple";
            this.Text = "Form09ColeccionMultiple";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblItem;
        private Label lblIndex;
        private Button deleteAll;
        private Button delete;
        private Button add;
        private TextBox element;
        private Label label2;
        private Label label1;
        private ListBox lstElementos;
        private Button selecteds;
    }
}