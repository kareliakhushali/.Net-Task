using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUITask
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void lblNum1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var num1 = Convert.ToInt32(nupnum1.Value);
            var num2 = Convert.ToInt32(nupnum2.Value);
            string single = cmbSingle.Text;
            string db = cmbDouble.Text;
            string output1 = string.Empty;
            string output2 = string.Empty;
            String a = "Prime";
            String b = "Armstrong";
            String c = "Palindrome";
            String d = "Maximum";
            String min = "Minimum";
            String f = "Equal";
            String g = "Power";

            if (single == a)
            {
                bool IsPrime = true;
                for (int i = 2; i < num1 / 2; i++)
                {
                    if (num1 % i == 0)
                    {
                        IsPrime = false;
                        break;
                    }
                }
                if (IsPrime)
                {
                    output1 += ($" {num1} Number is Prime");
                    lblOutput1.Text = output1;
                }
                else
                {
                    output1+= ($"{num1} Number is Not Prime");
                    lblOutput1.Text = output1;
                }
            }
            if (single == b)
            {
                int r, sum = 0, temp;
                temp = num1;
                while (num1 > 0)
                {
                    r = num1 % 10;
                    sum = sum + (r * r * r);
                    num1 = num1 / 10;
                }
                if (temp == sum)
                {
                    output1 += ($"{temp} Number is Armstrong");
                    lblOutput1.Text = output1;
                }
                else
                {
                    output1 += ($"{temp} Number is not Armstrong");
                    lblOutput1.Text = output1;
                }
            }
            if (single == c)
            {
                int rp, sump = 0, tempp;
                tempp = num1;
                while (num1 > 0)
                {
                    rp = num1 % 10;
                    sump = (sump * 10) + rp;
                    num1 = num1 / 10;
                }
                if (tempp == sump)
                {
                    output1 += ($"{tempp} Number is Palindrome");
                    lblOutput1.Text = output1;
                }
                else
                {
                    output1 += ($"{tempp} Number is not Palindrome");
                    lblOutput1.Text = output1;
                }
            }
            if (db == d)
            {
                if (num1 > num2)
                {
                    output2 += ($"{num1} is Maximum Number");
                    lblOutput2.Text = output2;
                }
                else
                {
                    output2 += ($"{num2} is Maximum Number");
                    lblOutput2.Text = output2;
                }
            }
            if (db == min)
            {
                if (num1 < num2)
                {
                    output2 += ($"{num1} is Minimum Number");
                    lblOutput2.Text = output2;
                }
                else
                {
                    output2 += ($"{num2} is Minimum Number");
                    lblOutput2.Text = output2;
                }
            }
            if (db == f)
            {
                if (num1 == num2)
                {
                    output2 += ("Both Numbers Are Equal");
                    lblOutput2.Text = output2;
                }
                else
                {
                    output2 += ("Both Numbers Are Not Equal");
                    lblOutput2.Text = output2;
                }
            }
            if (db == g)
            {
                int res;
                res = CalculatePower(num1, num2);
                output2 += ($"The value of  {num1}  to the power of  {num2}  is:-  {res}");
                lblOutput2.Text = output2;
            }
        }
        public static int CalculatePower(int x, int y)
        {
            if (y == 0)
                return 1;
            else
                return x * CalculatePower(x, y - 1);
        }
        private void nupNo1_ValueChanged(object sender, EventArgs e)
        { 
        }

    }
    }

            
  