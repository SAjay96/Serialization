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
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text.Json;

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
                int id = Convert.ToInt32(txtid.Text);
                string name = txtname.Text;
                string location = txtlocation.Text;
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
                txtid.Text = br.ReadInt32().ToString();
                txtname.Text = br.ReadString();
                txtlocation.Text = br.ReadString();
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

        private void btnwrite_Click_1(object sender, EventArgs e)
        {

            try
            {
                int id = Convert.ToInt32(txtid.Text);
                string name = txtname.Text;
                string location = txtlocation.Text;
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

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {

                // dept details accepting from the textboxes & storing in the object
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtid.Text);
                dept.Name = txtname.Text;
                dept.Location = txtlocation.Text;
                // default file extension is .dat file (data file) / binary file
                fs = new FileStream(@"D:\TestFolder\Dept", FileMode.Create, FileAccess.Write);
                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(fs, dept);
                MessageBox.Show("Done");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {

                // dept details accepting from the textboxes & storing in the object
                Department dept = new Department();
                // default file extension is .dat file (data file) / binary file
                fs = new FileStream(@"D:\TestFolder\Dept", FileMode.Open, FileAccess.Read);
                BinaryFormatter binary = new BinaryFormatter();
                dept = (Department)binary.Deserialize(fs);
                txtid.Text = dept.Id.ToString();
                txtname.Text = dept.Name;
                txtlocation.Text = dept.Location;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnXmlWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtid.Text);
                dept.Name = txtname.Text;
                dept.Location = txtlocation.Text;
                // default file extension is .dat file (data file) / binary file
                fs = new FileStream(@"D:\TestFolder\DeptXml", FileMode.Create, FileAccess.Write);
                XmlSerializer xml = new XmlSerializer(typeof(Department));
                xml.Serialize(fs, dept);
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void btnXmlRead_Click(object sender, EventArgs e)
        {
            try
            {

                // dept details accepting from the textboxes & storing in the object
                Department dept = new Department();
                // default file extension is .dat file (data file) / binary file
                fs = new FileStream(@"D:\TestFolder\DeptXml", FileMode.Open, FileAccess.Read);
                XmlSerializer xml = new XmlSerializer(typeof(Department));
                dept = (Department)xml.Deserialize(fs);
                txtid.Text = dept.Id.ToString();
                txtname.Text = dept.Name;
                txtlocation.Text = dept.Location;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void btnSoapWrite_Click(object sender, EventArgs e)
        { 
            try
            {

                // dept details accepting from the textboxes & storing in the object
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtid.Text);
                dept.Name = txtname.Text;
                dept.Location = txtlocation.Text;
                // default file extension is .dat file (data file) / binary file
                fs = new FileStream(@"D:\TestFolder\DeptSoap", FileMode.Create, FileAccess.Write);
                SoapFormatter soap = new SoapFormatter();
                soap.Serialize(fs, dept);
                MessageBox.Show("Done");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnSoapRead_Click(object sender, EventArgs e)
        {
            try
            {

                // dept details accepting from the textboxes & storing in the object
                Department dept = new Department();
                // default file extension is .dat file (data file) / binary file
                fs = new FileStream(@"D:\TestFolder\DeptSoap", FileMode.Open, FileAccess.Read);
                SoapFormatter soap = new SoapFormatter();
                dept = (Department)soap.Deserialize(fs);
                txtid.Text = dept.Id.ToString();
                txtname.Text = dept.Name;
                txtlocation.Text = dept.Location;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnJsonWrite_Click(object sender, EventArgs e)
        {
            try
            {

                // dept details accepting from the textboxes & storing in the object
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtid.Text);
                dept.Name = txtname.Text;
                dept.Location = txtlocation.Text;
                // default file extension is .dat file (data file) / binary file
                fs = new FileStream(@"D:\TestFolder\Deptjson", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, dept);
                MessageBox.Show("Done");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnJsonRead_Click(object sender, EventArgs e)
        {
            try
            {

                // dept details accepting from the textboxes & storing in the object
                Department dept = new Department();
                // default file extension is .dat file (data file) / binary file
                fs = new FileStream(@"D:\TestFolder\Deptjson", FileMode.Open, FileAccess.Read);
                
                dept = JsonSerializer.Deserialize<Department>(fs);
                txtid.Text = dept.Id.ToString();
                txtname.Text = dept.Name;
                txtlocation.Text = dept.Location;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }
    }
}

