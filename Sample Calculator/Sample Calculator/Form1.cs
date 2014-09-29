using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample_Calculator
{
    public partial class simplecalculatorFormUI : Form
    {
        public simplecalculatorFormUI()
        {
            InitializeComponent();
        }
        

        private void addButton_Click(object sender, EventArgs e)
        {
            
            double userInput1 = Convert.ToDouble(firstnumbertextBox.Text);
            double userInput2 = Convert.ToDouble(secondnumbertextBox.Text);
            string result =Convert.ToString( userInput1 + userInput2);
            resulttextBox.Text = result;
            firstnumbertextBox.Text = "";
            secondnumbertextBox.Text = "";

        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            double userInput1 = Convert.ToDouble(firstnumbertextBox.Text);
            double userInput2 = Convert.ToDouble(secondnumbertextBox.Text);
            string result = Convert.ToString(userInput1 - userInput2);
            resulttextBox.Text = result;
            firstnumbertextBox.Text = "";
            secondnumbertextBox.Text = "";
        }

        private void multiplayButton_Click(object sender, EventArgs e)
        {
            double userInput1 = Convert.ToDouble(firstnumbertextBox.Text);
            double userInput2 = Convert.ToDouble(secondnumbertextBox.Text);
            string result = Convert.ToString(userInput1 * userInput2);
            resulttextBox.Text = result;
            firstnumbertextBox.Text = "";
            secondnumbertextBox.Text = "";
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            double userInput1 = Convert.ToDouble(firstnumbertextBox.Text);
            double userInput2 = Convert.ToDouble(secondnumbertextBox.Text);
            string result = Convert.ToString(userInput1 / userInput2);
            resulttextBox.Text = result;
            firstnumbertextBox.Text = "";
            secondnumbertextBox.Text = "";
        }

      
    }
}
