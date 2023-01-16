namespace FactZenith
{
    partial class Auth
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUnsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btSeconneter = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUnsername
            // 
            this.txtUnsername.Depth = 0;
            this.txtUnsername.Hint = "Nom d\'utilisateur";
            this.txtUnsername.Location = new System.Drawing.Point(57, 179);
            this.txtUnsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUnsername.Name = "txtUnsername";
            this.txtUnsername.PasswordChar = '\0';
            this.txtUnsername.SelectedText = "";
            this.txtUnsername.SelectionLength = 0;
            this.txtUnsername.SelectionStart = 0;
            this.txtUnsername.Size = new System.Drawing.Size(283, 23);
            this.txtUnsername.TabIndex = 0;
            this.txtUnsername.UseSystemPasswordChar = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Depth = 0;
            this.txtPassword.Hint = "********";
            this.txtPassword.Location = new System.Drawing.Point(57, 223);
            this.txtPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.Size = new System.Drawing.Size(283, 23);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.UseSystemPasswordChar = false;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // btSeconneter
            // 
            this.btSeconneter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSeconneter.Location = new System.Drawing.Point(225, 272);
            this.btSeconneter.Name = "btSeconneter";
            this.btSeconneter.Size = new System.Drawing.Size(115, 38);
            this.btSeconneter.TabIndex = 1;
            this.btSeconneter.Text = "Se connecter";
            this.btSeconneter.UseSelectable = true;
            this.btSeconneter.Click += new System.EventHandler(this.btSeconneter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FactZenith.Properties.Resources._011_user;
            this.pictureBox1.Location = new System.Drawing.Point(159, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 333);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btSeconneter);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUnsername);
            this.Name = "Auth";
            this.Opacity = 0.97D;
            this.Text = "Authentification";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Auth_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtUnsername;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPassword;
        private MetroFramework.Controls.MetroButton btSeconneter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

