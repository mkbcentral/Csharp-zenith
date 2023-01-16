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
    public partial class Admin : MetroFramework.Forms.MetroForm
    {
        db.DBServer db = new db.DBServer();
        string sql;
        //private SqlDataReader ligne;

        public Admin()
        {
            InitializeComponent();
            AfficherUsers();
        }

        public void AfficherUsers()
        {

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Utilisateur", db.chaine);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //comboProduit.Items.Add(dt.Rows[i]["code"].ToString());
                //dgProduit.Rows.Add(dt.Rows[i]["code"].ToString(),dt.Rows[i]["designation"].ToString());
                dataGridViewUser.Rows.Add(dt.Rows[i]["username"].ToString(), dt.Rows[i]["firstname"].ToString(), dt.Rows[i]["lastname"].ToString(), dt.Rows[i]["password"].ToString(), dt.Rows[i]["role"].ToString(), dt.Rows[i]["etat"].ToString(), "Supprimer","Déactiver");
            }
        }

        public void AjouterUser()
        {
            string msg = "Utilistaeur bien ajoutés";
            string etat = "D";
            sql = "INSERT INTO Utilisateur(username,firstname,lastname,password,role,etat) VALUES('" + txtUsername.Text + "','" + txtPrenom.Text + "','" + txtNom.Text + "','" + txtPasswrd.Text+ "','" + txtRole.Text + "','" + etat + "')";
            db.ExecuteNonQuery(sql, msg);
            try
            {
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information");
            }

        }

        private void btAddUser_Click(object sender, EventArgs e)
        {
            db.OUvrirConnexion();
            AjouterUser();
            dataGridViewUser.Rows.Clear();
            AfficherUsers();
            try
            {
                if (txtPasswrd.Text != txtConfirm.Text)
                {
                    MessageBox.Show("Veillez bien confirmer le mot de passe", "Avertissement");
                }
                else
                {
                    
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int ligne = dataGridViewUser.CurrentRow.Index;
                int col_clique = dataGridViewUser.CurrentCell.ColumnIndex;
                if (col_clique == 6)
                {

                    DialogResult r = MessageBox.Show("Voulez-vous vraiment supprimer?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        int id = dataGridViewUser.CurrentRow.Index;
                        string data = dataGridViewUser.Rows[id].Cells["username"].Value.ToString();
                        db.OUvrirConnexion();
                        SupprimerUser(data);
                        dataGridViewUser.Rows.Clear();
                        AfficherUsers();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SupprimerUser(string data)
        {
            try
            {
                string msg = "Utilisateur bein supprimé";
                sql = "DELETE FROM Utilisateur WHERE username='" + data + "'";
                db.ExecuteNonQuery(sql, msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information");
            }
        }

        private void dataGridViewUser_Click(object sender, EventArgs e)
        {
            int id = dataGridViewUser.CurrentRow.Index;
            dataGridViewUser.Enabled = false;
            txtUsername.Text = dataGridViewUser.Rows[id].Cells["username"].Value.ToString();
            txtPrenom.Text = dataGridViewUser.Rows[id].Cells["prenom"].Value.ToString();
            txtNom.Text = dataGridViewUser.Rows[id].Cells["nom"].Value.ToString();
            txtPasswrd.Text = dataGridViewUser.Rows[id].Cells["password"].Value.ToString();
            txtRole.Text = dataGridViewUser.Rows[id].Cells["role"].Value.ToString();
           
            btAddUser.Text = "Modifier";
        }
    }
}
