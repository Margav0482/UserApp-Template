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
    public partial class ForgotPass : Form
    {
        public ForgotPass()
        {
            InitializeComponent();
        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
            // Submit Button redirect to Login Form
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\marga\Desktop\Margav\ADT\UserApp\LDB\UserAppData.mdf;Integrated Security=True;Connect Timeout=30";
            
            string phtext = phonenumberbox.Text;
            string passtext = newpassbox.Text;
            string newpasstext = confirmnewpassbox.Text;

            var passregex = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{6,}$";
            Regex pregex = new Regex(passregex);
            Match passmatch = pregex.Match(passtext);

            SqlConnection sqlcon = new SqlConnection(con);

            sqlcon.Open();

            string q1 = "SELECT * FROM LoginInfo WHERE contact = " + phtext;

            SqlCommand cmd0 = new SqlCommand(q1, sqlcon);
            SqlDataReader rdr1 = cmd0.ExecuteReader();
            var phoneregex = @"^[0-9]{10}";

            Regex phregex = new Regex(phoneregex);
            Match phonematch = phregex.Match(phtext);


            if ((rdr1.Read()) && (passmatch.Success) && (passtext == newpasstext) && (phonematch.Success))
            {
                rdr1.Close();

                string q2 = "UPDATE LoginInfo SET password= '" + passtext + "' WHERE contact=" + phtext + ";";

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
            else if(passtext != newpasstext)
            {
                MessageBox.Show("New Password and Confirm password must be same!");
            } 
            else if (phonematch.Success == false)
            {
                MessageBox.Show("Phone Number is not Valid!");
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void returnbackbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void usernamebox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
