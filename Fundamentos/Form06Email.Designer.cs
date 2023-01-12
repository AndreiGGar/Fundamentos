namespace Fundamentos
{
    partial class Form06Email
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
            this.send = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(163, 138);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(101, 43);
            this.send.TabIndex = 1;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(64, 85);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(328, 23);
            this.email.TabIndex = 2;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(64, 202);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(39, 15);
            this.result.TabIndex = 3;
            this.result.Text = "Result";
            // 
            // Form06Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 250);
            this.Controls.Add(this.result);
            this.Controls.Add(this.email);
            this.Controls.Add(this.send);
            this.Controls.Add(this.label1);
            this.Name = "Form06Email";
            this.Text = "Form06Email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button send;
        private TextBox email;
        private Label result;
    }
}