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
    public partial class Form3 : Form
    {
        FileStream fs;
        public Form3()
        {
            InitializeComponent();
        }

        

        private void btnfolder_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\TestFolder";
                if (Directory.Exists(path))
                {
                    MessageBox.Show("Folder alredy exist");
                }
                else
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("Folder created");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void btnfile_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\TestFolder\File.txt";
                if (File.Exists(path))
                {
                    MessageBox.Show("File alredy exist");
                }
                else
                {
                    File.CreateText(path);
                    MessageBox.Show("File created");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {

            try
            {
                int id = Convert.ToInt32(Id.Text);
                string name = Name.Text;
                string location = Location.Text;
                fs = new FileStream(@"D:\TestFolder\File.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(id);
                bw.Write(name);
                bw.Write(location);
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
                Id.Text = br.ReadInt32().ToString();
                Name.Text = br.ReadString();
                Location.Text = br.ReadString();
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

        private void btnwrite_Click(object sender, EventArgs e)
        {

        }
    }
}
