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
            this.Number1 = new System.Windows.Forms.Label();
            this.Number2 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.textNumber1 = new System.Windows.Forms.TextBox();
            this.textNumber2 = new System.Windows.Forms.TextBox();
            this.textResult = new System.Windows.Forms.TextBox();
            this.Mul = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.Sub = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Number1
            // 
            this.Number1.AutoSize = true;
            this.Number1.Location = new System.Drawing.Point(161, 62);
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(70, 17);
            this.Number1.TabIndex = 0;
            this.Number1.Text = "Number 1";
            // 
            // Number2
            // 
            this.Number2.AutoSize = true;
            this.Number2.Location = new System.Drawing.Point(161, 108);
            this.Number2.Name = "Number2";
            this.Number2.Size = new System.Drawing.Size(70, 17);
            this.Number2.TabIndex = 1;
            this.Number2.Text = "Number 2";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(161, 187);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(48, 17);
            this.Result.TabIndex = 2;
            this.Result.Text = "Result";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(138, 242);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(106, 33);
            this.Add.TabIndex = 3;
            this.Add.Text = "Addition";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // textNumber1
            // 
            this.textNumber1.Location = new System.Drawing.Point(254, 56);
            this.textNumber1.Name = "textNumber1";
            this.textNumber1.Size = new System.Drawing.Size(100, 22);
            this.textNumber1.TabIndex = 4;
            // 
            // textNumber2
            // 
            this.textNumber2.Location = new System.Drawing.Point(254, 103);
            this.textNumber2.Name = "textNumber2";
            this.textNumber2.Size = new System.Drawing.Size(100, 22);
            this.textNumber2.TabIndex = 4;
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(254, 184);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(100, 22);
            this.textResult.TabIndex = 4;
            // 
            // Mul
            // 
            this.Mul.Location = new System.Drawing.Point(138, 297);
            this.Mul.Name = "Mul";
            this.Mul.Size = new System.Drawing.Size(106, 33);
            this.Mul.TabIndex = 5;
            this.Mul.Text = "Multiplication";
            this.Mul.UseVisualStyleBackColor = true;
            this.Mul.Click += new System.EventHandler(this.Mul_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(480, 179);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(106, 33);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Div
            // 
            this.Div.Location = new System.Drawing.Point(313, 242);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(106, 33);
            this.Div.TabIndex = 7;
            this.Div.Text = "Division";
            this.Div.UseVisualStyleBackColor = true;
            this.Div.Click += new System.EventHandler(this.Div_Click);
            // 
            // Sub
            // 
            this.Sub.Location = new System.Drawing.Point(313, 297);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(106, 33);
            this.Sub.TabIndex = 8;
            this.Sub.Text = "Substraction";
            this.Sub.UseVisualStyleBackColor = true;
            this.Sub.Click += new System.EventHandler(this.Sub_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Sub);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Mul);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.textNumber2);
            this.Controls.Add(this.textNumber1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Number2);
            this.Controls.Add(this.Number1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Number1;
        private System.Windows.Forms.Label Number2;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox textNumber1;
        private System.Windows.Forms.TextBox textNumber2;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.Button Mul;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.Button Sub;
    }
}