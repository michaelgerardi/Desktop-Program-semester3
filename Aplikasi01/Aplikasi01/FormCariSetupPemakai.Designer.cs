namespace Aplikasi01
{
    partial class FormCariSetupPemakai
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
            this.txtKodeCariUsername = new System.Windows.Forms.TextBox();
            this.rdFind = new System.Windows.Forms.RadioButton();
            this.dgvCariPemakai = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCariPemakai)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKodeCariUsername
            // 
            this.txtKodeCariUsername.Location = new System.Drawing.Point(158, 33);
            this.txtKodeCariUsername.MaxLength = 5;
            this.txtKodeCariUsername.Name = "txtKodeCariUsername";
            this.txtKodeCariUsername.Size = new System.Drawing.Size(100, 20);
            this.txtKodeCariUsername.TabIndex = 3;
            this.txtKodeCariUsername.TextChanged += new System.EventHandler(this.txtKodeCariUsername_TextChanged);
            this.txtKodeCariUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKodeCariUsername_KeyPress);
            // 
            // rdFind
            // 
            this.rdFind.AutoSize = true;
            this.rdFind.Checked = true;
            this.rdFind.Location = new System.Drawing.Point(33, 34);
            this.rdFind.Name = "rdFind";
            this.rdFind.Size = new System.Drawing.Size(94, 17);
            this.rdFind.TabIndex = 4;
            this.rdFind.TabStop = true;
            this.rdFind.Text = "Cari Username";
            this.rdFind.UseVisualStyleBackColor = true;
            // 
            // dgvCariPemakai
            // 
            this.dgvCariPemakai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCariPemakai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvCariPemakai.Location = new System.Drawing.Point(33, 82);
            this.dgvCariPemakai.Name = "dgvCariPemakai";
            this.dgvCariPemakai.Size = new System.Drawing.Size(243, 150);
            this.dgvCariPemakai.TabIndex = 5;
            this.dgvCariPemakai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvCariPemakai_KeyPress);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "userName";
            this.Column1.HeaderText = "Username";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "password";
            this.Column2.HeaderText = "Password";
            this.Column2.Name = "Column2";
            // 
            // FormCariSetupPemakai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 269);
            this.Controls.Add(this.dgvCariPemakai);
            this.Controls.Add(this.txtKodeCariUsername);
            this.Controls.Add(this.rdFind);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCariSetupPemakai";
            this.Text = "FormCariSetupPemakai";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCariPemakai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKodeCariUsername;
        private System.Windows.Forms.RadioButton rdFind;
        private System.Windows.Forms.DataGridView dgvCariPemakai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}