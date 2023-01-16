
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
    public partial class Dashboad : MetroFramework.Forms.MetroForm
    {
        db.DBServer db = new db.DBServer();
        public Dashboad()
        {
            InitializeComponent();
        }
        public string id_user, firstname, lastname, role;
        public Dashboad(string _id_user, String _firstname, string _lastnamen, string _role)
        {
            InitializeComponent();

            this.id_user = _id_user;
            this.firstname = _firstname;
            this.lastname = _lastnamen;
            this.role = _role;

            lbUserInfos.Text="User connecté: "+firstname+" "+lastname+" ["+role+"] Connecté(e)";

            if (role != "admin")
            {
                menuParametres.Visible = false;
                menuStock.Visible = false;

            }
            
        }

        private void créerUneFactureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturation c = new Facturation(id_user,firstname,lastname,role);
            c.MdiParent = this;
            c.Show();
        }

        private void déconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Auth auth = new Auth();
            auth.Show();
        }

        private void voirLaLsiteDesProduitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatalogueProduit c = new CatalogueProduit();
            c.MdiParent = this;
            c.Show();
        }

        private void Dashboad_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void showMyDialog(string msg, Color bgCol)
        {
            Pop p=new Pop(msg,bgCol);
            p.Show();
        }

        private void gérerLesUtilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //showMyDialog("LA notification", Color.FromArgb(255, 53, 71));

            Admin a = new Admin();
            a.MdiParent = this;
            a.Show();
        }

        private void Dashboad_Load(object sender, EventArgs e)
        {
            
        }

        private void rapportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RapportVentes r = new RapportVentes();
            r.MdiParent = this;
            r.Show();
            
        }

        private void imprimerProformaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prof r = new Prof();
            r.MdiParent = this;
            r.Show();
        }

    }
}
