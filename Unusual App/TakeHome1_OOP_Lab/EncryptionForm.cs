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
    public partial class EncryptionForm : Form
    {
        
        public EncryptionForm()
        {
            InitializeComponent();
            txtAlp.ForeColor = Color.Gray;
            rdoEncCea.Checked = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtAlp_MouseClick(object sender, MouseEventArgs e)
        {
            //txtAlp.Text = "";
            //txtAlp.ForeColor = Color.Black;
        }

        private void EncryptionForm_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdoEncCea_CheckedChanged(object sender, EventArgs e)
        {
            lblValue.Text = "Rot Value";
            
        }

        private void rdoEncVig_CheckedChanged(object sender, EventArgs e)
        {
            lblValue.Text = "            Key";
            
        }

        private void rdoDecCea_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdoDecVig_CheckedChanged(object sender, EventArgs e)
        {
            lblValue.Text = "            Key";

        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            EncryptionClass encCls = new Ceaser();

            if (rdoEncCea.Checked == true)
            {
                string temp = "";
                temp = encCls.Encrypt(txtAlp.Text, txtStr.Text, txtValue.Text);
                rtxtResult.Text = temp;
            }
            else if(rdoDecCea.Checked == true)
            {
                string temp = "";
                temp = encCls.Decrypt(txtAlp.Text, txtStr.Text, txtValue.Text);
                rtxtResult.Text = temp;
            }
            else if(rdoEncVig.Checked == true)
            {
                string temp = "";
                
                EncryptionClass encC = new Vigenere();
                temp = encC.Encrypt(txtAlp.Text, txtStr.Text, txtValue.Text);
                rtxtResult.Text = temp;

            }
            else if (rdoDecVig.Checked == true)
            {
                string temp = "";

                EncryptionClass encC = new Vigenere();
                temp = encC.Decrypt(txtAlp.Text, txtStr.Text, txtValue.Text);
                rtxtResult.Text = temp;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
