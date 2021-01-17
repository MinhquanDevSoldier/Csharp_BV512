using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH1_Winform_QLBV512
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.StartPosition = FormStartPosition.CenterScreen;
            frmLogin.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void hồSơBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyCasPhauThuat frmQuanLyCasPhauThuat = new frmQuanLyCasPhauThuat();
            frmQuanLyCasPhauThuat.StartPosition = FormStartPosition.CenterScreen;
            frmQuanLyCasPhauThuat.Show();
        }
    }
}
