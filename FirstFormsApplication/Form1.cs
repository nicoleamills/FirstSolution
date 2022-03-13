using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstFormsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, result;
            num1 = Convert.ToInt32(this.txtFirst.Text);
            num2 = Convert.ToInt32(this.txtSecond.Text);
            String operation = Convert.ToString(txtThird.Text);
            if (operation.Equals("+"))
            {
                result = num1 + num2;
                lbl.Text = result.ToString();
            }
            else if (operation.Equals("-"))
            {
                result = num1 - num2;
                lbl.Text = result.ToString();
            }
            else if (operation.Equals("*"))
            {
                result = num1 * num2;
                lbl.Text = result.ToString();
            }
            else
            {
                lbl.Text = "Invalid choice.";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
    }
}