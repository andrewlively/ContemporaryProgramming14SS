using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorial_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calculateFactorial_Click(object sender, EventArgs e)
        {
            int retval = 1;
            for (int a = Convert.ToInt32(factorialInputBox.Text); a > 0; a--)
            {
                retval = retval * a;
            }
            factorialLabel.Text = "Factorial: " + retval;
        }
    }
}
