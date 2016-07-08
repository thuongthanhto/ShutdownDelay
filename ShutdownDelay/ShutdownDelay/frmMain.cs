using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShutdownDelay
{
    public partial class frmMain : Form
    {
        int TogMove;
        int MValX;
        int MValY;
        public frmMain()
        {
            InitializeComponent();
            txtSoPhut.Text = "Nhập vào số phút";
        }

        private void frmMain_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void frmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMininize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtSoPhut_Enter(object sender, EventArgs e)
        {
            if ( txtSoPhut.Text == "Nhập vào số phút")
            {
                txtSoPhut.Text = "";
                txtSoPhut.ForeColor = Color.Gray;
            }
        }

        private void txtSoPhut_Leave(object sender, EventArgs e)
        {
            if (txtSoPhut.Text == "")
            {
                txtSoPhut.Text = "Nhập vào số phút";
                txtSoPhut.ForeColor = Color.Gray;
            }
        }

        private void btnHenGio_Click(object sender, EventArgs e)
        {
            try
            {
                int giay = int.Parse(txtSoPhut.Text) * 60;
                ProcessStartInfo proc = new ProcessStartInfo("cmd", "/c shutdown -s -t " + giay + "");
                proc.RedirectStandardOutput = true;
                proc.UseShellExecute = false;
                proc.CreateNoWindow = true;
                Process a = new Process();
                a.StartInfo = proc;
                a.Start();
                MessageBox.Show(this, "Hẹn giờ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                txtSoPhut.Focus();
                MessageBox.Show(this, "Vui lòng nhập số phút", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
           
            
            
        }

        private void btnHuyHenGio_Click(object sender, EventArgs e)
        {
            ProcessStartInfo proc = new ProcessStartInfo("cmd", "/c shutdown -a");
            proc.RedirectStandardOutput = true;
            proc.UseShellExecute = false;
            proc.CreateNoWindow = true;
            Process a = new Process();
            a.StartInfo = proc;
            a.Start();
            MessageBox.Show(this, "Hủy hẹn giờ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
