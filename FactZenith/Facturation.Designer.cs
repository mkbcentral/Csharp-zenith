namespace FactZenith
{
    partial class Facturation
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
            this.txtQuantite = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCleint = new System.Windows.Forms.TextBox();
            this.txtNumFac = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.printDocumentFacture = new System.Drawing.Printing.PrintDocument();
            this.comboDevise = new MetroFramework.Controls.MetroComboBox();
            this.btCreerFacture = new MetroFramework.Controls.MetroButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupDetail = new System.Windows.Forms.GroupBox();
            this.txtAuto = new System.Windows.Forms.TextBox();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCodeProd = new System.Windows.Forms.Label();
            this.dataGridViewTest = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editer = new System.Windows.Forms.DataGridViewLinkColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btPrint = new MetroFramework.Controls.MetroButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantite)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTest)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtQuantite
            // 
            this.txtQuantite.Location = new System.Drawing.Point(17, 188);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(147, 25);
            this.txtQuantite.TabIndex = 7;
            this.txtQuantite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(32, 87);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nom du client";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(32, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Numéro de la facture";
            // 
            // txtCleint
            // 
            this.txtCleint.Location = new System.Drawing.Point(36, 109);
            this.txtCleint.Name = "txtCleint";
            this.txtCleint.Size = new System.Drawing.Size(259, 25);
            this.txtCleint.TabIndex = 0;
            this.txtCleint.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCleint_KeyPress);
            // 
            // txtNumFac
            // 
            this.txtNumFac.Location = new System.Drawing.Point(36, 53);
            this.txtNumFac.Multiline = true;
            this.txtNumFac.Name = "txtNumFac";
            this.txtNumFac.Size = new System.Drawing.Size(259, 23);
            this.txtNumFac.TabIndex = 0;
            this.txtNumFac.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCleint);
            this.groupBox1.Controls.Add(this.txtNumFac);
            this.groupBox1.Location = new System.Drawing.Point(15, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 222);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Facture";
            // 
            // printDocumentFacture
            // 
            this.printDocumentFacture.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // comboDevise
            // 
            this.comboDevise.FormattingEnabled = true;
            this.comboDevise.ItemHeight = 23;
            this.comboDevise.Items.AddRange(new object[] {
            "CDF",
            "USD"});
            this.comboDevise.Location = new System.Drawing.Point(13, 117);
            this.comboDevise.Name = "comboDevise";
            this.comboDevise.Size = new System.Drawing.Size(166, 29);
            this.comboDevise.TabIndex = 6;
            this.comboDevise.UseSelectable = true;
            // 
            // btCreerFacture
            // 
            this.btCreerFacture.BackColor = System.Drawing.Color.Turquoise;
            this.btCreerFacture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCreerFacture.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btCreerFacture.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btCreerFacture.Location = new System.Drawing.Point(185, 161);
            this.btCreerFacture.Name = "btCreerFacture";
            this.btCreerFacture.Size = new System.Drawing.Size(196, 55);
            this.btCreerFacture.TabIndex = 3;
            this.btCreerFacture.Text = "Facturer client";
            this.btCreerFacture.UseCustomBackColor = true;
            this.btCreerFacture.UseCustomForeColor = true;
            this.btCreerFacture.UseSelectable = true;
            this.btCreerFacture.UseStyleColors = true;
            this.btCreerFacture.Click += new System.EventHandler(this.btCreerFacture_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Devise";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(209, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prix unitaire";
            // 
            // groupDetail
            // 
            this.groupDetail.BackColor = System.Drawing.Color.White;
            this.groupDetail.Controls.Add(this.txtAuto);
            this.groupDetail.Controls.Add(this.txtPrix);
            this.groupDetail.Controls.Add(this.txtQuantite);
            this.groupDetail.Controls.Add(this.comboDevise);
            this.groupDetail.Controls.Add(this.btCreerFacture);
            this.groupDetail.Controls.Add(this.label4);
            this.groupDetail.Controls.Add(this.label3);
            this.groupDetail.Controls.Add(this.label1);
            this.groupDetail.Controls.Add(this.label2);
            this.groupDetail.Location = new System.Drawing.Point(337, 72);
            this.groupDetail.Name = "groupDetail";
            this.groupDetail.Size = new System.Drawing.Size(386, 222);
            this.groupDetail.TabIndex = 6;
            this.groupDetail.TabStop = false;
            this.groupDetail.Text = "Détail facture";
            // 
            // txtAuto
            // 
            this.txtAuto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAuto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtAuto.Location = new System.Drawing.Point(13, 53);
            this.txtAuto.Name = "txtAuto";
            this.txtAuto.Size = new System.Drawing.Size(362, 25);
            this.txtAuto.TabIndex = 11;
            this.txtAuto.TextChanged += new System.EventHandler(this.txtAuto_TextChanged);
            this.txtAuto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAuto_KeyPress);
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(186, 117);
            this.txtPrix.Multiline = true;
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(189, 29);
            this.txtPrix.TabIndex = 8;
            this.txtPrix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrix_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantité";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choisir un produit";
            // 
            // lbCodeProd
            // 
            this.lbCodeProd.AutoSize = true;
            this.lbCodeProd.BackColor = System.Drawing.Color.White;
            this.lbCodeProd.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodeProd.ForeColor = System.Drawing.Color.Red;
            this.lbCodeProd.Location = new System.Drawing.Point(730, 78);
            this.lbCodeProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCodeProd.Name = "lbCodeProd";
            this.lbCodeProd.Size = new System.Drawing.Size(57, 24);
            this.lbCodeProd.TabIndex = 1;
            this.lbCodeProd.Text = "Code";
            // 
            // dataGridViewTest
            // 
            this.dataGridViewTest.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.client,
            this.des,
            this.quantite,
            this.prix,
            this.prod,
            this.tot,
            this.editer});
            this.dataGridViewTest.Location = new System.Drawing.Point(11, 36);
            this.dataGridViewTest.Name = "dataGridViewTest";
            this.dataGridViewTest.Size = new System.Drawing.Size(847, 181);
            this.dataGridViewTest.TabIndex = 10;
            this.dataGridViewTest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTest_CellContentClick);
            this.dataGridViewTest.Click += new System.EventHandler(this.dataGridViewTest_Click);
            // 
            // numero
            // 
            this.numero.HeaderText = "NUMERO";
            this.numero.Name = "numero";
            // 
            // client
            // 
            this.client.HeaderText = "CLIENT";
            this.client.Name = "client";
            // 
            // des
            // 
            this.des.HeaderText = "DESIGNATION";
            this.des.Name = "des";
            // 
            // quantite
            // 
            this.quantite.HeaderText = "QUANTITE";
            this.quantite.Name = "quantite";
            // 
            // prix
            // 
            this.prix.HeaderText = "PRIX";
            this.prix.Name = "prix";
            // 
            // prod
            // 
            this.prod.HeaderText = "CODE";
            this.prod.Name = "prod";
            // 
            // tot
            // 
            this.tot.HeaderText = "Total";
            this.tot.Name = "tot";
            // 
            // editer
            // 
            this.editer.HeaderText = "Suppression";
            this.editer.LinkColor = System.Drawing.Color.Red;
            this.editer.Name = "editer";
            this.editer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.editer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewTest);
            this.groupBox2.Location = new System.Drawing.Point(15, 301);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(874, 223);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Visualisation de la facture";
            // 
            // btPrint
            // 
            this.btPrint.BackColor = System.Drawing.Color.Turquoise;
            this.btPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPrint.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btPrint.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btPrint.Location = new System.Drawing.Point(720, 530);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(153, 35);
            this.btPrint.TabIndex = 11;
            this.btPrint.Text = "Imprimer";
            this.btPrint.UseCustomBackColor = true;
            this.btPrint.UseCustomForeColor = true;
            this.btPrint.UseSelectable = true;
            this.btPrint.UseStyleColors = true;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // Facturation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 580);
            this.Controls.Add(this.btPrint);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupDetail);
            this.Controls.Add(this.lbCodeProd);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Facturation";
            this.Padding = new System.Windows.Forms.Padding(27, 78, 27, 26);
            this.Text = "Facturation";
            this.Load += new System.EventHandler(this.Facturation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantite)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupDetail.ResumeLayout(false);
            this.groupDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTest)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txtQuantite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCleint;
        private System.Windows.Forms.TextBox txtNumFac;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Drawing.Printing.PrintDocument printDocumentFacture;
        private MetroFramework.Controls.MetroComboBox comboDevise;
        private MetroFramework.Controls.MetroButton btCreerFacture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupDetail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.Label lbCodeProd;
        private System.Windows.Forms.DataGridView dataGridViewTest;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn client;
        private System.Windows.Forms.DataGridViewTextBoxColumn des;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn tot;
        private System.Windows.Forms.DataGridViewLinkColumn editer;
        private System.Windows.Forms.TextBox txtAuto;
        private MetroFramework.Controls.MetroButton btPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;

    }
}