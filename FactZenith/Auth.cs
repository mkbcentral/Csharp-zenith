using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactZenith
{
    public partial class Auth : MetroFramework.Forms.MetroForm
    {
        controle.Utilisateur user = new controle.Utilisateur();

        public Auth()
        {
            InitializeComponent();
        }

        //lORSQU'ON CLIQUE SUR SE CONNECTER
        private void btSeconneter_Click(object sender, EventArgs e)
        {
            if (txtUnsername.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Veillez remplir tous les champs SVP!!!", "Avertissement");
            }
            else
            {
               if(txtUnsername.Text.Length<4)
               {
                   MessageBox.Show("Le nom de l'utilisateur ne doit pas avoir moin 4 caractères\nEntrez un autre SVP ou contactez l'Administrateur", "Attention");
               }
               else
               {
                   if (txtPassword.Text.Length < 6)
                   {
                       MessageBox.Show("Le mot de passe ne doit pas avoir moin 6 caractères\nEntrez un autre SVP ou contactez l'Administrateur", "Attention !");
                   }
                   else
                   {
                       user.seConnecter(txtUnsername.Text, txtPassword.Text);
                       this.Hide();
                   }
               }
            }
        }

        //lORSQU'ON ENTRE LE MOT DE PASSE ET QU'N CLIQUE SUR ENTRER
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtUnsername.Text == "" && txtPassword.Text == "")
                {
                    MessageBox.Show("Veillez remplir tous les champs SVP!!!", "Avertissement");
                }
                else
                {
                    user.seConnecter(txtUnsername.Text, txtPassword.Text);
                    this.Hide();
                }
            }
        }

        private void Auth_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
