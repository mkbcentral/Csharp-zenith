namespace FactZenith
{
    partial class Dashboad
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fACTURATIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerUneFactureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.déconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStock = new System.Windows.Forms.ToolStripMenuItem();
            this.voirLaLsiteDesProduitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuParametres = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLesUtilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbUserInfos = new System.Windows.Forms.ToolStripStatusLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imprimerProformaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fACTURATIONToolStripMenuItem,
            this.menuStock,
            this.menuParametres});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fACTURATIONToolStripMenuItem
            // 
            this.fACTURATIONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créerUneFactureToolStripMenuItem,
            this.imprimerProformaToolStripMenuItem,
            this.rapportToolStripMenuItem,
            this.déconnexionToolStripMenuItem});
            this.fACTURATIONToolStripMenuItem.Name = "fACTURATIONToolStripMenuItem";
            this.fACTURATIONToolStripMenuItem.Size = new System.Drawing.Size(128, 23);
            this.fACTURATIONToolStripMenuItem.Text = "FACTURATION";
            // 
            // créerUneFactureToolStripMenuItem
            // 
            this.créerUneFactureToolStripMenuItem.Name = "créerUneFactureToolStripMenuItem";
            this.créerUneFactureToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.créerUneFactureToolStripMenuItem.Text = "Créer une facture";
            this.créerUneFactureToolStripMenuItem.Click += new System.EventHandler(this.créerUneFactureToolStripMenuItem_Click);
            // 
            // rapportToolStripMenuItem
            // 
            this.rapportToolStripMenuItem.Name = "rapportToolStripMenuItem";
            this.rapportToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.rapportToolStripMenuItem.Text = "Rapport";
            this.rapportToolStripMenuItem.Click += new System.EventHandler(this.rapportToolStripMenuItem_Click);
            // 
            // déconnexionToolStripMenuItem
            // 
            this.déconnexionToolStripMenuItem.Name = "déconnexionToolStripMenuItem";
            this.déconnexionToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.déconnexionToolStripMenuItem.Text = "Déconnexion";
            this.déconnexionToolStripMenuItem.Click += new System.EventHandler(this.déconnexionToolStripMenuItem_Click);
            // 
            // menuStock
            // 
            this.menuStock.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voirLaLsiteDesProduitsToolStripMenuItem});
            this.menuStock.Name = "menuStock";
            this.menuStock.Size = new System.Drawing.Size(74, 23);
            this.menuStock.Text = "STOCK";
            // 
            // voirLaLsiteDesProduitsToolStripMenuItem
            // 
            this.voirLaLsiteDesProduitsToolStripMenuItem.Name = "voirLaLsiteDesProduitsToolStripMenuItem";
            this.voirLaLsiteDesProduitsToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.voirLaLsiteDesProduitsToolStripMenuItem.Text = "Catalogue produit";
            this.voirLaLsiteDesProduitsToolStripMenuItem.Click += new System.EventHandler(this.voirLaLsiteDesProduitsToolStripMenuItem_Click);
            // 
            // menuParametres
            // 
            this.menuParametres.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gérerLesUtilisateursToolStripMenuItem});
            this.menuParametres.Name = "menuParametres";
            this.menuParametres.Size = new System.Drawing.Size(121, 23);
            this.menuParametres.Text = "PARAMETRES";
            // 
            // gérerLesUtilisateursToolStripMenuItem
            // 
            this.gérerLesUtilisateursToolStripMenuItem.Name = "gérerLesUtilisateursToolStripMenuItem";
            this.gérerLesUtilisateursToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.gérerLesUtilisateursToolStripMenuItem.Text = "Gérer les utilisateurs";
            this.gérerLesUtilisateursToolStripMenuItem.Click += new System.EventHandler(this.gérerLesUtilisateursToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbUserInfos});
            this.statusStrip1.Location = new System.Drawing.Point(20, 519);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 24);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbUserInfos
            // 
            this.lbUserInfos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserInfos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbUserInfos.Name = "lbUserInfos";
            this.lbUserInfos.Size = new System.Drawing.Size(249, 19);
            this.lbUserInfos.Text = "Utilisateur :Username [role] connecté(e)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(888, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "KONGO INVOICE 001";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(859, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 52);
            this.label3.TabIndex = 6;
            this.label3.Text = "Développé par KongoDiaKati S.A.R.L\r\nwww.kdk-kongodiakati.com\r\nTel:+243 81 3051210" +
    "\r\nLubumbashi/RDC";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FactZenith.Properties.Resources.zenith;
            this.pictureBox1.Location = new System.Drawing.Point(371, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(478, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // imprimerProformaToolStripMenuItem
            // 
            this.imprimerProformaToolStripMenuItem.Name = "imprimerProformaToolStripMenuItem";
            this.imprimerProformaToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.imprimerProformaToolStripMenuItem.Text = "Imprimer Pro-forma";
            this.imprimerProformaToolStripMenuItem.Click += new System.EventHandler(this.imprimerProformaToolStripMenuItem_Click);
            // 
            // Dashboad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FactZenith.Properties.Resources.Nouvelle_image_ZENITH;
            this.ClientSize = new System.Drawing.Size(1048, 563);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboad";
            this.Opacity = 0.98D;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboad_FormClosing);
            this.Load += new System.EventHandler(this.Dashboad_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fACTURATIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créerUneFactureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuStock;
        private System.Windows.Forms.ToolStripMenuItem voirLaLsiteDesProduitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuParametres;
        private System.Windows.Forms.ToolStripMenuItem gérerLesUtilisateursToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbUserInfos;
        private System.Windows.Forms.ToolStripMenuItem déconnexionToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem rapportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimerProformaToolStripMenuItem;

    }
}