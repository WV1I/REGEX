using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REGular_EXpressions
{
    public partial class Form1 : Form
    {
        string test { get { return textBox1.Text; } set { textBox1.Text = value; } }
        string nnumber { get { return textBox2.Text; } set { textBox2.Text = value; } }

        string postcode { get { return textBox3.Text; } set { textBox3.Text = value; } }

        
        private void button1_Click(object sender, EventArgs e)
        {

            Regex testExpression = new Regex("[aoeiuy]" + "{" + nnumber + "}");
            label1.Text = testExpression.IsMatch(test).ToString();

        }

       
        public Form1()
        {
            
            InitializeComponent();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Regex postcodeRegex = new Regex("^([0-9]{2}-[0-9]{3})$");
            label3.Text = "Czy to kod pocztowy?: " + postcodeRegex.IsMatch(postcode).ToString();
            
        }
    }
}
