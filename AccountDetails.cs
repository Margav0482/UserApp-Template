using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
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
    public partial class AccountDetails : Form
    {
        public AccountDetails()
        {
            InitializeComponent();
        }

        private void returnbackbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            IndexForm inf = new IndexForm();
            inf.Show();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AccountDetails_Load(object sender, EventArgs e)
        {

            var list = CultureInfo.GetCultures(CultureTypes.SpecificCultures).Select(p => new RegionInfo(p.Name).EnglishName).Distinct().OrderBy(s => s).ToList();
            countrybox.DataSource = list;



            //Profile Settings Form opened, need to update all the current info first.

            //Variables:

            string fn = firstnamebox.Text;
            string ln = lastnamebox.Text;
            string country = countrybox.Text;
            string state = countrybox.Text;
            string city = citybox.Text;
            string dob = dobbox.Text;
            string contact = contactbox.Text; 
            string email = emailbox.Text;


            //Connection:

            string sqlcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\marga\Desktop\Margav\ADT\UserApp\LDB\UserAppData.mdf;Integrated Security=True;Connect Timeout=30";

            //Query:

            string q1 = "SELECT * FROM LoginInfo WHERE Username = '" + LoginForm.user_loggedin_username +"';";

            SqlConnection con = new SqlConnection(sqlcon);
            con.Open();

            SqlCommand cmd0 = new SqlCommand(q1, con);
            SqlDataReader rdr0 = cmd0.ExecuteReader();


            if (rdr0.Read())
            {
                firstnamebox.Text = (string)rdr0.GetValue("firstname");
                lastnamebox.Text = (string)rdr0.GetValue("lastname");
                countrybox.Text = (string)rdr0.GetValue("country");
                emailbox.Text = (string)rdr0.GetValue ("email");
                contactbox.Text = Convert.ToInt64(rdr0.GetValue("contact")).ToString();
                dobbox.Text = (string)rdr0.GetValue("dob");

                if((rdr0.GetValue("city") == null) && (rdr0.GetValue("state") == null))
                {
                    citybox.Text = "";
                    countrybox.Text = "";
                }else if (rdr0.GetValue("state") == null)
                {
                    countrybox.Text = "";
                } else if (rdr0.GetValue("city") == null)
                {
                    citybox.Text = "";
                } else if((rdr0.GetValue("city") != null) && (rdr0.GetValue("state") != null))
                {
                    citybox.Text = (string)rdr0.GetValue("city");
                    statebox.Text = (string)rdr0.GetValue("state");
                }

            }
            rdr0.Close();

            con.Close();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            //Variables:

            string fn = firstnamebox.Text;
            string ln = lastnamebox.Text;
            string country = countrybox.Text;
            string state = statebox.Text;
            string city = citybox.Text;
            string dob = dobbox.Text;
            string contact = contactbox.Text; 
            string email = emailbox.Text;
                        
            //Connection:

            string sqlcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\marga\Desktop\Margav\ADT\UserApp\LDB\UserAppData.mdf;Integrated Security=True;Connect Timeout=30";

            //Query:

            string q1 = "SELECT * FROM LoginInfo WHERE Username = '" + LoginForm.user_loggedin_username + "';";

            SqlConnection con = new SqlConnection(sqlcon);
            con.Open();

            SqlCommand cmd0 = new SqlCommand(q1, con);
            SqlDataReader rdr0 = cmd0.ExecuteReader();

            if (rdr0.Read())
            {
                long phtext = (long)rdr0.GetValue("contact");

                string q2 = "UPDATE LoginInfo SET firstname= '" + fn +  "'," + "lastname = '" + ln + "'," + "country = '" + country + "'," + "state = '" + state + "'," + "city = '" + city + "'," + "dob = '" + dob + "'," + "email = '" + email + "' WHERE contact=" + phtext + ";";
                
                SqlCommand cmd1 = new SqlCommand(q2, con);
                rdr0.Close();
                if (cmd1.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("Updated your information!");
                    this.Hide();
                    IndexForm inf = new IndexForm();
                    inf.Show();

                }
                else
                {
                    MessageBox.Show("You cannot remove any of your data. Update it as per your choice.");
                }
            }
            else if(rdr0.Read() == false)
            {
               
            }
            rdr0.Close();

        }
    }
}
