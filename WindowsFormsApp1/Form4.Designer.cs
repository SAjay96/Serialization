namespace WindowsFormsApp1
{
    partial class Form4
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
            this.btnwrite = new System.Windows.Forms.Button();
            this.btnread = new System.Windows.Forms.Button();
            this.txtrollno = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.percentage = new System.Windows.Forms.TextBox();
            this.stream = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.roll = new System.Windows.Forms.Label();
            this.namee = new System.Windows.Forms.Label();
            this.str = new System.Windows.Forms.Label();
            this.per = new System.Windows.Forms.Label();
            this.cit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnwrite
            // 
            this.btnwrite.Location = new System.Drawing.Point(306, 353);
            this.btnwrite.Name = "btnwrite";
            this.btnwrite.Size = new System.Drawing.Size(75, 23);
            this.btnwrite.TabIndex = 0;
            this.btnwrite.Text = "Write";
            this.btnwrite.UseVisualStyleBackColor = true;
            this.btnwrite.Click += new System.EventHandler(this.btnwrite_Click);
            // 
            // btnread
            // 
            this.btnread.Location = new System.Drawing.Point(477, 353);
            this.btnread.Name = "btnread";
            this.btnread.Size = new System.Drawing.Size(75, 23);
            this.btnread.TabIndex = 1;
            this.btnread.Text = "Read";
            this.btnread.UseVisualStyleBackColor = true;
            this.btnread.Click += new System.EventHandler(this.btnread_Click);
            // 
            // txtrollno
            // 
            this.txtrollno.Location = new System.Drawing.Point(406, 72);
            this.txtrollno.Name = "txtrollno";
            this.txtrollno.Size = new System.Drawing.Size(100, 22);
            this.txtrollno.TabIndex = 2;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(406, 128);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 22);
            this.name.TabIndex = 3;
            // 
            // percentage
            // 
            this.percentage.Location = new System.Drawing.Point(406, 170);
            this.percentage.Name = "percentage";
            this.percentage.Size = new System.Drawing.Size(100, 22);
            this.percentage.TabIndex = 4;
            // 
            // stream
            // 
            this.stream.Location = new System.Drawing.Point(406, 219);
            this.stream.Name = "stream";
            this.stream.Size = new System.Drawing.Size(100, 22);
            this.stream.TabIndex = 5;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(406, 262);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(100, 22);
            this.city.TabIndex = 6;
            // 
            // roll
            // 
            this.roll.AutoSize = true;
            this.roll.Location = new System.Drawing.Point(304, 75);
            this.roll.Name = "roll";
            this.roll.Size = new System.Drawing.Size(55, 16);
            this.roll.TabIndex = 7;
            this.roll.Text = "Roll No.";
            // 
            // namee
            // 
            this.namee.AutoSize = true;
            this.namee.Location = new System.Drawing.Point(304, 134);
            this.namee.Name = "namee";
            this.namee.Size = new System.Drawing.Size(44, 16);
            this.namee.TabIndex = 8;
            this.namee.Text = "Name";
            // 
            // str
            // 
            this.str.AutoSize = true;
            this.str.Location = new System.Drawing.Point(304, 225);
            this.str.Name = "str";
            this.str.Size = new System.Drawing.Size(50, 16);
            this.str.TabIndex = 9;
            this.str.Text = "Stream";
            // 
            // per
            // 
            this.per.AutoSize = true;
            this.per.Location = new System.Drawing.Point(304, 189);
            this.per.Name = "per";
            this.per.Size = new System.Drawing.Size(77, 16);
            this.per.TabIndex = 10;
            this.per.Text = "Percentage";
            // 
            // cit
            // 
            this.cit.AutoSize = true;
            this.cit.Location = new System.Drawing.Point(304, 268);
            this.cit.Name = "cit";
            this.cit.Size = new System.Drawing.Size(29, 16);
            this.cit.TabIndex = 11;
            this.cit.Text = "City";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cit);
            this.Controls.Add(this.per);
            this.Controls.Add(this.str);
            this.Controls.Add(this.namee);
            this.Controls.Add(this.roll);
            this.Controls.Add(this.city);
            this.Controls.Add(this.stream);
            this.Controls.Add(this.percentage);
            this.Controls.Add(this.name);
            this.Controls.Add(this.txtrollno);
            this.Controls.Add(this.btnread);
            this.Controls.Add(this.btnwrite);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnwrite;
        private System.Windows.Forms.Button btnread;
        private System.Windows.Forms.TextBox txtrollno;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox percentage;
        private System.Windows.Forms.TextBox stream;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label roll;
        private System.Windows.Forms.Label namee;
        private System.Windows.Forms.Label str;
        private System.Windows.Forms.Label per;
        private System.Windows.Forms.Label cit;
    }
}