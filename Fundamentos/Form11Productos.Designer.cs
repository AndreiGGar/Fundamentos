namespace Fundamentos
{
    partial class Form11Productos
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
            this.product = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.store = new System.Windows.Forms.ListBox();
            this.select = new System.Windows.Forms.Button();
            this.all = new System.Windows.Forms.Button();
            this.stock = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.up = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto";
            // 
            // product
            // 
            this.product.Location = new System.Drawing.Point(31, 59);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(151, 23);
            this.product.TabIndex = 1;
            this.product.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.product_KeyPress);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(31, 113);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(151, 32);
            this.add.TabIndex = 2;
            this.add.Text = "Insertar";
            this.add.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(31, 161);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(151, 32);
            this.delete.TabIndex = 3;
            this.delete.Text = "Eliminar";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(31, 208);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(151, 32);
            this.update.TabIndex = 4;
            this.update.Text = "Modificar";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(31, 255);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(151, 32);
            this.clear.TabIndex = 5;
            this.clear.Text = "Limpiar";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tienda";
            // 
            // store
            // 
            this.store.FormattingEnabled = true;
            this.store.ItemHeight = 15;
            this.store.Location = new System.Drawing.Point(222, 59);
            this.store.Name = "store";
            this.store.Size = new System.Drawing.Size(163, 274);
            this.store.TabIndex = 7;
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(407, 132);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(103, 32);
            this.select.TabIndex = 8;
            this.select.Text = "Selección ->";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // all
            // 
            this.all.Location = new System.Drawing.Point(407, 187);
            this.all.Name = "all";
            this.all.Size = new System.Drawing.Size(103, 32);
            this.all.TabIndex = 9;
            this.all.Text = "Todos ->";
            this.all.UseVisualStyleBackColor = true;
            this.all.Click += new System.EventHandler(this.all_Click);
            // 
            // stock
            // 
            this.stock.FormattingEnabled = true;
            this.stock.ItemHeight = 15;
            this.stock.Location = new System.Drawing.Point(534, 59);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(163, 274);
            this.stock.TabIndex = 10;
            this.stock.SelectedIndexChanged += new System.EventHandler(this.stock_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(534, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Stock";
            // 
            // up
            // 
            this.up.Location = new System.Drawing.Point(728, 132);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(103, 32);
            this.up.TabIndex = 12;
            this.up.Text = "Subir";
            this.up.UseVisualStyleBackColor = true;
            this.up.Click += new System.EventHandler(this.up_Click);
            // 
            // down
            // 
            this.down.Location = new System.Drawing.Point(728, 187);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(103, 32);
            this.down.TabIndex = 13;
            this.down.Text = "Bajar";
            this.down.UseVisualStyleBackColor = true;
            this.down.Click += new System.EventHandler(this.down_Click);
            // 
            // Form11Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 405);
            this.Controls.Add(this.down);
            this.Controls.Add(this.up);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.all);
            this.Controls.Add(this.select);
            this.Controls.Add(this.store);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.update);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.product);
            this.Controls.Add(this.label1);
            this.Name = "Form11Productos";
            this.Text = "Form11Productos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox product;
        private Button add;
        private Button delete;
        private Button update;
        private Button clear;
        private Label label2;
        private ListBox store;
        private Button select;
        private Button all;
        private ListBox stock;
        private Label label3;
        private Button up;
        private Button down;
    }
}