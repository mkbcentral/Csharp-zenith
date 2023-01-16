namespace FactZenith
{
    partial class CatalogueProduit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogueProduit));
            this.txtCodeProduit = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDesignation = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btAddToCatalogue = new MetroFramework.Controls.MetroButton();
            this.dataGridViewProduit = new System.Windows.Forms.DataGridView();
            this.txtRech = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btRech = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.printDocumentCat = new System.Drawing.Printing.PrintDocument();
            this.code_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodeProduit
            // 
            this.txtCodeProduit.Depth = 0;
            this.txtCodeProduit.Hint = "Le code du produit";
            this.txtCodeProduit.Location = new System.Drawing.Point(23, 77);
            this.txtCodeProduit.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodeProduit.Name = "txtCodeProduit";
            this.txtCodeProduit.PasswordChar = '\0';
            this.txtCodeProduit.SelectedText = "";
            this.txtCodeProduit.SelectionLength = 0;
            this.txtCodeProduit.SelectionStart = 0;
            this.txtCodeProduit.Size = new System.Drawing.Size(299, 23);
            this.txtCodeProduit.TabIndex = 0;
            this.txtCodeProduit.UseSystemPasswordChar = false;
            // 
            // txtDesignation
            // 
            this.txtDesignation.Depth = 0;
            this.txtDesignation.Hint = "Le nom de l\'article";
            this.txtDesignation.Location = new System.Drawing.Point(23, 116);
            this.txtDesignation.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.PasswordChar = '\0';
            this.txtDesignation.SelectedText = "";
            this.txtDesignation.SelectionLength = 0;
            this.txtDesignation.SelectionStart = 0;
            this.txtDesignation.Size = new System.Drawing.Size(299, 23);
            this.txtDesignation.TabIndex = 1;
            this.txtDesignation.UseSystemPasswordChar = false;
            // 
            // btAddToCatalogue
            // 
            this.btAddToCatalogue.Location = new System.Drawing.Point(23, 157);
            this.btAddToCatalogue.Name = "btAddToCatalogue";
            this.btAddToCatalogue.Size = new System.Drawing.Size(131, 34);
            this.btAddToCatalogue.TabIndex = 3;
            this.btAddToCatalogue.Text = "Ajouter au catalogue";
            this.btAddToCatalogue.UseSelectable = true;
            this.btAddToCatalogue.Click += new System.EventHandler(this.btAddToCatalogue_Click);
            // 
            // dataGridViewProduit
            // 
            this.dataGridViewProduit.AllowUserToOrderColumns = true;
            this.dataGridViewProduit.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code_,
            this.des});
            this.dataGridViewProduit.Location = new System.Drawing.Point(347, 72);
            this.dataGridViewProduit.Name = "dataGridViewProduit";
            this.dataGridViewProduit.Size = new System.Drawing.Size(347, 334);
            this.dataGridViewProduit.TabIndex = 4;
            this.dataGridViewProduit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduit_CellContentClick);
            this.dataGridViewProduit.Click += new System.EventHandler(this.dataGridViewProduit_Click);
            // 
            // txtRech
            // 
            this.txtRech.Depth = 0;
            this.txtRech.Font = new System.Drawing.Font("MS Outlook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtRech.Hint = "Entrez le code du produit ici...";
            this.txtRech.Location = new System.Drawing.Point(381, 43);
            this.txtRech.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRech.Name = "txtRech";
            this.txtRech.PasswordChar = '\0';
            this.txtRech.SelectedText = "";
            this.txtRech.SelectionLength = 0;
            this.txtRech.SelectionStart = 0;
            this.txtRech.Size = new System.Drawing.Size(231, 23);
            this.txtRech.TabIndex = 5;
            this.txtRech.UseSystemPasswordChar = false;
            this.txtRech.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRech_KeyPress);
            // 
            // btRech
            // 
            this.btRech.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRech.Location = new System.Drawing.Point(618, 43);
            this.btRech.Name = "btRech";
            this.btRech.Size = new System.Drawing.Size(76, 23);
            this.btRech.TabIndex = 6;
            this.btRech.Text = "Rechercher";
            this.btRech.UseVisualStyleBackColor = true;
            this.btRech.Click += new System.EventHandler(this.btRech_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(347, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // printDocumentCat
            // 
            this.printDocumentCat.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentCat_PrintPage);
            // 
            // code_
            // 
            this.code_.HeaderText = "CODE";
            this.code_.Name = "code_";
            // 
            // des
            // 
            this.des.HeaderText = "DESIGNATION";
            this.des.Name = "des";
            this.des.Width = 200;
            // 
            // CatalogueProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 417);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btRech);
            this.Controls.Add(this.txtRech);
            this.Controls.Add(this.dataGridViewProduit);
            this.Controls.Add(this.btAddToCatalogue);
            this.Controls.Add(this.txtDesignation);
            this.Controls.Add(this.txtCodeProduit);
            this.Name = "CatalogueProduit";
            this.Text = "Catalogue Produits";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodeProduit;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDesignation;
        private MetroFramework.Controls.MetroButton btAddToCatalogue;
        private System.Windows.Forms.DataGridView dataGridViewProduit;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRech;
        private System.Windows.Forms.Button btRech;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Drawing.Printing.PrintDocument printDocumentCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn code_;
        private System.Windows.Forms.DataGridViewTextBoxColumn des;
    }
}