using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guna_UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void pic_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lnk_ConfigSQL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmConfigSQL frmSQL = new frmConfigSQL();
            frmSQL.Show();
        }
    }
}
