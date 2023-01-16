namespace FactZenith
{
    partial class Prof
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
            this.db_zenithDataSet = new FactZenith.db_zenithDataSet();
            this.ProformaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proformaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.db_zenithDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProformaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proformaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetProf";
            reportDataSource1.Value = this.ProformaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FactZenith.Proforma.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(850, 526);
            this.reportViewer1.TabIndex = 0;
            // 
            // db_zenithDataSet
            // 
            this.db_zenithDataSet.DataSetName = "db_zenithDataSet";
            this.db_zenithDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProformaBindingSource
            // 
            this.ProformaBindingSource.DataMember = "Proforma";
            this.ProformaBindingSource.DataSource = this.db_zenithDataSet;
            // 
            // proformaBindingSource1
            // 
            this.proformaBindingSource1.DataMember = "Proforma";
            this.proformaBindingSource1.DataSource = this.db_zenithDataSet;
            // 
            // Prof
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 526);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Prof";
            this.Text = "Prof";
            this.Load += new System.EventHandler(this.Prof_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_zenithDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProformaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proformaBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProformaBindingSource;
        private db_zenithDataSet db_zenithDataSet;
        private System.Windows.Forms.BindingSource proformaBindingSource1;
    }
}