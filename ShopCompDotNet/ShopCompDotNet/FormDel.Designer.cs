namespace ShopCompDotNet
{
    partial class FormDel
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
            this.button_cancel_del = new System.Windows.Forms.Button();
            this.button_ok_del = new System.Windows.Forms.Button();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_cancel_del
            // 
            this.button_cancel_del.Location = new System.Drawing.Point(44, 54);
            this.button_cancel_del.Name = "button_cancel_del";
            this.button_cancel_del.Size = new System.Drawing.Size(75, 23);
            this.button_cancel_del.TabIndex = 17;
            this.button_cancel_del.Text = "Cancel";
            this.button_cancel_del.UseVisualStyleBackColor = true;
            this.button_cancel_del.Click += new System.EventHandler(this.button_cancel_del_Click);
            // 
            // button_ok_del
            // 
            this.button_ok_del.Location = new System.Drawing.Point(166, 54);
            this.button_ok_del.Name = "button_ok_del";
            this.button_ok_del.Size = new System.Drawing.Size(75, 23);
            this.button_ok_del.TabIndex = 16;
            this.button_ok_del.Text = "OK";
            this.button_ok_del.UseVisualStyleBackColor = true;
            this.button_ok_del.Click += new System.EventHandler(this.button_ok_del_Click);
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(72, 12);
            this.textBox_id.MaximumSize = new System.Drawing.Size(197, 20);
            this.textBox_id.MinimumSize = new System.Drawing.Size(197, 20);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(197, 20);
            this.textBox_id.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Id";
            // 
            // FormDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 89);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_cancel_del);
            this.Controls.Add(this.button_ok_del);
            this.Name = "FormDel";
            this.Text = "FormDel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_cancel_del;
        private System.Windows.Forms.Button button_ok_del;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label1;
    }
}