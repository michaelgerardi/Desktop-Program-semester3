namespace Aplikasi01
{
    partial class FormSetupPemakai
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKonFir = new System.Windows.Forms.TextBox();
            this.GbSetup = new System.Windows.Forms.GroupBox();
            this.checPemakai = new System.Windows.Forms.CheckBox();
            this.checSupplier = new System.Windows.Forms.CheckBox();
            this.checBarang = new System.Windows.Forms.CheckBox();
            this.GbTrans = new System.Windows.Forms.GroupBox();
            this.checJual = new System.Windows.Forms.CheckBox();
            this.checBeli = new System.Windows.Forms.CheckBox();
            this.GbLap = new System.Windows.Forms.GroupBox();
            this.checLapSupp = new System.Windows.Forms.CheckBox();
            this.checLapStock = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnTop = new System.Windows.Forms.Button();
            this.GbSetup.SuspendLayout();
            this.GbTrans.SuspendLayout();
            this.GbLap.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(143, 53);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 6;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(143, 18);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(15, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "UserName :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(270, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "konfirmasi Password :";
            // 
            // txtKonFir
            // 
            this.txtKonFir.Location = new System.Drawing.Point(398, 53);
            this.txtKonFir.Name = "txtKonFir";
            this.txtKonFir.PasswordChar = '*';
            this.txtKonFir.Size = new System.Drawing.Size(100, 20);
            this.txtKonFir.TabIndex = 6;
            // 
            // GbSetup
            // 
            this.GbSetup.Controls.Add(this.checPemakai);
            this.GbSetup.Controls.Add(this.checSupplier);
            this.GbSetup.Controls.Add(this.checBarang);
            this.GbSetup.Enabled = false;
            this.GbSetup.Location = new System.Drawing.Point(28, 87);
            this.GbSetup.Name = "GbSetup";
            this.GbSetup.Size = new System.Drawing.Size(172, 98);
            this.GbSetup.TabIndex = 9;
            this.GbSetup.TabStop = false;
            this.GbSetup.Text = "Setup";
            this.GbSetup.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checPemakai
            // 
            this.checPemakai.AutoSize = true;
            this.checPemakai.Location = new System.Drawing.Point(28, 75);
            this.checPemakai.Name = "checPemakai";
            this.checPemakai.Size = new System.Drawing.Size(93, 17);
            this.checPemakai.TabIndex = 0;
            this.checPemakai.Text = "Data Pemakai";
            this.checPemakai.UseVisualStyleBackColor = true;
            // 
            // checSupplier
            // 
            this.checSupplier.AutoSize = true;
            this.checSupplier.Location = new System.Drawing.Point(28, 53);
            this.checSupplier.Name = "checSupplier";
            this.checSupplier.Size = new System.Drawing.Size(90, 17);
            this.checSupplier.TabIndex = 0;
            this.checSupplier.Text = "Data Supplier";
            this.checSupplier.UseVisualStyleBackColor = true;
            // 
            // checBarang
            // 
            this.checBarang.AutoSize = true;
            this.checBarang.Location = new System.Drawing.Point(28, 30);
            this.checBarang.Name = "checBarang";
            this.checBarang.Size = new System.Drawing.Size(86, 17);
            this.checBarang.TabIndex = 0;
            this.checBarang.Text = "Data Barang";
            this.checBarang.UseVisualStyleBackColor = true;
            // 
            // GbTrans
            // 
            this.GbTrans.Controls.Add(this.checJual);
            this.GbTrans.Controls.Add(this.checBeli);
            this.GbTrans.Enabled = false;
            this.GbTrans.Location = new System.Drawing.Point(220, 87);
            this.GbTrans.Name = "GbTrans";
            this.GbTrans.Size = new System.Drawing.Size(172, 98);
            this.GbTrans.TabIndex = 9;
            this.GbTrans.TabStop = false;
            this.GbTrans.Text = "Transaksi";
            this.GbTrans.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checJual
            // 
            this.checJual.AutoSize = true;
            this.checJual.Location = new System.Drawing.Point(21, 53);
            this.checJual.Name = "checJual";
            this.checJual.Size = new System.Drawing.Size(73, 17);
            this.checJual.TabIndex = 0;
            this.checJual.Text = "Penjualan";
            this.checJual.UseVisualStyleBackColor = true;
            // 
            // checBeli
            // 
            this.checBeli.AutoSize = true;
            this.checBeli.Location = new System.Drawing.Point(21, 29);
            this.checBeli.Name = "checBeli";
            this.checBeli.Size = new System.Drawing.Size(75, 17);
            this.checBeli.TabIndex = 0;
            this.checBeli.Text = "Pembelian";
            this.checBeli.UseVisualStyleBackColor = true;
            // 
            // GbLap
            // 
            this.GbLap.Controls.Add(this.checLapSupp);
            this.GbLap.Controls.Add(this.checLapStock);
            this.GbLap.Enabled = false;
            this.GbLap.Location = new System.Drawing.Point(406, 87);
            this.GbLap.Name = "GbLap";
            this.GbLap.Size = new System.Drawing.Size(172, 98);
            this.GbLap.TabIndex = 9;
            this.GbLap.TabStop = false;
            this.GbLap.Text = "Laporan";
            this.GbLap.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checLapSupp
            // 
            this.checLapSupp.AutoSize = true;
            this.checLapSupp.Location = new System.Drawing.Point(6, 50);
            this.checLapSupp.Name = "checLapSupp";
            this.checLapSupp.Size = new System.Drawing.Size(132, 17);
            this.checLapSupp.TabIndex = 0;
            this.checLapSupp.Text = "Laporan Data Supplier";
            this.checLapSupp.UseVisualStyleBackColor = true;
            // 
            // checLapStock
            // 
            this.checLapStock.AutoSize = true;
            this.checLapStock.Location = new System.Drawing.Point(6, 28);
            this.checLapStock.Name = "checLapStock";
            this.checLapStock.Size = new System.Drawing.Size(96, 17);
            this.checLapStock.TabIndex = 0;
            this.checLapStock.Text = "Laporan Stock";
            this.checLapStock.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::Aplikasi01.Properties.Resources._12_Close;
            this.btnClose.Location = new System.Drawing.Point(506, 216);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 39);
            this.btnClose.TabIndex = 28;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Image = global::Aplikasi01.Properties.Resources._11_Undo;
            this.btnUndo.Location = new System.Drawing.Point(348, 171);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(44, 39);
            this.btnUndo.TabIndex = 32;
            this.btnUndo.Text = " ";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::Aplikasi01.Properties.Resources._10_Save;
            this.btnSave.Location = new System.Drawing.Point(302, 171);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(44, 39);
            this.btnSave.TabIndex = 33;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::Aplikasi01.Properties.Resources._08_Edit;
            this.btnEdit.Location = new System.Drawing.Point(360, 216);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(44, 39);
            this.btnEdit.TabIndex = 31;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Image = global::Aplikasi01.Properties.Resources._04_DataContainer_MoveLastHS;
            this.btnEnd.Location = new System.Drawing.Point(156, 216);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(44, 39);
            this.btnEnd.TabIndex = 29;
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Image = global::Aplikasi01.Properties.Resources._09_Delete;
            this.btnDel.Location = new System.Drawing.Point(406, 216);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(44, 39);
            this.btnDel.TabIndex = 30;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = global::Aplikasi01.Properties.Resources._07_New;
            this.btnNew.Location = new System.Drawing.Point(314, 216);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(44, 39);
            this.btnNew.TabIndex = 34;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnNext
            // 
            this.btnNext.Image = global::Aplikasi01.Properties.Resources._03_DataContainer_MoveNextHS;
            this.btnNext.Location = new System.Drawing.Point(110, 216);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(44, 39);
            this.btnNext.TabIndex = 38;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnFind
            // 
            this.btnFind.Image = global::Aplikasi01.Properties.Resources._05_Find;
            this.btnFind.Location = new System.Drawing.Point(268, 216);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(44, 39);
            this.btnFind.TabIndex = 39;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::Aplikasi01.Properties.Resources._06_Print;
            this.btnPrint.Location = new System.Drawing.Point(222, 216);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(44, 39);
            this.btnPrint.TabIndex = 37;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Image = global::Aplikasi01.Properties.Resources._02_DataContainer_MovePreviousHS;
            this.btnBack.Location = new System.Drawing.Point(64, 216);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(44, 39);
            this.btnBack.TabIndex = 35;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnTop
            // 
            this.btnTop.Image = global::Aplikasi01.Properties.Resources._01_DataContainer_MoveFirstHS;
            this.btnTop.Location = new System.Drawing.Point(18, 216);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(44, 39);
            this.btnTop.TabIndex = 36;
            this.btnTop.UseVisualStyleBackColor = true;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // FormSetupPemakai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 279);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.GbLap);
            this.Controls.Add(this.GbTrans);
            this.Controls.Add(this.GbSetup);
            this.Controls.Add(this.txtKonFir);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSetupPemakai";
            this.Text = "FormSetupPemakai";
            this.GbSetup.ResumeLayout(false);
            this.GbSetup.PerformLayout();
            this.GbTrans.ResumeLayout(false);
            this.GbTrans.PerformLayout();
            this.GbLap.ResumeLayout(false);
            this.GbLap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKonFir;
        private System.Windows.Forms.GroupBox GbSetup;
        private System.Windows.Forms.CheckBox checPemakai;
        private System.Windows.Forms.CheckBox checSupplier;
        private System.Windows.Forms.CheckBox checBarang;
        private System.Windows.Forms.GroupBox GbTrans;
        private System.Windows.Forms.CheckBox checJual;
        private System.Windows.Forms.CheckBox checBeli;
        private System.Windows.Forms.GroupBox GbLap;
        private System.Windows.Forms.CheckBox checLapSupp;
        private System.Windows.Forms.CheckBox checLapStock;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnTop;
    }
}