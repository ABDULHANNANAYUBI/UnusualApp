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
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
        }
        /// creating singleton calculator...
        /// The using the singleton in calculator class is usefull for our code...
        CalculateClass calculate = CalculateClass.Instance;

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            /// converting the text to the double numbers
            string number1 = "";
            string number2 = "";
            if (txtNum1.Text == "")
            {
                number1 = "0";
            }
            else
            {
                number1 = txtNum1.Text;
            }
            if (txtNum2.Text == "")
                number2 = "0";
            else
            {
                number2 = txtNum2.Text;
            }

            calculate.num1 = Convert.ToDouble(number1);
            calculate.num2 = Convert.ToDouble(number2);
            calculate.result = calculate.SumC(calculate.num1, calculate.num2);
            txtResult.Text = calculate.result.ToString();
            /// In this part we use conditional statement with the result if the result is greater than zero than we colored the label
            /// with red or green acording to the result
            if (calculate.result > 0)
            {
                txtResult.BackColor = Color.Green;
                txtResult.ForeColor = Color.White;

            }
            else
            {
                txtResult.BackColor = Color.Red;
                txtResult.ForeColor = Color.White;
            }
                
            pictureBox6.BackColor = Color.Gray;
            pictureBox7.BackColor=Color.FromArgb(40,40,40);
            pictureBox8.BackColor = Color.FromArgb(40, 40, 40);
            pictureBox9.BackColor = Color.FromArgb(40, 40, 40);
            flag6 = true;

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            string number1 = "";
            string number2 = "";
            if (txtNum1.Text == "")
            {
                number1 = "0";
            }
            else
            {
                number1 = txtNum1.Text;
            }
            if (txtNum2.Text == "")
                number2 = "0";
            else
            {
                number2 = txtNum2.Text;
            }

            calculate.num1 = Convert.ToDouble(number1);
            calculate.num2 = Convert.ToDouble(number2);
            calculate.result = calculate.SubC(calculate.num1, calculate.num2);
            txtResult.Text = calculate.result.ToString();
            if (calculate.result > 0)
            {
                txtResult.BackColor = Color.Green;
                txtResult.ForeColor = Color.White;
            }
            else
            {
                txtResult.BackColor = Color.Red;
                txtResult.ForeColor = Color.White;
            }

            pictureBox7.BackColor = Color.Gray;
            pictureBox6.BackColor = Color.FromArgb(40, 40, 40);
            pictureBox8.BackColor = Color.FromArgb(40, 40, 40);
            pictureBox9.BackColor = Color.FromArgb(40, 40, 40);
            flag7 = true;

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            string number1 = "";
            string number2 = "";
            if (txtNum1.Text == "")
            {
                number1 = "0";
            }
            else
            {
                number1 = txtNum1.Text;
            }
            if (txtNum2.Text == "")
                number2 = "0";
            else
            {
                number2 = txtNum2.Text;
            }

            calculate.num1 = Convert.ToDouble(number1);
            calculate.num2 = Convert.ToDouble(number2);
            calculate.result = calculate.MultC(calculate.num1, calculate.num2);
            txtResult.Text = calculate.result.ToString();
            if (calculate.result > 0)
            {
                txtResult.BackColor = Color.Green;
                txtResult.ForeColor = Color.White;
            }
            else
            {
                txtResult.BackColor = Color.Red;
                txtResult.ForeColor = Color.White;
            }

            pictureBox8.BackColor = Color.Gray;
            pictureBox7.BackColor = Color.FromArgb(40, 40, 40);
            pictureBox6.BackColor = Color.FromArgb(40, 40, 40);
            pictureBox9.BackColor = Color.FromArgb(40, 40, 40);
            flag8 = true;

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            /// we use try cautch for division with zero...
            try
            {
                string number1 = "";
                string number2 = "";
                if (txtNum1.Text == "")
                {
                    number1 = "0";
                }
                else
                {
                    number1 = txtNum1.Text;
                }
                if (txtNum2.Text == "")
                    number2 = "0";
                else
                {
                    number2 = txtNum2.Text;
                }

                calculate.num1 = Convert.ToDouble(number1);
                calculate.num2 = Convert.ToDouble(number2);
                calculate.result = calculate.DivC(calculate.num1, calculate.num2);
                txtResult.Text = calculate.result.ToString();
                if (calculate.result > 0)
                {
                    txtResult.BackColor = Color.Green;
                    txtResult.ForeColor = Color.White;
                }
                else
                {
                    txtResult.BackColor = Color.Red;
                    txtResult.ForeColor = Color.White;
                }

                pictureBox9.BackColor = Color.Gray;
                pictureBox7.BackColor = Color.FromArgb(40, 40, 40);
                pictureBox8.BackColor = Color.FromArgb(40, 40, 40);
                pictureBox6.BackColor = Color.FromArgb(40, 40, 40);
                flag9 = true;

            }
            catch (DivideByZeroException)
            {
                pictureBox9.BackColor = Color.Gray;
                pictureBox7.BackColor = Color.FromArgb(40, 40, 40);
                pictureBox8.BackColor = Color.FromArgb(40, 40, 40);
                pictureBox6.BackColor = Color.FromArgb(40, 40, 40);
                txtResult.Text = "Divided by zero!";
                flag9 = true;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        bool flag6 = false, flag7 = false, flag8 = false, flag9 = false;

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Red;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            if (flag6 == true)
                flag6 = false;
            else
                pictureBox6.BackColor = Color.FromArgb(40, 40, 40);

        }
        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            pictureBox7.BackColor = Color.Red;

        }
        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            if (flag7 == true)
                flag7 = false;
            else
                pictureBox7.BackColor = Color.FromArgb(40, 40, 40);

        }
        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            pictureBox8.BackColor = Color.Red;

        }
        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtNum2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }
        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            if (flag8 == true)
                flag8 = false;
            else
                pictureBox8.BackColor = Color.FromArgb(40, 40, 40);

        }
        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            pictureBox9.BackColor = Color.Red;

        }
        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            if (flag9 == true)
                flag9 = false;
            else
                pictureBox9.BackColor = Color.FromArgb(40, 40, 40);

        }
    }
}
