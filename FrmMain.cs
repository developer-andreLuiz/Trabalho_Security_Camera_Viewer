using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityCameraViewer
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnTela1_Click(object sender, EventArgs e)
        {
            FrmPlayer1 f = new FrmPlayer1();
            f.Show();
        }
        private void btnTela2_Click(object sender, EventArgs e)
        {
            FrmPlayer2 f = new FrmPlayer2();
            f.Show();
        }
        private void btnTela4_Click(object sender, EventArgs e)
        {
            FrmPlayer4 f = new FrmPlayer4();
            f.Show();
        }
        private void btnTela8_Click(object sender, EventArgs e)
        {
            FrmPlayer8 f = new FrmPlayer8();
            f.Show();
        }
        private void btnTela16_Click(object sender, EventArgs e)
        {
            FrmPlayer16 f = new FrmPlayer16();
            f.Show();
        }
        private void btnConfig_Click(object sender, EventArgs e)
        {
            FrmConfig f = new FrmConfig();
            f.ShowDialog();
        }
    }
}
