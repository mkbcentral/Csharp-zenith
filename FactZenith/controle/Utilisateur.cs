using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FactZenith.controle
{
    class Utilisateur
    {
        private String id_user, firstname, lastname, role;
        db.DBServer db = new db.DBServer();
        private SqlDataReader ligne;
        string sql;

        public void seConnecter(string username, string password)
        {
            try
            {
                db.OUvrirConnexion();
                sql = "SELECT * FROM Utilisateur WHERE username='" + username + "' AND password= '" + password + "'";
                ligne = db.ExecuterDuReader(sql);

                if (ligne.HasRows)
                {
                    while (ligne.Read())
                    {
                        id_user = ligne["id_user"].ToString();
                        firstname = ligne["firstname"].ToString();
                        lastname = ligne["lastname"].ToString();
                        role = ligne["role"].ToString();
                    }
                    MessageBox.Show("Connecté ! \n" + "Utilisateur: " + firstname + " " + lastname + "\n Role: " + role+" Connecté(e)", "Resultat");

                    Dashboad dash = new Dashboad(id_user,firstname,lastname,role);
                    dash.Show();

                }
                else
                {
                    MessageBox.Show("Echec d'Authentification", "Avertissement");
                    Auth auth = new Auth();
                    auth.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur:\n" + ex.Message, "Informations");
            }
        }
    }
}
