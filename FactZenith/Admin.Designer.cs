namespace FactZenith
{
    partial class Admin
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
            this.txtUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btAddUser = new MetroFramework.Controls.MetroButton();
            this.txtRole = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtConfirm = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPasswrd = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNom = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPrenom = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.activer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Depth = 0;
            this.txtUsername.Hint = "Nom d\'utilisateur";
            this.txtUsername.Location = new System.Drawing.Point(17, 24);
            this.txtUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.Size = new System.Drawing.Size(214, 23);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.UseSystemPasswordChar = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btAddUser);
            this.groupBox1.Controls.Add(this.txtRole);
            this.groupBox1.Controls.Add(this.txtConfirm);
            this.groupBox1.Controls.Add(this.txtPasswrd);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.txtPrenom);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Location = new System.Drawing.Point(23, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 267);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Création d\'un nouvel utilisateur";
            // 
            // btAddUser
            // 
            this.btAddUser.Location = new System.Drawing.Point(17, 225);
            this.btAddUser.Name = "btAddUser";
            this.btAddUser.Size = new System.Drawing.Size(146, 34);
            this.btAddUser.TabIndex = 1;
            this.btAddUser.Text = "Créer utilisateur...";
            this.btAddUser.UseSelectable = true;
            this.btAddUser.Click += new System.EventHandler(this.btAddUser_Click);
            // 
            // txtRole
            // 
            this.txtRole.Depth = 0;
            this.txtRole.Hint = "Role";
            this.txtRole.Location = new System.Drawing.Point(17, 196);
            this.txtRole.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRole.Name = "txtRole";
            this.txtRole.PasswordChar = '\0';
            this.txtRole.SelectedText = "";
            this.txtRole.SelectionLength = 0;
            this.txtRole.SelectionStart = 0;
            this.txtRole.Size = new System.Drawing.Size(214, 23);
            this.txtRole.TabIndex = 0;
            this.txtRole.UseSystemPasswordChar = false;
            // 
            // txtConfirm
            // 
            this.txtConfirm.Depth = 0;
            this.txtConfirm.Hint = "Confirmer votre mot de passe";
            this.txtConfirm.Location = new System.Drawing.Point(17, 163);
            this.txtConfirm.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.PasswordChar = '\0';
            this.txtConfirm.SelectedText = "";
            this.txtConfirm.SelectionLength = 0;
            this.txtConfirm.SelectionStart = 0;
            this.txtConfirm.Size = new System.Drawing.Size(214, 23);
            this.txtConfirm.TabIndex = 0;
            this.txtConfirm.UseSystemPasswordChar = false;
            // 
            // txtPasswrd
            // 
            this.txtPasswrd.Depth = 0;
            this.txtPasswrd.Hint = "******";
            this.txtPasswrd.Location = new System.Drawing.Point(17, 127);
            this.txtPasswrd.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPasswrd.Name = "txtPasswrd";
            this.txtPasswrd.PasswordChar = '*';
            this.txtPasswrd.SelectedText = "";
            this.txtPasswrd.SelectionLength = 0;
            this.txtPasswrd.SelectionStart = 0;
            this.txtPasswrd.Size = new System.Drawing.Size(214, 23);
            this.txtPasswrd.TabIndex = 0;
            this.txtPasswrd.UseSystemPasswordChar = false;
            // 
            // txtNom
            // 
            this.txtNom.Depth = 0;
            this.txtNom.Hint = "Nom";
            this.txtNom.Location = new System.Drawing.Point(17, 95);
            this.txtNom.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNom.Name = "txtNom";
            this.txtNom.PasswordChar = '\0';
            this.txtNom.SelectedText = "";
            this.txtNom.SelectionLength = 0;
            this.txtNom.SelectionStart = 0;
            this.txtNom.Size = new System.Drawing.Size(214, 23);
            this.txtNom.TabIndex = 0;
            this.txtNom.UseSystemPasswordChar = false;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Depth = 0;
            this.txtPrenom.Hint = "Prenom";
            this.txtPrenom.Location = new System.Drawing.Point(17, 61);
            this.txtPrenom.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.PasswordChar = '\0';
            this.txtPrenom.SelectedText = "";
            this.txtPrenom.SelectionLength = 0;
            this.txtPrenom.SelectionStart = 0;
            this.txtPrenom.Size = new System.Drawing.Size(214, 23);
            this.txtPrenom.TabIndex = 0;
            this.txtPrenom.UseSystemPasswordChar = false;
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.role,
            this.etat,
            this.prenom,
            this.nom,
            this.password,
            this.action,
            this.activer});
            this.dataGridViewUser.Location = new System.Drawing.Point(286, 93);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.Size = new System.Drawing.Size(847, 236);
            this.dataGridViewUser.TabIndex = 2;
            this.dataGridViewUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUser_CellContentClick);
            this.dataGridViewUser.Click += new System.EventHandler(this.dataGridViewUser_Click);
            // 
            // username
            // 
            this.username.HeaderText = "NOM D\'UTILISATEUR";
            this.username.Name = "username";
            // 
            // role
            // 
            this.role.HeaderText = "ROLE";
            this.role.Name = "role";
            // 
            // etat
            // 
            this.etat.HeaderText = "ETAT";
            this.etat.Name = "etat";
            // 
            // prenom
            // 
            this.prenom.HeaderText = "PRENOM";
            this.prenom.Name = "prenom";
            // 
            // nom
            // 
            this.nom.HeaderText = "NOM";
            this.nom.Name = "nom";
            // 
            // password
            // 
            this.password.HeaderText = "MOT DE PASSE";
            this.password.Name = "password";
            // 
            // action
            // 
            this.action.HeaderText = "Supprimer";
            this.action.Name = "action";
            this.action.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.action.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // activer
            // 
            this.activer.HeaderText = "Activation";
            this.activer.Name = "activer";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 354);
            this.Controls.Add(this.dataGridViewUser);
            this.Controls.Add(this.groupBox1);
            this.Name = "Admin";
            this.Text = "Gestion des utilisateurs";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsername;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRole;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtConfirm;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPasswrd;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNom;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrenom;
        private MetroFramework.Controls.MetroButton btAddUser;
        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.DataGridViewTextBoxColumn etat;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewButtonColumn action;
        private System.Windows.Forms.DataGridViewButtonColumn activer;
    }
}