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
    public partial class RapportVentes : MetroFramework.Forms.MetroForm
    {
        public RapportVentes()
        {
            InitializeComponent();
        }

        private void RapportVentes_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'db_zenithDataSet.Rapport'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.RapportTableAdapter.Fill(this.db_zenithDataSet.Rapport);
            // TODO: cette ligne de code charge les données dans la table 'db_zenithDataSet.Total'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.TotalTableAdapter.Fill(this.db_zenithDataSet.Total);

            this.reportViewer1.RefreshReport();
        }

        private void btVisualier_Click(object sender, EventArgs e)
        {
            string f_date = DateTime.Now.ToString("dd-MM-yyyy");
            MessageBox.Show(f_date+" "+comboDevise.SelectedItem.ToString());
            this.RapportTableAdapter.GetRapport(f_date,comboDevise.SelectedItem.ToString());
            this.TotalTableAdapter.GetTot(comboDevise.SelectedItem.ToString(), f_date);
            this.reportViewer1.RefreshReport();
        }
    }
}
