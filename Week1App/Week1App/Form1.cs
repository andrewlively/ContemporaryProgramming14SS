using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week1App.Models;

namespace Week1App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student s = new Student();

            string fName = "Kevin";
            string lName = "Ghantous";

            //Java way - set
            //s.setFirstName(name);

            //C# way - set
            s.FirstName = fName;
            s.LastName = lName;

            //c# way - Get
            string newName = s.FirstName;
            MessageBox.Show("newName = " + newName);

            string studentName = s.FullName;
            MessageBox.Show("studentName = " + studentName);
        }
    }
}
