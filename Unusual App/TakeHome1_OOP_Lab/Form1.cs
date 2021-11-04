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
    public partial class SignUpForm : Form
    {
        UserClass userclass = UserClass.Instance; /// Data Set
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string temp1 = "";
            string temp2 = "";
            temp1 = CreateMD5(txtPassword.Text);
            temp2 = CreateMD5(txtCPassword.Text);
            if (temp1 == temp2 && txtUserName.Text.Length > 0 && txtPassword.Text.Length > 0) 
            {
                userclass.Add(txtUserName.Text, temp1);
                lblresult.Text = "Registered Successfully!";
                lblresult.BackColor = Color.Green;
                txtPassword.Text = "";
                txtUserName.Text = "";
                txtCPassword.Text = "";
            }
            else
            {
                MessageBox.Show("Passwords don't match!", "Wrong Password", MessageBoxButtons.OK);
                txtPassword.Text = "";
                txtCPassword.Text = "";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin frmlogin = new FormLogin();
            frmlogin.Show();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void lbll_Click(object sender, EventArgs e)
        {

        }
    }
}
