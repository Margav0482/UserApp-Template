using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace UserApp
{
    public partial class ChangePassword : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CAPTION = 0x2;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void returnbackbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            IndexForm inf = new IndexForm();
            inf.Show();
        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
            // Submit Button redirect to Login Form
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\marga\Desktop\Margav\ADT\UserApp\LDB\UserAppData.mdf;Integrated Security=True;Connect Timeout=30";

            string currentpasstext = currentpassbox.Text;
            string newpasstext = newpassbox.Text;
            string confpasstext = confirmnewpassbox.Text;

            var passregex = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{6,}$";
            Regex pregex = new Regex(passregex);
            Match passmatch = pregex.Match(newpasstext);

            SqlConnection sqlcon = new SqlConnection(con);

            sqlcon.Open();

            string q1 = "SELECT * FROM LoginInfo WHERE password = '" + currentpasstext + "';";

            SqlCommand cmd0 = new SqlCommand(q1, sqlcon);
            SqlDataReader rdr1 = cmd0.ExecuteReader();



            if ((rdr1.Read()) && (passmatch.Success) && (confpasstext == newpasstext))
            {
                rdr1.Close();

                string q2 = "UPDATE LoginInfo SET password = '" + newpasstext + "' WHERE username = '" + LoginForm.user_loggedin_username + "';";

                SqlCommand cmd1 = new SqlCommand(q2, sqlcon);
                cmd1.ExecuteNonQuery();

                MessageBox.Show("Your password has been successfully changed, redirecting back to login!");

                this.Hide();

                LoginForm lf = new LoginForm();
                lf.Show();
            }
            else if (passmatch.Success == false)
            {
                MessageBox.Show("Password must have Minimum 6 Characters, containing atleast 1 uppercase, 1 lowercase and 1 number!");
            }
            else if (confpasstext != newpasstext)
            {
                MessageBox.Show("New Password and Confirm password must be same!");
            }
            else if (rdr1.Read() == false)
            {
                MessageBox.Show("Phone number is incorrect!");
            }

            sqlcon.Close();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
