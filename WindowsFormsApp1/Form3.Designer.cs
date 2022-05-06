namespace WindowsFormsApp1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Id = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.Location = new System.Windows.Forms.Label();
            this.txtlocation = new System.Windows.Forms.TextBox();
            this.btnwrite = new System.Windows.Forms.Button();
            this.btnread = new System.Windows.Forms.Button();
            this.btnfolder = new System.Windows.Forms.Button();
            this.btnfile = new System.Windows.Forms.Button();
            this.btnBinaryWrite = new System.Windows.Forms.Button();
            this.btnBinaryRead = new System.Windows.Forms.Button();
            this.btnXmlWrite = new System.Windows.Forms.Button();
            this.btnXmlRead = new System.Windows.Forms.Button();
            this.btnSoapWrite = new System.Windows.Forms.Button();
            this.btnSoapRead = new System.Windows.Forms.Button();
            this.btnJsonWrite = new System.Windows.Forms.Button();
            this.btnJsonRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(112, 39);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(86, 16);
            this.Id.TabIndex = 0;
            this.Id.Text = "Enter Dept ID";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(253, 36);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(189, 22);
            this.txtid.TabIndex = 1;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(253, 102);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(189, 22);
            this.txtname.TabIndex = 2;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(112, 101);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(110, 16);
            this.Name.TabIndex = 3;
            this.Name.Text = "Enter Dept Name";
            // 
            // Location
            // 
            this.Location.AutoSize = true;
            this.Location.Location = new System.Drawing.Point(112, 157);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(92, 16);
            this.Location.TabIndex = 4;
            this.Location.Text = "Enter Location";
            // 
            // txtlocation
            // 
            this.txtlocation.Location = new System.Drawing.Point(253, 168);
            this.txtlocation.Name = "txtlocation";
            this.txtlocation.Size = new System.Drawing.Size(189, 22);
            this.txtlocation.TabIndex = 5;
            // 
            // btnwrite
            // 
            this.btnwrite.Location = new System.Drawing.Point(83, 215);
            this.btnwrite.Name = "btnwrite";
            this.btnwrite.Size = new System.Drawing.Size(106, 23);
            this.btnwrite.TabIndex = 6;
            this.btnwrite.Text = "Write to File";
            this.btnwrite.UseVisualStyleBackColor = true;
            this.btnwrite.Click += new System.EventHandler(this.btnwrite_Click_1);
            // 
            // btnread
            // 
            this.btnread.Location = new System.Drawing.Point(281, 215);
            this.btnread.Name = "btnread";
            this.btnread.Size = new System.Drawing.Size(161, 23);
            this.btnread.TabIndex = 7;
            this.btnread.Text = "Read from File";
            this.btnread.UseVisualStyleBackColor = true;
            this.btnread.Click += new System.EventHandler(this.btnread_Click);
            // 
            // btnfolder
            // 
            this.btnfolder.Location = new System.Drawing.Point(63, 277);
            this.btnfolder.Name = "btnfolder";
            this.btnfolder.Size = new System.Drawing.Size(134, 23);
            this.btnfolder.TabIndex = 8;
            this.btnfolder.Text = "create Folder";
            this.btnfolder.UseVisualStyleBackColor = true;
            this.btnfolder.Click += new System.EventHandler(this.btnfolder_Click);
            // 
            // btnfile
            // 
            this.btnfile.Location = new System.Drawing.Point(304, 277);
            this.btnfile.Name = "btnfile";
            this.btnfile.Size = new System.Drawing.Size(138, 23);
            this.btnfile.TabIndex = 9;
            this.btnfile.Text = "Create File";
            this.btnfile.UseVisualStyleBackColor = true;
            this.btnfile.Click += new System.EventHandler(this.btnfile_Click);
            // 
            // btnBinaryWrite
            // 
            this.btnBinaryWrite.Location = new System.Drawing.Point(82, 353);
            this.btnBinaryWrite.Name = "btnBinaryWrite";
            this.btnBinaryWrite.Size = new System.Drawing.Size(107, 23);
            this.btnBinaryWrite.TabIndex = 10;
            this.btnBinaryWrite.Text = "Binary write";
            this.btnBinaryWrite.UseVisualStyleBackColor = true;
            this.btnBinaryWrite.Click += new System.EventHandler(this.btnBinaryWrite_Click);
            // 
            // btnBinaryRead
            // 
            this.btnBinaryRead.Location = new System.Drawing.Point(304, 353);
            this.btnBinaryRead.Name = "btnBinaryRead";
            this.btnBinaryRead.Size = new System.Drawing.Size(138, 23);
            this.btnBinaryRead.TabIndex = 11;
            this.btnBinaryRead.Text = "Binary Read";
            this.btnBinaryRead.UseVisualStyleBackColor = true;
            this.btnBinaryRead.Click += new System.EventHandler(this.btnBinaryRead_Click);
            // 
            // btnXmlWrite
            // 
            this.btnXmlWrite.Location = new System.Drawing.Point(541, 215);
            this.btnXmlWrite.Name = "btnXmlWrite";
            this.btnXmlWrite.Size = new System.Drawing.Size(126, 23);
            this.btnXmlWrite.TabIndex = 12;
            this.btnXmlWrite.Text = "Xml Write";
            this.btnXmlWrite.UseVisualStyleBackColor = true;
            this.btnXmlWrite.Click += new System.EventHandler(this.btnXmlWrite_Click);
            // 
            // btnXmlRead
            // 
            this.btnXmlRead.Location = new System.Drawing.Point(722, 215);
            this.btnXmlRead.Name = "btnXmlRead";
            this.btnXmlRead.Size = new System.Drawing.Size(138, 23);
            this.btnXmlRead.TabIndex = 13;
            this.btnXmlRead.Text = "Xml Read";
            this.btnXmlRead.UseVisualStyleBackColor = true;
            this.btnXmlRead.Click += new System.EventHandler(this.btnXmlRead_Click);
            // 
            // btnSoapWrite
            // 
            this.btnSoapWrite.Location = new System.Drawing.Point(541, 277);
            this.btnSoapWrite.Name = "btnSoapWrite";
            this.btnSoapWrite.Size = new System.Drawing.Size(126, 23);
            this.btnSoapWrite.TabIndex = 14;
            this.btnSoapWrite.Text = "Soap Write";
            this.btnSoapWrite.UseVisualStyleBackColor = true;
            this.btnSoapWrite.Click += new System.EventHandler(this.btnSoapWrite_Click);
            // 
            // btnSoapRead
            // 
            this.btnSoapRead.Location = new System.Drawing.Point(742, 277);
            this.btnSoapRead.Name = "btnSoapRead";
            this.btnSoapRead.Size = new System.Drawing.Size(108, 23);
            this.btnSoapRead.TabIndex = 15;
            this.btnSoapRead.Text = "Soap Read";
            this.btnSoapRead.UseVisualStyleBackColor = true;
            this.btnSoapRead.Click += new System.EventHandler(this.btnSoapRead_Click);
            // 
            // btnJsonWrite
            // 
            this.btnJsonWrite.Location = new System.Drawing.Point(541, 353);
            this.btnJsonWrite.Name = "btnJsonWrite";
            this.btnJsonWrite.Size = new System.Drawing.Size(133, 23);
            this.btnJsonWrite.TabIndex = 16;
            this.btnJsonWrite.Text = "Json Write";
            this.btnJsonWrite.UseVisualStyleBackColor = true;
            this.btnJsonWrite.Click += new System.EventHandler(this.btnJsonWrite_Click);
            // 
            // btnJsonRead
            // 
            this.btnJsonRead.Location = new System.Drawing.Point(742, 353);
            this.btnJsonRead.Name = "btnJsonRead";
            this.btnJsonRead.Size = new System.Drawing.Size(95, 23);
            this.btnJsonRead.TabIndex = 17;
            this.btnJsonRead.Text = "Json Read";
            this.btnJsonRead.UseVisualStyleBackColor = true;
            this.btnJsonRead.Click += new System.EventHandler(this.btnJsonRead_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 547);
            this.Controls.Add(this.btnJsonRead);
            this.Controls.Add(this.btnJsonWrite);
            this.Controls.Add(this.btnSoapRead);
            this.Controls.Add(this.btnSoapWrite);
            this.Controls.Add(this.btnXmlRead);
            this.Controls.Add(this.btnXmlWrite);
            this.Controls.Add(this.btnBinaryRead);
            this.Controls.Add(this.btnBinaryWrite);
            this.Controls.Add(this.btnfile);
            this.Controls.Add(this.btnfolder);
            this.Controls.Add(this.btnread);
            this.Controls.Add(this.btnwrite);
            this.Controls.Add(this.txtlocation);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.Id);
            this.Text = "File IO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Location;
        private System.Windows.Forms.TextBox txtlocation;
        private System.Windows.Forms.Button btnwrite;
        private System.Windows.Forms.Button btnread;
        private System.Windows.Forms.Button btnfolder;
        private System.Windows.Forms.Button btnfile;
        private System.Windows.Forms.Button btnBinaryWrite;
        private System.Windows.Forms.Button btnBinaryRead;
        private System.Windows.Forms.Button btnXmlWrite;
        private System.Windows.Forms.Button btnXmlRead;
        private System.Windows.Forms.Button btnSoapWrite;
        private System.Windows.Forms.Button btnSoapRead;
        private System.Windows.Forms.Button btnJsonWrite;
        private System.Windows.Forms.Button btnJsonRead;
    }
}