﻿namespace Aplikasi01
{
    partial class FormDosen
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
            this.dgvDosen = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDosen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDosen
            // 
            this.dgvDosen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDosen.Location = new System.Drawing.Point(12, 112);
            this.dgvDosen.Name = "dgvDosen";
            this.dgvDosen.Size = new System.Drawing.Size(431, 262);
            this.dgvDosen.TabIndex = 0;
            // 
            // FormDosen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 386);
            this.Controls.Add(this.dgvDosen);
            this.Name = "FormDosen";
            this.Text = "FormDosen";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDosen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDosen;
    }
}