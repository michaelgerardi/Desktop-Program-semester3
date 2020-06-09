namespace Aplikasi01
{
    partial class Ruang
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
            this.RtbRuang = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // RtbRuang
            // 
            this.RtbRuang.Location = new System.Drawing.Point(47, 31);
            this.RtbRuang.Name = "RtbRuang";
            this.RtbRuang.Size = new System.Drawing.Size(305, 257);
            this.RtbRuang.TabIndex = 0;
            this.RtbRuang.Text = "";
            // 
            // Ruang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 339);
            this.Controls.Add(this.RtbRuang);
            this.Name = "Ruang";
            this.Text = "Ruang";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RtbRuang;

    }
}