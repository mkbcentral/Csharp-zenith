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
using Tulpep.NotificationWindow;
namespace FactZenith
{
    public partial class CatalogueProduit : MetroFramework.Forms.MetroForm
    {
        db.DBServer db = new db.DBServer();
        string sql;
        private SqlDataReader ligne;
   
        public CatalogueProduit()
        {
            InitializeComponent();
            dataGridViewProduit.Rows.Clear();
            AfficherCatalogue();
            
        }

        public void AjouterPrduit(String code,String designation)
        {
            try
            {
                string msg = "Produit bien ajouté au catalogue";
                sql = "INSERT INTO Produit(code,designation) VALUES('" + code + "','" + designation + "')";
                db.ExecuteNonQuery(sql, msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information");
            }
            
        }
        public void SupprimerProdToCat(string code)
        {
            string msg = "Produit bien supprimé";
            sql = "DELETE FROM Produit WHERE code='" + code + "'";
            db.ExecuteNonQuery(sql, msg);
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information");
            }
        }
        public void ModifierProdToCat(string produit,string code)
        {
            try
            {
                string msg = "Produit bien modifié";
                sql = "UPDATE Produit SET Designation='" + produit + "' WHERE Code='" + code + "'";
                db.ExecuteNonQuery(sql, msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information");
            }
        }
        private void btAddToCatalogue_Click(object sender, EventArgs e)
        {
            try
            {

               
                if (txtCodeProduit.Text == "" && txtDesignation.Text == "")
                {
                    MessageBox.Show("Veuillez remplir tous les champs SVP!!!", "Information");
                }
                else
                {
                    if (btAddToCatalogue.Text == "Modifier")
                    {
                        db.OUvrirConnexion();
                        ModifierProdToCat(txtDesignation.Text,txtCodeProduit.Text);
                        dataGridViewProduit.Rows.Clear();
                        AfficherCatalogue();
                        txtCodeProduit.Clear(); txtCodeProduit.Enabled = true;
                        txtDesignation.Clear();
                        btAddToCatalogue.Text = "Ajoutez au catalogue";
                    }
                    else
                    {
                        db.OUvrirConnexion();
                        dataGridViewProduit.Rows.Clear();
                        AjouterPrduit(txtCodeProduit.Text, txtDesignation.Text);
                        AfficherCatalogue();
                        
                    }
                   
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Information");
            }
        }

        public void AfficherCatalogue()
        {
          
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Produit", db.chaine);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //comboProduit.Items.Add(dt.Rows[i]["code"].ToString());
                //dgProduit.Rows.Add(dt.Rows[i]["code"].ToString(),dt.Rows[i]["designation"].ToString());
                dataGridViewProduit.Rows.Add(dt.Rows[i]["code"].ToString(), dt.Rows[i]["designation"].ToString(),"Supprimer");
            }
        }

        private void btRech_Click(object sender, EventArgs e)
        {
            db.OUvrirConnexion();
            sql = "SELECT * FROM Produit WHERE designation like'" + txtRech.Text + "%'";
            dataGridViewProduit.Rows.Clear();
            ligne = db.ExecuterDuReader(sql);
            if (ligne.HasRows)
            {
                while (ligne.Read())
                {
                    dataGridViewProduit.Rows.Add(ligne["code"].ToString(), ligne["designation"].ToString(), "Supprimer");
                    txtRech.Clear();
                }
            }
            else
            {
                MessageBox.Show("Aucun produit trouvé pour le code "+txtRech.Text, "Avertissement");
                txtRech.Clear();
            }
        }

        private void txtRech_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.A)
            {
                dataGridViewProduit.Rows.Clear();
                AfficherCatalogue();
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                db.OUvrirConnexion();
                sql = "SELECT * FROM Produit WHERE designation like'" + txtRech.Text + "%'";
                dataGridViewProduit.Rows.Clear();
                ligne = db.ExecuterDuReader(sql);
                if (ligne.HasRows)
                {
                    while (ligne.Read())
                    {
                        dataGridViewProduit.Rows.Add(ligne["code"].ToString(), ligne["designation"].ToString());
                        txtRech.Clear();
                    }

                }
                else
                {
                    MessageBox.Show("Aucun produit trouvé pour le code " + txtRech.Text, "Avertissement");
                    txtRech.Clear();
                }
            }
        }

        private void dataGridViewProduit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int ligne = dataGridViewProduit.CurrentRow.Index;
                int col_clique = dataGridViewProduit.CurrentCell.ColumnIndex;
                if (col_clique == 2)
                {

                    DialogResult r = MessageBox.Show("Voulez-vous vraiment supprimer?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        int id = dataGridViewProduit.CurrentRow.Index;
                        string data = dataGridViewProduit.Rows[id].Cells["code_"].Value.ToString();
                        MessageBox.Show(data);
                        db.OUvrirConnexion();
                        SupprimerProdToCat(data);
                        dataGridViewProduit.Rows.Clear();
                        AfficherCatalogue();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewProduit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = dataGridViewProduit.CurrentRow.Index;
                txtCodeProduit.Enabled = false;
                txtCodeProduit.Text = dataGridViewProduit.Rows[id].Cells["code_"].Value.ToString();
                txtDesignation.Text = dataGridViewProduit.Rows[id].Cells["des"].Value.ToString();
                btAddToCatalogue.Text = "Modifier";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void printDocumentCat_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            string titre = "Test";
            string contenu = "Juste un test";
            afficherPopUp(titre, contenu);
        }

        public void afficherPopUp(string titre, string contenu)
        {
            PopupNotifier popup = new PopupNotifier();
            
            popup.TitleText = titre;
            popup.ContentText = contenu;
            popup.Popup();
        }
    }
}
