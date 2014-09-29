using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appcation
{
    public partial class Form1 : Form
    {
        private string firstName = "";
        private string lastName = "";
        private string fatherName = "";
        private string motherName = "";
        private string addressName = "";
       
        public Form1()
        {
            InitializeComponent();
        }

        

        private void save_Click(object sender, EventArgs e)
        {
            firstName = firstNameTextBox.Text;
            lastName = lastNameTextBox.Text;
            fatherName = fatherNameTextBox.Text;
            motherName = motherNameTextBox.Text;
            addressName = addressTextBox.Text;
            

            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            fatherNameTextBox.Text = "";
            motherNameTextBox.Text = "";
            addressTextBox.Text = "";
            


            MessageBox.Show("Save All Data");
        }

        private void showAll_Click(object sender, EventArgs e)
        {
            firstName = firstNameTextBox.Text;
            lastName = lastNameTextBox.Text;
            fatherName = fatherNameTextBox.Text;
            motherName = motherNameTextBox.Text;
            addressName = addressTextBox.Text;
            MessageBox.Show("First Name :" + firstName +"\n Last Name " + lastName + "\n Father Name" + fatherName + 
                "\n Mother Name :" + motherName + "\n Address :" + addressName)
            ;



        }

        private void parentName(object sender, EventArgs e)
        {
            fatherName = fatherNameTextBox.Text;
            motherName = motherNameTextBox.Text;
            MessageBox.Show("Father Name :" + fatherName + "\n Mother Name :" + motherName);
        }

        private void name_Click(object sender, EventArgs e)
        {
            firstName = firstNameTextBox.Text;
            lastName = lastNameTextBox.Text;
            MessageBox.Show("Full Name :" + firstName + lastName);
        }

        private void address_Click(object sender, EventArgs e)
        {
            addressName = addressTextBox.Text;
            MessageBox.Show(" Address " + addressName);
        }
    }
}
