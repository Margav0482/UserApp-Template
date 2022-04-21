using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace UserApp
{
    public partial class LoginForm : Form
    {
        //Variables:

        public static string user_loggedin_username = "";

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CAPTION = 0x2;


        public LoginForm()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void forgotpasslabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Pass to ForgotPassword
            this.Hide();
            ForgotPass fp = new ForgotPass();
            fp.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterForm rf = new RegisterForm();
            rf.Show();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\marga\Desktop\Margav\ADT\UserApp\LDB\UserAppData.mdf;Integrated Security=True;Connect Timeout=30";
            bool emailinput = false;
            string usertext = usernamebox.Text;
            string passtext = passwordbox.Text;

            if (usertext.Contains("@"))
            {
                emailinput = true;
            }

            SqlConnection sqlcon = new SqlConnection(con);

            sqlcon.Open();
            if (!emailinput) { 
                string q1 = "SELECT * FROM LoginInfo WHERE password = '" + passtext +"' " + "AND username = '" + usertext + "';";

                SqlCommand cmd0 = new SqlCommand(q1, sqlcon);
                SqlDataReader rdr1 = cmd0.ExecuteReader();
                if (rdr1.Read())
                {
                    MessageBox.Show("Logged-in Successfully!");
                    user_loggedin_username = usertext;
                    this.Hide();
                    IndexForm inf = new IndexForm();
                    inf.Show();
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect!");
                }

                rdr1.Close();

                
            } else
            {
                string q1 = "SELECT * FROM LoginInfo WHERE password = '" + passtext + "' " + "AND email = '" + usertext + "';";

                SqlCommand cmd0 = new SqlCommand(q1, sqlcon);
                SqlDataReader rdr1 = cmd0.ExecuteReader();
                if (rdr1.Read())
                {
                    MessageBox.Show("Logged-in Successfully!");
                    user_loggedin_username = usertext;
                    this.Hide();
                    IndexForm inf = new IndexForm();
                    inf.Show();
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect!");
                }

                rdr1.Close();
            }
            sqlcon.Close();

        }

        private void usernamebox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
