namespace FactZenith
{
    partial class RapportVentes
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.RapportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_zenithDataSet = new FactZenith.db_zenithDataSet();
            this.TotalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.comboDevise = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btVisualier = new System.Windows.Forms.Button();
            this.RapportTableAdapter = new FactZenith.db_zenithDataSetTableAdapters.RapportTableAdapter();
            this.TotalTableAdapter = new FactZenith.db_zenithDataSetTableAdapters.TotalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RapportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_zenithDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RapportBindingSource
            // 
            this.RapportBindingSource.DataMember = "Rapport";
            this.RapportBindingSource.DataSource = this.db_zenithDataSet;
            // 
            // db_zenithDataSet
            // 
            this.db_zenithDataSet.DataSetName = "db_zenithDataSet";
            this.db_zenithDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TotalBindingSource
            // 
            this.TotalBindingSource.DataMember = "Total";
            this.TotalBindingSource.DataSource = this.db_zenithDataSet;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(20, 119);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1069, 526);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1061, 500);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Journalier";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.RapportBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.TotalBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FactZenith.RpVentes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1055, 494);
            this.reportViewer1.TabIndex = 0;
            // 
            // comboDevise
            // 
            this.comboDevise.FormattingEnabled = true;
            this.comboDevise.Items.AddRange(new object[] {
            "USD",
            "CDF"});
            this.comboDevise.Location = new System.Drawing.Point(166, 85);
            this.comboDevise.Name = "comboDevise";
            this.comboDevise.Size = new System.Drawing.Size(168, 21);
            this.comboDevise.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choisir la dévise";
            // 
            // btVisualier
            // 
            this.btVisualier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVisualier.Location = new System.Drawing.Point(341, 85);
            this.btVisualier.Name = "btVisualier";
            this.btVisualier.Size = new System.Drawing.Size(138, 28);
            this.btVisualier.TabIndex = 3;
            this.btVisualier.Text = "Visualiser";
            this.btVisualier.UseVisualStyleBackColor = true;
            this.btVisualier.Click += new System.EventHandler(this.btVisualier_Click);
            // 
            // RapportTableAdapter
            // 
            this.RapportTableAdapter.ClearBeforeFill = true;
            // 
            // TotalTableAdapter
            // 
            this.TotalTableAdapter.ClearBeforeFill = true;
            // 
            // RapportVentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 665);
            this.Controls.Add(this.btVisualier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboDevise);
            this.Controls.Add(this.tabControl1);
            this.Name = "RapportVentes";
            this.Text = "Rapport des Ventes";
            this.Load += new System.EventHandler(this.RapportVentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RapportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_zenithDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox comboDevise;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btVisualier;
        private System.Windows.Forms.BindingSource RapportBindingSource;
        private db_zenithDataSet db_zenithDataSet;
        private System.Windows.Forms.BindingSource TotalBindingSource;
        private db_zenithDataSetTableAdapters.RapportTableAdapter RapportTableAdapter;
        private db_zenithDataSetTableAdapters.TotalTableAdapter TotalTableAdapter;
    }
}