namespace Aplikasi01
{
    partial class FormCetakNotaJual
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
            this.InventorykuDataSet = new Aplikasi01.InventorykuDataSet();
            this.View_Master_Jual_CetakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.View_Master_Jual_CetakTableAdapter = new Aplikasi01.InventorykuDataSetTableAdapters.View_Master_Jual_CetakTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.InventorykuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_Master_Jual_CetakBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.View_Master_Jual_CetakBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Aplikasi01.ReportCetakNotaJual.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(662, 371);
            this.reportViewer1.TabIndex = 0;
            // 
            // InventorykuDataSet
            // 
            this.InventorykuDataSet.DataSetName = "InventorykuDataSet";
            this.InventorykuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // View_Master_Jual_CetakBindingSource
            // 
            this.View_Master_Jual_CetakBindingSource.DataMember = "View_Master_Jual_Cetak";
            this.View_Master_Jual_CetakBindingSource.DataSource = this.InventorykuDataSet;
            // 
            // View_Master_Jual_CetakTableAdapter
            // 
            this.View_Master_Jual_CetakTableAdapter.ClearBeforeFill = true;
            // 
            // FormCetakNotaJual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 371);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormCetakNotaJual";
            this.Text = "FormCetakNotaJual";
            this.Load += new System.EventHandler(this.FormCetakNotaJual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InventorykuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_Master_Jual_CetakBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource View_Master_Jual_CetakBindingSource;
        private InventorykuDataSet InventorykuDataSet;
        private InventorykuDataSetTableAdapters.View_Master_Jual_CetakTableAdapter View_Master_Jual_CetakTableAdapter;
    }
}