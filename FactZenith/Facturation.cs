using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FactZenith
{
    public partial class Facturation : MetroFramework.Forms.MetroForm
    {
        //LES DIFFFERENTES VARIABLES  NECESSAIRES POUR LE BON FOCNTIONNEMENT
        public string id_user, firstname, lastname, role;
        string sql, f_etat, f_date,f_heure;
        SqlDataAdapter da;
        private SqlDataReader ligne;
        SqlCommand cmd;
        db.DBServer db = new db.DBServer();
        PrintPreviewDialog p=null;

        //LES VARIABLES METHODES NECESSAIRES POUR CONFIGURER LA DIMENSION DE LA FEUILLE D'IMPRESSION
        public int v_y;
        public int v_new(int v)
        {
            int vv;

            if (v == 0)
            {
                vv = v_y;
            }
            else
            {
                vv = v_y + v;
                v_y = v_y + v;
            }

            return vv;
        }
        public string c(string caract, int i)
        {
            string a = "";
            for (int b = 0; b < i; b++)
            {
                a = a + caract;
            }
            return a;
        }

        //LE CNSTRUCTEUR DE BASE DU FORMULAIRE
         public Facturation()
        {
            InitializeComponent();
            initNumFact();
            txtNumFac.Enabled = false;
            //getProduit();
            groupDetail.Enabled = false;
            p.Document = null;
            //lbCodeProd.Visible = false;
            getProduitAuto();
            
        }

         //LE CONSTRUCTEUR AVEC PARMETRES POUR INITIALISER LA SESSION DE L'UTILISATEUR
         public Facturation(string _id_user, String _firstname, string _lastnamen, string _role)
        {
            InitializeComponent();
            this.id_user = _id_user;
            this.firstname = _firstname;
            this.lastname = _lastnamen;
            this.role = _role;
            initNumFact();
            txtNumFac.Enabled = false;
            //getProduit();
            groupDetail.Enabled = false;
            //lbCodeProd.Visible=false;
            getProduitAuto();
            
        }
         //LORSQU'ON CLIQUE SUR LE BOUTON CREER FACTURE
         private void btCreerFacture_Click(object sender, EventArgs e)
         {
             comboDevise.Enabled = false;
             if (btCreerFacture.Text == "Facturer client")
             {
                 //string prix = txtPrix.Text;
                 
                 if (txtPrix.Text != "" && txtQuantite.Value.ToString() != "0")
                 {
                     validerMonaie();
                 }
                 else
                 {
                     MessageBox.Show("Veuillez remplir tous les champs SVP!", "Avertissement");
                     comboDevise.Enabled = true;
                 }

             }
             else if (btCreerFacture.Text == "Modifier")
             {
                 db.OUvrirConnexion();
                 EditerFacture(Convert.ToDouble(txtPrix.Text), Convert.ToInt16(txtQuantite.Value.ToString()), txtAuto.Text.ToString(), lbCodeProd.Text);
                 dataGridViewTest.Rows.Clear();
                 Visualiser();
                 DialogResult result = MessageBox.Show("Voulez-vous Imprimer?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                 if (result == DialogResult.Yes)
                 {
                     PrintPreviewDialog p = new PrintPreviewDialog();
                     p.Document = printDocumentFacture;
                     p.Text = "Previsualisation";
                     p.ShowDialog();
                     //printDocumentFacture.Print();
                     initNumFact();
                     groupDetail.Enabled = false;
                     txtCleint.Enabled = true;
                     txtPrix.Text = "";
                 }
                 else if (result == DialogResult.No)
                 {
                     btCreerFacture.Text = "Facturer client";
                 }

             }
 
         }

         //METHODES OU FONCTION POUR EXECUTER LA REQUETE D'INSERTION D'UNE FACTURE
         public void CreerFacture(string numero, string client, string m_date, string m_heure, string etat, string id_user)
         {
             string msg = "Facture bien ajoutée";
             sql = "INSERT INTO Facture(num_fac,cleint,date_to,time_to,etat,id_user) VALUES('" + numero + "','" + client + "','" + m_date + "','" + m_heure + "','" + etat + "','" + id_user + "')";
             db.ExecuteNonQuery(sql,msg);
         }

         //METHODES OU FONCTION POUR EXECUTER LA REQUETE D'INSERTION D'UN DETAIL DE LA FACTURE
         public void CreerDeatailFacture(string facture, string prod, decimal prix, int q,string devise)
         {
             string msg = "Détail facture bien ajouté";
             sql = "INSERT INTO Concerner(facture,produit,prix,quantite,devise) VALUES('" + facture + "','" + prod + "','" + prix + "','" + q + "','" + devise+ "')";
             db.ExecuteNonQuery(sql,msg);
         }

         //METHODES OU FONCTION POUR INITIALISER LES NUMERO DE LA FACTURE
        public void initNumFact()
        {
            da = new SqlDataAdapter("SELECT COUNT(*) as nbre FROM Facture", db.chaine);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int i = 0; int s = 0; string sign = "";
            for (i = 0; i < dt.Rows.Count; i++)
            {
                s = int.Parse((dt.Rows[i]["nbre"].ToString())) + 1;
                sign = "ZTH-" + s.ToString() + "-020";
                txtNumFac.Text = sign;
            }
        }

         /*METHODES OU FONCTION POUR AFFICHER LA DIGNATION DES PRODUITS DANS COMBOBOX DES PRODUIT
        public void getProduit()
        {
            da = new SqlDataAdapter("SELECT * FROM Produit", db.chaine);
            DataTable dt = new DataTable();
            da.Fill(dt);
          
            for (int i = 0; i < dt.Rows.Count; i++)
            {
               comboProduit.Items.Add(dt.Rows[i]["designation"].ToString());
                
            }
        }
       */
        public void getProduitAuto()
        {
            db.OUvrirConnexion();
            sql = "SELECT * FROM Produit";
            ligne = db.ExecuterDuReader(sql);
            AutoCompleteStringCollection strg = new AutoCompleteStringCollection();
            while (ligne.Read())
            {
                strg.Add(ligne["designation"].ToString());
            }
            txtAuto.AutoCompleteCustomSource = strg;
        }

        //METHODES OU FONCTION POUR RETOURNER LA CODE DU PRODUIT LORSQU'ON SELECTIONNE SA DESIGNATION
        public void getCodeProduit(String des)
        {
            try
            {
                da = new SqlDataAdapter("SELECT code FROM Produit WHERE designation='" + des + "'", db.chaine);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lbCodeProd.Text = dt.Rows[i]["code"].ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //GESTION DE L'IMPRESSION DE LA FACTURE
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            try
            {
                da = new SqlDataAdapter("SELECT Concerner.facture,Facture.cleint,Produit.designation,Concerner.prix,Concerner.quantite,"+
                   "Concerner.devise,Facture.date_to, Concerner.prix*Concerner.quantite as pt"+
					" from Concerner"+
                    " INNER JOIN Facture on Concerner.facture = facture.num_fac INNER JOIN Produit on Concerner.produit = Produit.code"+
                    " WHERE Concerner.facture = Facture.num_fac AND Concerner.facture= '"+txtNumFac.Text+"'", db.chaine);
                DataTable dt = new DataTable();
                da.Fill(dt);
               


                v_y = 0;
                string my_date = DateTime.Today.ToShortDateString();
                string heure = DateTime.Now.ToShortTimeString();

                StringFormat align = new StringFormat();
                align.Alignment = StringAlignment.Center;
                align.LineAlignment = StringAlignment.Center;


                printDocumentFacture.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("4x8", 40, 80);

                int taille = e.PageBounds.Height;
                float leftMargin = e.MarginBounds.Left;
                float topMargin = e.MarginBounds.Top;

                Font police = new Font("Arial", 14);
                
                police = new Font("Arial", 19, FontStyle.Bold);

                /*Rectangle rect1 = new Rectangle(10, v_new(40), e.PageBounds.Width, 40);
                e.Gr.aphics.DrawRectangle(Pens.Black, rect1);*/
                e.Graphics.DrawString("ETS ZENITH  ", police, new SolidBrush(Color.Black), ((e.PageBounds.Width / 2) - 30), v_new(40), align);
                e.Graphics.DrawString("Informatique & Bureautique/RDC ", police, new SolidBrush(Color.Black), ((e.PageBounds.Width / 2) - 30), v_new(40), align);
                police = new Font("Arial", 15);
                e.Graphics.DrawString("ID: NAT6-93N74068 NIF: A1682588X RCCM/17-A-5610", police, new SolidBrush(Color.Black), 80, v_new(40));
                e.Graphics.DrawString("Av. LOMAMI Q.MAKUTANO C.L'shi/HAUT-KATANGA", police, new SolidBrush(Color.Black), 80, v_new(40));
                e.Graphics.DrawString(c("-", e.PageBounds.Width), police, new SolidBrush(Color.Black), 20, v_new(15));

                police = new Font("Arial", 13);
                e.Graphics.DrawString( "Caissier :"+firstname+" "+lastname+"        Date :"+my_date + "     Heure :"+heure, police, new SolidBrush(Color.Black), 10, v_new(40));
                
                e.Graphics.DrawString(c("-", 300), police, new SolidBrush(Color.Black), 20, v_new(40));


                e.Graphics.DrawString("FACTURE N°:"+txtNumFac.Text, police, new SolidBrush(Color.Black), ((e.PageBounds.Width / 2) - 30), v_new(40), align);
                police = new Font("Arial", 14, FontStyle.Bold);
                e.Graphics.DrawString(c("-", 300), police, new SolidBrush(Color.Black), 20, v_new(10));

                e.Graphics.DrawString("Designation ", police, new SolidBrush(Color.Black), 10, v_new(40));
                e.Graphics.DrawString("Prix ", police, new SolidBrush(Color.Black), 350, v_new(0));
                e.Graphics.DrawString("Quantité ", police, new SolidBrush(Color.Black), 450, v_new(0));
                e.Graphics.DrawString("Total ", police, new SolidBrush(Color.Black), 600, v_new(0));
                police = new Font("Arial", 14);

                int i = 0;
                double total = 0;
                for (i = 0; i < dt.Rows.Count; i++)
                {
                    Double mt = Convert.ToDouble(dt.Rows[i]["pt"].ToString());
                    total = total + mt;
                    e.Graphics.DrawString(" " + dt.Rows[i]["designation"].ToString(), police, new SolidBrush(Color.Black), 20, v_new(30));
                    e.Graphics.DrawString(" " + dt.Rows[i]["prix"].ToString(), police, new SolidBrush(Color.Black), 320, v_new(0));
                    e.Graphics.DrawString(" " + dt.Rows[i]["quantite"].ToString(), police, new SolidBrush(Color.Black), 480, v_new(0));

                    e.Graphics.DrawString("" + dt.Rows[i]["pt"].ToString(), police, new SolidBrush(Color.Black), 600, v_new(0));

                    //dataGridViewTest.Rows.Add(dt.Rows[i]["facture"].ToString(), dt.Rows[i]["designation"].ToString(), dt.Rows[i]["cleint"].ToString(), dt.Rows[i]["quantite"].ToString(), dt.Rows[i]["prix"].ToString(), dt.Rows[i]["pt"].ToString());
                }
                //dataGridViewTest.Rows.Add("TOTAL", " ", "", " ", " ", total.ToString() + " USD", "");
                police = new Font("Arial", 18, FontStyle.Bold);

                e.Graphics.DrawString("Net à payer :" + total.ToString()+" "+comboDevise.SelectedItem.ToString(), police, new SolidBrush(Color.Black), ((e.PageBounds.Width / 2) - 200), v_new(60));
                police = new Font("Arial", 14);
                e.Graphics.DrawString("**** Au plaisir de vous revoir encore, Merci! ****", police, new SolidBrush(Color.Black), ((e.PageBounds.Width / 2) - 30), v_new(70), align);
                e.HasMorePages = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        //LORSUE L'UTILISATEUR ENTRER LE NOM DU CLIENT ET CLIQUE SUR ENTRER
        private void txtCleint_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                da = new SqlDataAdapter("SELECT COUNT(*) as nbre FROM Facture", db.chaine);
                DataTable dt = new DataTable();
                da.Fill(dt);
                int i = 0; int s = 0; string sign = "";
                f_date = DateTime.Now.ToString("yyyy-MM-dd");
                f_heure = DateTime.Now.ToString("hh:mm:ss tt");
                f_etat = "NP";
                for (i = 0; i < dt.Rows.Count; i++)
                {
                    s = int.Parse((dt.Rows[i]["nbre"].ToString())) + 1;
                    sign = "ZTH-" + s.ToString() + "-020";
                    txtNumFac.Text = sign;

                    db.OUvrirConnexion();
                    CreerFacture(sign, txtCleint.Text, f_date, f_heure, f_etat, id_user);
                    groupDetail.Enabled = true;
                    txtCleint.Enabled = false;

                }
            }
        }

        public void Visualiser()
        {

            try
            {
                da = new SqlDataAdapter("SELECT Concerner.facture,Concerner.produit,Facture.cleint,Produit.designation,Concerner.prix,Concerner.quantite," +
                   "Concerner.devise,Facture.date_to, Concerner.prix*Concerner.quantite as pt" +
                    " from Concerner" +
                    " INNER JOIN Facture on Concerner.facture = facture.num_fac INNER"+
                    " JOIN Produit on Concerner.produit = Produit.code" +
                    " WHERE Concerner.facture = Facture.num_fac AND Concerner.facture= '" + txtNumFac.Text+ "'", db.chaine);
                DataTable dt = new DataTable();
                da.Fill(dt);
                int i = 0;
                double total = 0;
                for (i = 0; i < dt.Rows.Count; i++)
                {
                    Double mt = Convert.ToDouble(dt.Rows[i]["pt"].ToString());
                    total = total + mt;
                    dataGridViewTest.Rows.Add(dt.Rows[i]["facture"].ToString(), dt.Rows[i]["cleint"].ToString(), dt.Rows[i]["designation"].ToString(), dt.Rows[i]["quantite"].ToString(), dt.Rows[i]["prix"].ToString(), dt.Rows[i]["produit"].ToString(), dt.Rows[i]["pt"].ToString(), "Supprimer");
                }
                dataGridViewTest.Rows.Add("", " ", "", " ", "TOTAL ", total.ToString() + " " + comboDevise.SelectedItem.ToString(), "");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
        }

        public void validerMonaie()
        {
            

            try
            {
                db.OUvrirConnexion();
                sql = "SELECT Concerner.devise FROM Concerner WHERE Concerner.facture='" + txtNumFac.Text + "'";
                ligne = db.ExecuterDuReader(sql);

                if (ligne.HasRows)
                {
                    while (ligne.Read())
                    {
                        string devise = ligne["devise"].ToString();
                        if (comboDevise.Text == devise)
                        {
                            MessageBox.Show("DEVISE INCORRECTE", "Avertissement");
                        }
                        else
                        {
                            //MessageBox.Show(devise, "Avertissement");
                            db.OUvrirConnexion();
                            CreerDeatailFacture(txtNumFac.Text, lbCodeProd.Text, Convert.ToDecimal(txtPrix.Text), Convert.ToInt16(txtQuantite.Value.ToString()), comboDevise.SelectedItem.ToString());
                            dataGridViewTest.Rows.Clear();
                            Visualiser();
                            comboDevise.Enabled = false;
                            txtPrix.Text = "";
                            comboDevise.Text = "";
                        }
                    }

                }
                else
                {
                    db.OUvrirConnexion();
                    CreerDeatailFacture(txtNumFac.Text, lbCodeProd.Text, Convert.ToDecimal(txtPrix.Text), Convert.ToInt16(txtQuantite.Value.ToString()), comboDevise.SelectedItem.ToString());
                    dataGridViewTest.Rows.Clear();
                    Visualiser();
                }
            }
            catch (Exception ex)
            {
                
                comboDevise.Enabled =true;
            }

            
        }

        private void dataGridViewTest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int ligne = dataGridViewTest.CurrentRow.Index;
                int col_clique = dataGridViewTest.CurrentCell.ColumnIndex;
                if (col_clique == 7)
                {

                    DialogResult r = MessageBox.Show("Voulez-vous supprimer la facture?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        int id = dataGridViewTest.CurrentRow.Index;
                        string numero = dataGridViewTest.Rows[id].Cells["prod"].Value.ToString();
                        db.OUvrirConnexion();
                        SupprimerFactureDetail(numero);
                        dataGridViewTest.Rows.Clear();

                        Visualiser();
                        btCreerFacture.Text = "Facturer client";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SupprimerFactureDetail(string facture)
        {
            try
            {
                string msg = "Facture bien supprimée";
                sql = "DELETE FROM Concerner WHERE produit='" + facture+"'";
                db.ExecuteNonQuery(sql, msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information");
            }
        }

        private void EditerFacture(double prix,int qt,string devise,string facture)
        {
            try
            {
                string msg = "Facture bien modifiée";
                sql = "UPDATE Concerner SET prix='" + prix + "',quantite='" + qt + "' ,devise='" + qt + "' WHERE produit='" + facture + "'";
                db.ExecuteNonQuery(sql, msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information");
            }
        }

        private void dataGridViewTest_Click(object sender, EventArgs e)
        {
            try
            {
                int id = dataGridViewTest.CurrentRow.Index;
                txtPrix.Text = dataGridViewTest.Rows[id].Cells["prix"].Value.ToString();
                txtQuantite.Text = dataGridViewTest.Rows[id].Cells["quantite"].Value.ToString();
                btCreerFacture.Text = "Modifier";
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Facturation_Load(object sender, EventArgs e)
        {
            getProduitAuto();
            getCodeProduit(txtAuto.Text);
        }

        private void txtAuto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                da = new SqlDataAdapter("SELECT * FROM Produit WHERE designation='" + des + "'", db.chaine);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (txtAuto.Text != dt.Rows[i]["designation"].ToString())
                    {
                        MessageBox.Show("Designation incorrete", "Avertissement");
                    }
                    else
                    {
                        lbCodeProd.Text = dt.Rows[i]["code"].ToString();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getCodeProduit(txtAuto.Text);
            MessageBox.Show("TATA");
        }

        private void txtAuto_TextChanged(object sender, EventArgs e)
        {
            getCodeProduit(txtAuto.Text);
            
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            //this.Close();
            PrintPreviewDialog p = new PrintPreviewDialog();
            p.Document = printDocumentFacture;
            p.Text = "Previsualisation";
            p.ShowDialog();
            //this.Show();
            //printDocumentFacture.Print();
            this.Close();
            /*
            initNumFact();
            groupDetail.Enabled = false;
            txtCleint.Enabled = true;
            txtPrix.Text = "";
            dataGridViewTest.Rows.Clear();
            comboDevise.Enabled = false;
            */
            
        }

        private void txtPrix_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

      }
}
