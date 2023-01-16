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
    public partial class Pop : Form
    {
        public Pop(String msg,Color bgCol)
        {
            InitializeComponent();
            BackColor = bgCol;
            lbInfos.Text = msg;
        }

        private void Pop_Load(object sender, EventArgs e)
        {
            Top = 20;
            Left = Screen.PrimaryScreen.Bounds.Width - Width - 20;
            timerClose.Start();
        }

        private void timerClose_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
