using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Guna_UI
{
    public partial class frmMain : Form
    {

        private Form currentChildForm;
        public frmMain()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            panel_Main.Controls.Add(childForm);
            panel_Main.Tag = childForm;
            childForm.BringToFront();
            //childForm.Dock = DockStyle.Right;
            childForm.Show();
        }
       
        private void pic_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Setup_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void btn_InfoUser_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new frmChangePass());
            frmChangePass frm = new frmChangePass();
            frm.ShowDialog();           
        }

        private void btn_Taophien_Click(object sender, EventArgs e)
        {
            frmAddsession frm = new frmAddsession();
            frm.ShowDialog();
        }

        private void panel_Main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
            timer_Main.Start();
        }

        private void timer_Main_Tick(object sender, EventArgs e)
        {
            float fCPU = CPU.NextValue();
            cir_CPU.Value = (int)fCPU;
            lb_CPU.Text = string.Format("{0:00.0}%", fCPU);

            float fHD = HD.NextValue();
            cir_HD.Value = (int)fHD;
            lb_HD.Text = string.Format("{0:00.0}GB", fHD);

            datetime_calendar.Value = DateTime.Now;
                      
        }

        private void lb_RAM_Click(object sender, EventArgs e)
        {

        }
    }
}
