using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace Guna_UI
{
    public partial class frmStarting : SplashScreen
    {
        public frmStarting()
        {
            InitializeComponent();
            
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void peImage_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void frmStarting_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmStarting_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            frmMain frm = new frmMain();
            frm.ShowDialog();
        }
    }
}