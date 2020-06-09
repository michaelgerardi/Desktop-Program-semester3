namespace Aplikasi01
{
    partial class FormLapStok
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
            this.inventory_tiggerDataSet1 = new Aplikasi01.inventory_tiggerDataSet1();
            this.inventorytiggerDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BarangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BarangTableAdapter = new Aplikasi01.inventory_tiggerDataSet1TableAdapters.BarangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_tiggerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorytiggerDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // inventory_tiggerDataSet1
            // 
            this.inventory_tiggerDataSet1.DataSetName = "inventory_tiggerDataSet1";
            this.inventory_tiggerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventorytiggerDataSet1BindingSource
            // 
            this.inventorytiggerDataSet1BindingSource.DataSource = this.inventory_tiggerDataSet1;
            this.inventorytiggerDataSet1BindingSource.Position = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.BarangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Aplikasi01.Lapstock.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(430, 261);
            this.reportViewer1.TabIndex = 0;
            // 
            // BarangBindingSource
            // 
            this.BarangBindingSource.DataMember = "Barang";
            this.BarangBindingSource.DataSource = this.inventory_tiggerDataSet1;
            // 
            // BarangTableAdapter
            // 
            this.BarangTableAdapter.ClearBeforeFill = true;
            // 
            // FormLapStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 261);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormLapStok";
            this.Text = "FormLapStok";
            this.Load += new System.EventHandler(this.FormLapStok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventory_tiggerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorytiggerDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private inventory_tiggerDataSet1 inventory_tiggerDataSet1;
        private System.Windows.Forms.BindingSource inventorytiggerDataSet1BindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BarangBindingSource;
        private inventory_tiggerDataSet1TableAdapters.BarangTableAdapter BarangTableAdapter;

    }
}