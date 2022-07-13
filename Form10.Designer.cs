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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBox1id = new System.Windows.Forms.TextBox();
            this.textBox2name = new System.Windows.Forms.TextBox();
            this.textBox3salary = new System.Windows.Forms.TextBox();
            this.EmpGridView = new System.Windows.Forms.DataGridView();
            this.btnShowAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmpGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emp id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Emp Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Emp Salary";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(56, 280);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 19);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(142, 280);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(56, 19);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(233, 280);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 19);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(220, 57);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(154, 19);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Serach by Id";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textBox1id
            // 
            this.textBox1id.Location = new System.Drawing.Point(84, 59);
            this.textBox1id.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1id.Name = "textBox1id";
            this.textBox1id.Size = new System.Drawing.Size(123, 20);
            this.textBox1id.TabIndex = 7;
            this.textBox1id.TextChanged += new System.EventHandler(this.textBox1id_TextChanged);
            // 
            // textBox2name
            // 
            this.textBox2name.Location = new System.Drawing.Point(84, 103);
            this.textBox2name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2name.Name = "textBox2name";
            this.textBox2name.Size = new System.Drawing.Size(123, 20);
            this.textBox2name.TabIndex = 8;
            // 
            // textBox3salary
            // 
            this.textBox3salary.Location = new System.Drawing.Point(84, 150);
            this.textBox3salary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3salary.Name = "textBox3salary";
            this.textBox3salary.Size = new System.Drawing.Size(123, 20);
            this.textBox3salary.TabIndex = 9;
            // 
            // EmpGridView
            // 
            this.EmpGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpGridView.Location = new System.Drawing.Point(337, 88);
            this.EmpGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmpGridView.Name = "EmpGridView";
            this.EmpGridView.RowHeadersWidth = 51;
            this.EmpGridView.RowTemplate.Height = 24;
            this.EmpGridView.Size = new System.Drawing.Size(213, 187);
            this.EmpGridView.TabIndex = 10;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(337, 280);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(213, 19);
            this.btnShowAll.TabIndex = 11;
            this.btnShowAll.Text = "Show All Employees";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.EmpGridView);
            this.Controls.Add(this.textBox3salary);
            this.Controls.Add(this.textBox2name);
            this.Controls.Add(this.textBox1id);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmpGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBox1id;
        private System.Windows.Forms.TextBox textBox2name;
        private System.Windows.Forms.TextBox textBox3salary;
        private System.Windows.Forms.DataGridView EmpGridView;
        private System.Windows.Forms.Button btnShowAll;
    }
}