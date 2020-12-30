namespace Taksi
{
    partial class rasid
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
            this.TaksiDBLDataSet = new Taksi.TaksiDBLDataSet();
            this.F_tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.F_tableTableAdapter = new Taksi.TaksiDBLDataSetTableAdapters.F_tableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TaksiDBLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.F_tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.F_tableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Taksi.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(963, 267);
            this.reportViewer1.TabIndex = 0;
            // 
            // TaksiDBLDataSet
            // 
            this.TaksiDBLDataSet.DataSetName = "TaksiDBLDataSet";
            this.TaksiDBLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // F_tableBindingSource
            // 
            this.F_tableBindingSource.DataMember = "F_table";
            this.F_tableBindingSource.DataSource = this.TaksiDBLDataSet;
            // 
            // F_tableTableAdapter
            // 
            this.F_tableTableAdapter.ClearBeforeFill = true;
            // 
            // rasid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 267);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rasid";
            this.Text = "rasid";
            this.Load += new System.EventHandler(this.rasid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TaksiDBLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.F_tableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private TaksiDBLDataSet TaksiDBLDataSet;
        private TaksiDBLDataSetTableAdapters.F_tableTableAdapter F_tableTableAdapter;
        public System.Windows.Forms.BindingSource F_tableBindingSource;

    }
}