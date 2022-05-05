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
            this.label1 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Location = new System.Windows.Forms.TextBox();
            this.btnwrite = new System.Windows.Forms.Button();
            this.btnread = new System.Windows.Forms.Button();
            this.btnfolder = new System.Windows.Forms.Button();
            this.btnfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Dept ID";
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(318, 102);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(171, 22);
            this.Id.TabIndex = 1;
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(318, 183);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(171, 22);
            this.Name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Dept Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter Location";
            // 
            // Location
            // 
            this.Location.Location = new System.Drawing.Point(318, 263);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(171, 22);
            this.Location.TabIndex = 5;
            // 
            // btnwrite
            // 
            this.btnwrite.Location = new System.Drawing.Point(197, 321);
            this.btnwrite.Name = "btnwrite";
            this.btnwrite.Size = new System.Drawing.Size(106, 23);
            this.btnwrite.TabIndex = 6;
            this.btnwrite.Text = "Write to File";
            this.btnwrite.UseVisualStyleBackColor = true;
            this.btnwrite.Click += new System.EventHandler(this.btnwrite_Click);
            // 
            // btnread
            // 
            this.btnread.Location = new System.Drawing.Point(390, 321);
            this.btnread.Name = "btnread";
            this.btnread.Size = new System.Drawing.Size(143, 23);
            this.btnread.TabIndex = 7;
            this.btnread.Text = "Read from File";
            this.btnread.UseVisualStyleBackColor = true;
            this.btnread.Click += new System.EventHandler(this.btnread_Click);
            // 
            // btnfolder
            // 
            this.btnfolder.Location = new System.Drawing.Point(184, 391);
            this.btnfolder.Name = "btnfolder";
            this.btnfolder.Size = new System.Drawing.Size(134, 23);
            this.btnfolder.TabIndex = 8;
            this.btnfolder.Text = "create Folder";
            this.btnfolder.UseVisualStyleBackColor = true;
            this.btnfolder.Click += new System.EventHandler(this.btnfolder_Click);
            // 
            // btnfile
            // 
            this.btnfile.Location = new System.Drawing.Point(400, 391);
            this.btnfile.Name = "btnfile";
            this.btnfile.Size = new System.Drawing.Size(120, 23);
            this.btnfile.TabIndex = 9;
            this.btnfile.Text = "Create File";
            this.btnfile.UseVisualStyleBackColor = true;
            this.btnfile.Click += new System.EventHandler(this.btnfile_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.btnfile);
            this.Controls.Add(this.btnfolder);
            this.Controls.Add(this.btnread);
            this.Controls.Add(this.btnwrite);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.label1);
          
            this.Text = "File IO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Location;
        private System.Windows.Forms.Button btnwrite;
        private System.Windows.Forms.Button btnread;
        private System.Windows.Forms.Button btnfolder;
        private System.Windows.Forms.Button btnfile;
    }
}