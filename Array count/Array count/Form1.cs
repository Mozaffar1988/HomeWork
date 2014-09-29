using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array_count
{
    public partial class ArraylocationUiForm : Form
    {
        public ArraylocationUiForm()
        {
            InitializeComponent();
        }


        int count = 0, i = 0;
        int[] numbers = new int[500];

        private void addButton_Click(object sender, EventArgs e)
        {
            int add = Convert.ToInt32(inputtextBox.Text);
            numbers[i] = add;
            inputtextBox.Text = "";
            countlabel.Text = Convert.ToString(count);
            inputtextBox.Focus();
            count++;
            i++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int flag = 1;
            locationtextBox.Text = "";
            for (int i = 0; i < 500; i++)
            {
                if (numbers[i] == Convert.ToInt32("100"))
                {
                    locationtextBox.Text += Convert.ToString(i) + " ";
                    flag = 0;
                }
                
            }
            
            if (flag == 1)
            {
                locationtextBox.Text = "No number found!!";
            }
        }

       
    }
}
