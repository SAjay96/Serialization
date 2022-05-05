using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnshow_Click(object sender, EventArgs e)
        {


            MessageBox.Show($"{name},{email},{contact},{add}");


        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            name.Clear();
            email.Clear();
            contact.Clear();
            add.Clear();
        }

    }
}

