using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakeHome1_OOP_Lab
{
    public partial class FormLogin : Form
    {
        /// <User ///class>
        /// In here I initialize the user list for the class...
        List<string> usernames = new List<string>();
        List<string> passwords = new List<string>();
        UserClass userclass = UserClass.Instance;
        public FormLogin()
        {
            /// As the task says the I create a four user with the name of the group members...
            InitializeComponent();
            
            usernames = userclass.Usernames;
            passwords = userclass.Passwords;
            usernames.Add("admin");//Default User
            passwords.Add(CreateMD5("admin"));/// Default user password...

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            /// For this we use picture and by clicking picture the form goes to minimize itself...
            this.WindowState = FormWindowState.Minimized; /// Using this for minimizing the windows form application 
            
        }
        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            /// This is for logging in here I use loop to contol the validation of the enterd user.
            /// the codition controls the all user with the password the index of enterd user and password must be 
            /// in the same index otherwise The user cannot be entered.
            string temp1 = CreateMD5(txtPassword.Text); 
            for (int i = 0; i < usernames.Count; i++)
            {
                if (txtUsername.Text.ToLower() == usernames[i] && temp1 == passwords[i]) 
                {
                    lblLogin.Text = "Login Successfull!";
                    lblLogin.BackColor = Color.Green;
                    timer1.Start();
                    return;
                }         
            }
            /// If the user cannot enter or the user information is wrong it can't enter to program.
            lblLogin.Text = "Login Unsuccessfull!";
            lblLogin.BackColor = Color.Red;
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            /// Using time tick is for the 3 second as the task says ...
            this.Hide();
            ///In this section we create new form to transition ...
            ApplicationMenu appMenu = new ApplicationMenu();
            appMenu.Show(); /// this is for the showing the new form in here
            timer1.Stop(); /// this is for stopping the timer...
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpForm signupfrm = new SignUpForm();
            signupfrm.Show();
        }
    }
}
