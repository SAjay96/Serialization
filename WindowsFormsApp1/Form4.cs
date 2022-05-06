using System;
using System.IO;
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
    public partial class Form4 : Form
    {
        FileStream fs;
        public Form4()
        {
            InitializeComponent();
        }

        private void btnwrite_Click(object sender, EventArgs e)
        {
            try
            {
                int roll = Convert.ToInt32(txtrollno.Text);
                string Name = namee.Text;
                double Percentage = Convert.ToInt32(per.Text);
                string stream = str.Text;
                string city = cit.Text;

                fs = new FileStream(@"D:\TestFolder\File.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(roll);
                bw.Write(Name);
                bw.Write(Percentage);
                bw.Write(stream);
                bw.Write(city);
                bw.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                fs.Close(); // free the resouce 
            }

        }

        private void btnread_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\TestFolder\File.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtrollno.Text = br.ReadInt32().ToString();
                namee.Text = br.ReadString();
                per.Text = br.ReadInt32().ToString();
                str.Text = br.ReadString();
                cit.Text = br.ReadString();
                br.Close();  // close the opeation reader
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close(); // free the resouce 
            }
        }
    }
    }



