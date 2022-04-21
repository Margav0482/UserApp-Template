using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserApp
{
    public partial class IndexForm : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CAPTION = 0x2;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }
        public IndexForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void changepassbox_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePassword cp = new ChangePassword();
            cp.Show();
        }

        private void accdetailsbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountDetails acd = new AccountDetails();
            acd.Show();
        }
    }
}
