namespace Fundamentos
{
    partial class Form04DateTime
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
            this.actualDate = new System.Windows.Forms.TextBox();
            this.dateChange = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.addTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.years = new System.Windows.Forms.RadioButton();
            this.months = new System.Windows.Forms.RadioButton();
            this.days = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.newDate = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha actual";
            // 
            // actualDate
            // 
            this.actualDate.Location = new System.Drawing.Point(48, 65);
            this.actualDate.Multiline = true;
            this.actualDate.Name = "actualDate";
            this.actualDate.Size = new System.Drawing.Size(496, 23);
            this.actualDate.TabIndex = 1;
            // 
            // dateChange
            // 
            this.dateChange.AutoSize = true;
            this.dateChange.Location = new System.Drawing.Point(48, 104);
            this.dateChange.Name = "dateChange";
            this.dateChange.Size = new System.Drawing.Size(153, 19);
            this.dateChange.TabIndex = 2;
            this.dateChange.Text = "Cambiar Formato Fecha";
            this.dateChange.UseVisualStyleBackColor = true;
            this.dateChange.CheckedChanged += new System.EventHandler(this.dateChange_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.addTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.years);
            this.groupBox1.Controls.Add(this.months);
            this.groupBox1.Controls.Add(this.days);
            this.groupBox1.Location = new System.Drawing.Point(48, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 113);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Incrementar fecha";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(260, 65);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 29);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Incrementar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // addTxt
            // 
            this.addTxt.Location = new System.Drawing.Point(321, 21);
            this.addTxt.Name = "addTxt";
            this.addTxt.Size = new System.Drawing.Size(100, 23);
            this.addTxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Incremento";
            // 
            // years
            // 
            this.years.AutoSize = true;
            this.years.Location = new System.Drawing.Point(6, 75);
            this.years.Name = "years";
            this.years.Size = new System.Drawing.Size(52, 19);
            this.years.TabIndex = 2;
            this.years.TabStop = true;
            this.years.Text = "Años";
            this.years.UseVisualStyleBackColor = true;
            // 
            // months
            // 
            this.months.AutoSize = true;
            this.months.Location = new System.Drawing.Point(6, 47);
            this.months.Name = "months";
            this.months.Size = new System.Drawing.Size(58, 19);
            this.months.TabIndex = 1;
            this.months.TabStop = true;
            this.months.Text = "Meses";
            this.months.UseVisualStyleBackColor = true;
            // 
            // days
            // 
            this.days.AutoSize = true;
            this.days.Location = new System.Drawing.Point(6, 22);
            this.days.Name = "days";
            this.days.Size = new System.Drawing.Size(47, 19);
            this.days.TabIndex = 0;
            this.days.TabStop = true;
            this.days.Text = "Días";
            this.days.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nueva fecha";
            // 
            // newDate
            // 
            this.newDate.Location = new System.Drawing.Point(48, 287);
            this.newDate.Multiline = true;
            this.newDate.Name = "newDate";
            this.newDate.Size = new System.Drawing.Size(496, 23);
            this.newDate.TabIndex = 5;
            // 
            // Form04DateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 361);
            this.Controls.Add(this.newDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateChange);
            this.Controls.Add(this.actualDate);
            this.Controls.Add(this.label1);
            this.Name = "Form04DateTime";
            this.Text = "Form04DateTime";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox actualDate;
        private CheckBox dateChange;
        private GroupBox groupBox1;
        private TextBox addTxt;
        private Label label2;
        private RadioButton years;
        private RadioButton months;
        private RadioButton days;
        private Button btnAdd;
        private Label label3;
        private TextBox newDate;
    }
}