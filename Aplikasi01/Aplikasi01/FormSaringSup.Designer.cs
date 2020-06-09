namespace Aplikasi01
{
    partial class FormSaringSup
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
            this.btnCloset = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.cb02 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb01 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCloset
            // 
            this.btnCloset.Location = new System.Drawing.Point(151, 138);
            this.btnCloset.Name = "btnCloset";
            this.btnCloset.Size = new System.Drawing.Size(75, 23);
            this.btnCloset.TabIndex = 8;
            this.btnCloset.Text = "Closet";
            this.btnCloset.UseVisualStyleBackColor = true;
            this.btnCloset.Click += new System.EventHandler(this.btnCloset_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(70, 138);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 9;
            this.btnPrev.Text = "Preview";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // cb02
            // 
            this.cb02.FormattingEnabled = true;
            this.cb02.Location = new System.Drawing.Point(264, 75);
            this.cb02.Name = "cb02";
            this.cb02.Size = new System.Drawing.Size(92, 21);
            this.cb02.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "s.d.";
            // 
            // cb01
            // 
            this.cb01.FormattingEnabled = true;
            this.cb01.Location = new System.Drawing.Point(46, 33);
            this.cb01.Name = "cb01";
            this.cb01.Size = new System.Drawing.Size(92, 21);
            this.cb01.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb01);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(70, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 90);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Batas";
            // 
            // FormSaringSup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 203);
            this.Controls.Add(this.btnCloset);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.cb02);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSaringSup";
            this.Text = "FormSaringSup";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloset;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.ComboBox cb02;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb01;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}