namespace FactZenith
{
    partial class Proformas
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
            this.db_zenithDataSet = new FactZenith.db_zenithDataSet();
            this.proformaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.db_zenithDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proformaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // db_zenithDataSet
            // 
            this.db_zenithDataSet.DataSetName = "db_zenithDataSet";
            this.db_zenithDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proformaBindingSource
            // 
            this.proformaBindingSource.DataMember = "Proforma";
            this.proformaBindingSource.DataSource = this.db_zenithDataSet;
            // 
            // Proformas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 410);
            this.Name = "Proformas";
            this.Text = "Pro-forma";
            this.Load += new System.EventHandler(this.Proformas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_zenithDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proformaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private db_zenithDataSet db_zenithDataSet;
        private System.Windows.Forms.BindingSource proformaBindingSource;

    }
}