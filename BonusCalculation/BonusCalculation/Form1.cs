using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonusCalculation
{
    public partial class bonuscalcilatorUI : Form
    {
        public bonuscalcilatorUI()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double inputsalary =Convert.ToDouble(bsalaryamouttextBox.Text);
            double bonus;
            if (inputsalary > 10000 && inputsalary < 18000)
            {
                bonus = (inputsalary * 5) / 100;
                MessageBox.Show(" Hey Your Bonus Is " + bonus +  " Taka ");
                bsalaryamouttextBox.Text = "";
            }
            else if (inputsalary >= 18000)
            {
                bonus = (inputsalary * 6) / 100;
                MessageBox.Show(" Hey Your Bonus Is " + bonus +  " Taka ");
                bsalaryamouttextBox.Text = "";
            }
            else
            {
                bonus = (inputsalary * 7) / 100;
                MessageBox.Show(" Hey Your Bonus Is " + bonus +  " Taka " );
                bsalaryamouttextBox.Text = "";
            }
        }
    }
}
