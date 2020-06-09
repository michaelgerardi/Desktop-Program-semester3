namespace Aplikasi01
{
    partial class FormTableDosen
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
            this.dgvBarang = new System.Windows.Forms.DataGridView();
            this.txtkota = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtNamaDosen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnTop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBarang
            // 
            this.dgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarang.Location = new System.Drawing.Point(75, 124);
            this.dgvBarang.Name = "dgvBarang";
            this.dgvBarang.Size = new System.Drawing.Size(693, 245);
            this.dgvBarang.TabIndex = 37;
            // 
            // txtkota
            // 
            this.txtkota.Enabled = false;
            this.txtkota.Location = new System.Drawing.Point(439, 46);
            this.txtkota.Name = "txtkota";
            this.txtkota.Size = new System.Drawing.Size(100, 20);
            this.txtkota.TabIndex = 40;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Enabled = false;
            this.txtAlamat.Location = new System.Drawing.Point(439, 20);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(100, 20);
            this.txtAlamat.TabIndex = 38;
            // 
            // txtNamaDosen
            // 
            this.txtNamaDosen.Enabled = false;
            this.txtNamaDosen.Location = new System.Drawing.Point(171, 43);
            this.txtNamaDosen.Name = "txtNamaDosen";
            this.txtNamaDosen.Size = new System.Drawing.Size(169, 20);
            this.txtNamaDosen.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Kota";
            // 
            // txtnik
            // 
            this.txtnik.Enabled = false;
            this.txtnik.Location = new System.Drawing.Point(171, 16);
            this.txtnik.Name = "txtnik";
            this.txtnik.Size = new System.Drawing.Size(100, 20);
            this.txtnik.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "alamat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nama_dosen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "nik";
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::Aplikasi01.Properties.Resources._08_Edit;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEdit.Location = new System.Drawing.Point(418, 407);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(34, 39);
            this.btnEdit.TabIndex = 39;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnEnd
            // 
            this.btnEnd.Image = global::Aplikasi01.Properties.Resources._04_DataContainer_MoveLastHS;
            this.btnEnd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEnd.Location = new System.Drawing.Point(211, 386);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(34, 28);
            this.btnEnd.TabIndex = 45;
            this.btnEnd.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::Aplikasi01.Properties.Resources._12_Close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.Location = new System.Drawing.Point(729, 375);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 39);
            this.btnClose.TabIndex = 46;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.Image = global::Aplikasi01.Properties.Resources._05_Find;
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFind.Location = new System.Drawing.Point(338, 407);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(34, 39);
            this.btnFind.TabIndex = 47;
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::Aplikasi01.Properties.Resources._10_Save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.Location = new System.Drawing.Point(498, 375);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(34, 39);
            this.btnSave.TabIndex = 42;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Image = global::Aplikasi01.Properties.Resources._02_DataContainer_MovePreviousHS;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBack.Location = new System.Drawing.Point(131, 386);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(34, 28);
            this.btnBack.TabIndex = 43;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Image = global::Aplikasi01.Properties.Resources._07_New;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNew.Location = new System.Drawing.Point(378, 407);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(34, 39);
            this.btnNew.TabIndex = 44;
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::Aplikasi01.Properties.Resources._06_Print;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrint.Location = new System.Drawing.Point(298, 407);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(34, 39);
            this.btnPrint.TabIndex = 50;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnUndo
            // 
            this.btnUndo.Image = global::Aplikasi01.Properties.Resources._11_Undo;
            this.btnUndo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUndo.Location = new System.Drawing.Point(538, 375);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(34, 39);
            this.btnUndo.TabIndex = 51;
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Visible = false;
            // 
            // btnDel
            // 
            this.btnDel.Image = global::Aplikasi01.Properties.Resources._09_Delete;
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDel.Location = new System.Drawing.Point(458, 375);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(34, 39);
            this.btnDel.TabIndex = 48;
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Image = global::Aplikasi01.Properties.Resources._03_DataContainer_MoveNextHS;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNext.Location = new System.Drawing.Point(171, 386);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(34, 28);
            this.btnNext.TabIndex = 49;
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnTop
            // 
            this.btnTop.Image = global::Aplikasi01.Properties.Resources._01_DataContainer_MoveFirstHS;
            this.btnTop.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTop.Location = new System.Drawing.Point(91, 387);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(34, 27);
            this.btnTop.TabIndex = 41;
            this.btnTop.UseVisualStyleBackColor = true;
            // 
            // FormTableDosen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 462);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.dgvBarang);
            this.Controls.Add(this.txtkota);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtNamaDosen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtnik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormTableDosen";
            this.Text = "FormTableDosen";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.DataGridView dgvBarang;
        private System.Windows.Forms.TextBox txtkota;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.TextBox txtNamaDosen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}