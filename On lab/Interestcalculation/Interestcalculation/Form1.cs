using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interestcalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string BRAC = "BRAC" ;
        private string DBBL = "DBBL";
        private string HSBC = "HSBC"; 
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculationButton_Click(object sender, EventArgs e)
        {
            string bankName = bnankcomboBox.Text;
            int year = Convert.ToInt32(timetextBox.Text);
            double balance = Convert.ToDouble(balancetextBox.Text);


            if (bankName == "BRAC" )
            {
                double result;
                result = (balance*7*year)/100;
                resultLabel.Text = result.ToString();
            }
            else if  (bankName == "DBBL")
            {
                double result;
                result = (balance * 7 * year) / 100;
                resultLabel.Text = result.ToString();
            }
            else
            {
                double result;
                result = (balance * 7 * year) / 100;
                resultLabel.Text = result.ToString();
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
