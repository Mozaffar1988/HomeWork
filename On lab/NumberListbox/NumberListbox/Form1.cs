using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberListbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            int count;
            int number = Convert.ToInt32(itemnumbertextBox.Text);
            numberlistBox.Items.Clear();
            for (count = 1; count <= number; count ++)
            {
                numberlistBox.Items.Add(count);

            }
            
        }
    }
}
