namespace Aplikasi01
{
    partial class FormCetakNotaBeli
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.inventory_tiggerDataSet = new Aplikasi01.inventory_tiggerDataSet();
            this.view_nota_beli_cetakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_nota_beli_cetakTableAdapter = new Aplikasi01.inventory_tiggerDataSetTableAdapters.view_nota_beli_cetakTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_tiggerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_nota_beli_cetakBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.view_nota_beli_cetakBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Aplikasi01.ReportNotaBeli.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(689, 376);
            this.reportViewer1.TabIndex = 0;
            // 
            // inventory_tiggerDataSet
            // 
            this.inventory_tiggerDataSet.DataSetName = "inventory_tiggerDataSet";
            this.inventory_tiggerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_nota_beli_cetakBindingSource
            // 
            this.view_nota_beli_cetakBindingSource.DataMember = "view_nota_beli_cetak";
            this.view_nota_beli_cetakBindingSource.DataSource = this.inventory_tiggerDataSet;
            // 
            // view_nota_beli_cetakTableAdapter
            // 
            this.view_nota_beli_cetakTableAdapter.ClearBeforeFill = true;
            // 
            // FormCetakNotaBeli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 376);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormCetakNotaBeli";
            this.Text = "FormCetakNotaBeli";
            this.Load += new System.EventHandler(this.FormCetakNotaBeli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventory_tiggerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_nota_beli_cetakBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource view_nota_beli_cetakBindingSource;
        private inventory_tiggerDataSet inventory_tiggerDataSet;
        private inventory_tiggerDataSetTableAdapters.view_nota_beli_cetakTableAdapter view_nota_beli_cetakTableAdapter;
    }
}