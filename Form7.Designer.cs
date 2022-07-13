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
            this.textBox1uid = new System.Windows.Forms.TextBox();
            this.textBox2pass = new System.Windows.Forms.TextBox();
            this.button1lgn = new System.Windows.Forms.Button();
            this.button2rst = new System.Windows.Forms.Button();
            this.Uid = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.Label();
            this.Gen = new System.Windows.Forms.Label();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBox1uid
            // 
            this.textBox1uid.Location = new System.Drawing.Point(380, 54);
            this.textBox1uid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1uid.Name = "textBox1uid";
            this.textBox1uid.Size = new System.Drawing.Size(76, 20);
            this.textBox1uid.TabIndex = 0;
            this.textBox1uid.TextChanged += new System.EventHandler(this.textBox1uid_TextChanged);
            // 
            // textBox2pass
            // 
            this.textBox2pass.Location = new System.Drawing.Point(380, 93);
            this.textBox2pass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2pass.Name = "textBox2pass";
            this.textBox2pass.PasswordChar = '*';
            this.textBox2pass.Size = new System.Drawing.Size(76, 20);
            this.textBox2pass.TabIndex = 1;
            this.textBox2pass.TextChanged += new System.EventHandler(this.textBox2pass_TextChanged);
            // 
            // button1lgn
            // 
            this.button1lgn.Location = new System.Drawing.Point(304, 158);
            this.button1lgn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1lgn.Name = "button1lgn";
            this.button1lgn.Size = new System.Drawing.Size(56, 19);
            this.button1lgn.TabIndex = 2;
            this.button1lgn.Text = "Login";
            this.button1lgn.UseVisualStyleBackColor = true;
            this.button1lgn.Click += new System.EventHandler(this.button1lgn_Click);
            // 
            // button2rst
            // 
            this.button2rst.Location = new System.Drawing.Point(398, 158);
            this.button2rst.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2rst.Name = "button2rst";
            this.button2rst.Size = new System.Drawing.Size(56, 19);
            this.button2rst.TabIndex = 3;
            this.button2rst.Text = "Reset";
            this.button2rst.UseVisualStyleBackColor = true;
            this.button2rst.Click += new System.EventHandler(this.button2rst_Click);
            // 
            // Uid
            // 
            this.Uid.AutoSize = true;
            this.Uid.Location = new System.Drawing.Point(304, 54);
            this.Uid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Uid.Name = "Uid";
            this.Uid.Size = new System.Drawing.Size(40, 13);
            this.Uid.TabIndex = 4;
            this.Uid.Text = "User id";
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.Location = new System.Drawing.Point(304, 93);
            this.Pass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(53, 13);
            this.Pass.TabIndex = 5;
            this.Pass.Text = "Password";
            // 
            // Gen
            // 
            this.Gen.AutoSize = true;
            this.Gen.Location = new System.Drawing.Point(306, 129);
            this.Gen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Gen.Name = "Gen";
            this.Gen.Size = new System.Drawing.Size(42, 13);
            this.Gen.TabIndex = 6;
            this.Gen.Text = "Gender";
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(380, 128);
            this.male.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(48, 17);
            this.male.TabIndex = 7;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(466, 129);
            this.female.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(59, 17);
            this.female.TabIndex = 8;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.female);
            this.Controls.Add(this.male);
            this.Controls.Add(this.Gen);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.Uid);
            this.Controls.Add(this.button2rst);
            this.Controls.Add(this.button1lgn);
            this.Controls.Add(this.textBox2pass);
            this.Controls.Add(this.textBox1uid);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1uid;
        private System.Windows.Forms.TextBox textBox2pass;
        private System.Windows.Forms.Button button1lgn;
        private System.Windows.Forms.Button button2rst;
        private System.Windows.Forms.Label Uid;
        private System.Windows.Forms.Label Pass;
        private System.Windows.Forms.Label Gen;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton female;
    }
}