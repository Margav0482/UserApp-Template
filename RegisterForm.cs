using System;
using System.Globalization;
using System.Data;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace UserApp
{
    public partial class RegisterForm : Form
    {
        //Variables:

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CAPTION = 0x2;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            var list = CultureInfo.GetCultures(CultureTypes.SpecificCultures).Select(p => new RegionInfo(p.Name).EnglishName).Distinct().OrderBy(s => s).ToList();
            registercountrycombobox.DataSource = list;

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void registercountrycombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void registerusernamebox_TextChanged(object sender, EventArgs e)
        {
        }

        private void createaccbutton_Click(object sender, EventArgs e)
        {
            // Create Account Button: 
            bool checkcondition = false;

            string registerusernameinput = registerusernamebox.Text;
            string registerpassinput = registerpasswordbox.Text;
            string confirmpassinput = registerconfirmpasswordbox.Text;
            string dob = registerdobbox.Text;
            string firstname = registerfirstnamebox.Text; 
            string lastname = registerlastnamebox.Text;
            string contact = registercontactbox.Text;
            string email = registeremailbox.Text;
            string country = registercountrycombobox.Text;
            int age = DateTime.Now.Year - registerdobbox.Value.Year;


            //Minimum eight, Max 20 characters, at least one uppercase letter, one lowercase letter and one number:
            var userregex = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,20}$";

            //Minimum 6 characters, at least one uppercase letter, one lowercase letter, one number and one special character:
            var passregex = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{6,}$";

            //Minimum 10 numbers and must be digits:
            var phoneregex = @"^[0-9]{10}";

            //Validating Email:
            string emailpattern = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
            
            bool isEmail = Regex.IsMatch(email, emailpattern, RegexOptions.IgnoreCase);


            Regex uregex = new Regex(userregex);
            Match usermatch = uregex.Match(registerusernameinput);  

            Regex pregex = new Regex(passregex);
            Match passmatch = pregex.Match(registerpassinput);

            Regex phregex = new Regex(phoneregex);
            Match phonematch = phregex.Match(contact);


            if ((firstname != null) && (lastname != null) && (age >= 18) && (contact != null) && (email != null) && (country != null) && isEmail && (firstname != lastname))
            {
                checkcondition = true;
            }
            else
            {
                checkcondition = false;
            }


            if ((usermatch.Success) && (passmatch.Success) && (phonematch.Success) && (confirmpassinput == registerpassinput) && checkcondition && (registerusernameinput != registerpassinput))
            {
                // Push the data to table.

                string sqlcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\marga\Desktop\Margav\ADT\UserApp\LDB\UserAppData.mdf;Integrated Security=True;Connect Timeout=30";

                SqlConnection conn = new SqlConnection(sqlcon);

                conn.Open();

                string query1 = "INSERT INTO LoginInfo(username,password,firstname,lastname,dob,contact,email,country) VALUES ('"+ registerusernameinput + "','"+ confirmpassinput +"','"+ firstname +"','"+ lastname +"','"+ dob + "','" + contact + "','" + email + "','" + country + "')";

                SqlCommand cmd = new SqlCommand(query1, conn);
                cmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Account created successfully!");

                this.Hide();
                LoginForm lf = new LoginForm();
                lf.Show();
                
                
            }
            else if (usermatch.Success == false)
            {
                MessageBox.Show("Username must have 8 to 20 Characters, containing atleast 1 uppercase, 1 lowercase and 1 number!");
            } 
            else if (passmatch.Success == false)
            {
                MessageBox.Show("Password must have Minimum 6 Characters, containing atleast 1 uppercase, 1 lowercase and 1 number!");

            }
            else if (phonematch.Success == false)
            {
                MessageBox.Show("Incorrect Phone Number!");

            }
            else if(registerusernameinput == registerpassinput)
            {
                MessageBox.Show("Password and Username cannot be same!");
            }

            else if (confirmpassinput != registerpassinput)
            {
                MessageBox.Show("Password and Confirm Password must be same.");
            }
            else if (checkcondition == false)
            {
                MessageBox.Show("Please fill every details and make sure your age is 18 or above!");
            } 
            else if (firstname == lastname)
            {
                MessageBox.Show("First name and last name cannot be same!");
            }
            else if (isEmail == false)
            {
                MessageBox.Show("Please re-verify your email address!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void returnbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}