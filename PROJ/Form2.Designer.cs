namespace PROJ
{
    partial class Form2
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
            this.btn8bit = new System.Windows.Forms.Button();
            this.btn16bit = new System.Windows.Forms.Button();
            this.btn32bit = new System.Windows.Forms.Button();
            this.btn64bit = new System.Windows.Forms.Button();
            this.txtIns = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Instructions  Format";
            // 
            // btn8bit
            // 
            this.btn8bit.Location = new System.Drawing.Point(12, 60);
            this.btn8bit.Name = "btn8bit";
            this.btn8bit.Size = new System.Drawing.Size(75, 23);
            this.btn8bit.TabIndex = 1;
            this.btn8bit.Text = "8 BIT";
            this.btn8bit.UseVisualStyleBackColor = true;
            this.btn8bit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn16bit
            // 
            this.btn16bit.Location = new System.Drawing.Point(12, 117);
            this.btn16bit.Name = "btn16bit";
            this.btn16bit.Size = new System.Drawing.Size(75, 23);
            this.btn16bit.TabIndex = 2;
            this.btn16bit.Text = "16 BIT";
            this.btn16bit.UseVisualStyleBackColor = true;
            this.btn16bit.Click += new System.EventHandler(this.btn16bit_Click);
            // 
            // btn32bit
            // 
            this.btn32bit.Location = new System.Drawing.Point(12, 178);
            this.btn32bit.Name = "btn32bit";
            this.btn32bit.Size = new System.Drawing.Size(75, 23);
            this.btn32bit.TabIndex = 3;
            this.btn32bit.Text = "32 BIT";
            this.btn32bit.UseVisualStyleBackColor = true;
            // 
            // btn64bit
            // 
            this.btn64bit.Location = new System.Drawing.Point(12, 244);
            this.btn64bit.Name = "btn64bit";
            this.btn64bit.Size = new System.Drawing.Size(75, 23);
            this.btn64bit.TabIndex = 4;
            this.btn64bit.Text = "64 BIT";
            this.btn64bit.UseVisualStyleBackColor = true;
            // 
            // txtIns
            // 
            this.txtIns.Location = new System.Drawing.Point(116, 60);
            this.txtIns.Name = "txtIns";
            this.txtIns.Size = new System.Drawing.Size(736, 416);
            this.txtIns.TabIndex = 5;
            this.txtIns.Text = "";
            this.txtIns.TextChanged += new System.EventHandler(this.txtIns_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 506);
            this.Controls.Add(this.txtIns);
            this.Controls.Add(this.btn64bit);
            this.Controls.Add(this.btn32bit);
            this.Controls.Add(this.btn16bit);
            this.Controls.Add(this.btn8bit);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btn8bit;
        private Button btn16bit;
        private Button btn32bit;
        private Button btn64bit;
        private RichTextBox txtIns;
    }
}