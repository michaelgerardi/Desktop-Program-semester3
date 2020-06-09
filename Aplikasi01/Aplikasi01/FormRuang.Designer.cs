namespace Aplikasi01
{
    partial class FormRuang
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
            this.rtbRuang = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbRuang
            // 
            this.rtbRuang.Location = new System.Drawing.Point(12, 12);
            this.rtbRuang.Name = "rtbRuang";
            this.rtbRuang.Size = new System.Drawing.Size(491, 379);
            this.rtbRuang.TabIndex = 0;
            this.rtbRuang.Text = "";
            // 
            // FormRuang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 403);
            this.Controls.Add(this.rtbRuang);
            this.Name = "FormRuang";
            this.Text = "FormRuang";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbRuang;

    }
}