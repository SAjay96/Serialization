namespace WindowsFormsApp1
{
    partial class Form1
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
            this.btnshow = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.lblfullname = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.lblcontact = new System.Windows.Forms.Label();
            this.lbladd = new System.Windows.Forms.Label();
            this.contact = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(325, 334);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(75, 23);
            this.btnshow.TabIndex = 0;
            this.btnshow.Text = "Show";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(524, 334);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 1;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // lblfullname
            // 
            this.lblfullname.AutoSize = true;
            this.lblfullname.Location = new System.Drawing.Point(295, 83);
            this.lblfullname.Name = "lblfullname";
            this.lblfullname.Size = new System.Drawing.Size(65, 16);
            this.lblfullname.TabIndex = 2;
            this.lblfullname.Text = "FullName";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(299, 145);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(54, 16);
            this.lblemail.TabIndex = 3;
            this.lblemail.Text = "EmailID";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(396, 77);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(237, 22);
            this.name.TabIndex = 4;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(396, 139);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(237, 22);
            this.email.TabIndex = 5;
            // 
            // lblcontact
            // 
            this.lblcontact.AutoSize = true;
            this.lblcontact.Location = new System.Drawing.Point(295, 192);
            this.lblcontact.Name = "lblcontact";
            this.lblcontact.Size = new System.Drawing.Size(52, 16);
            this.lblcontact.TabIndex = 6;
            this.lblcontact.Text = "Contact";
            // 
            // lbladd
            // 
            this.lbladd.AutoSize = true;
            this.lbladd.Location = new System.Drawing.Point(298, 248);
            this.lbladd.Name = "lbladd";
            this.lbladd.Size = new System.Drawing.Size(58, 16);
            this.lbladd.TabIndex = 7;
            this.lbladd.Text = "Address";
            // 
            // contact
            // 
            this.contact.Location = new System.Drawing.Point(396, 189);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(237, 22);
            this.contact.TabIndex = 8;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(396, 248);
            this.add.Multiline = true;
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(237, 54);
            this.add.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 491);
            this.Controls.Add(this.add);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.lbladd);
            this.Controls.Add(this.lblcontact);
            this.Controls.Add(this.email);
            this.Controls.Add(this.name);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblfullname);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnshow);
            this.Name = "Form1";
            this.Text = "Login Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label lblfullname;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label lblcontact;
        private System.Windows.Forms.Label lbladd;
        private System.Windows.Forms.TextBox contact;
        private System.Windows.Forms.TextBox add;
    }
}

