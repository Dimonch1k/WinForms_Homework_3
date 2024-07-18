namespace Calculator
{
    partial class Task4
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
            this.chkLowercase = new System.Windows.Forms.CheckBox();
            this.chkUppercase = new System.Windows.Forms.CheckBox();
            this.chkDigits = new System.Windows.Forms.CheckBox();
            this.chkSpecialChars = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGeneratedPassword = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.numPasswordLength = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numPasswordLength)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password Generator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password length:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = " Character Sets:";
            // 
            // chkLowercase
            // 
            this.chkLowercase.AutoSize = true;
            this.chkLowercase.Location = new System.Drawing.Point(134, 182);
            this.chkLowercase.Name = "chkLowercase";
            this.chkLowercase.Size = new System.Drawing.Size(109, 17);
            this.chkLowercase.TabIndex = 7;
            this.chkLowercase.Text = "Lowercase letters";
            this.chkLowercase.UseVisualStyleBackColor = true;
            // 
            // chkUppercase
            // 
            this.chkUppercase.AutoSize = true;
            this.chkUppercase.Location = new System.Drawing.Point(134, 205);
            this.chkUppercase.Name = "chkUppercase";
            this.chkUppercase.Size = new System.Drawing.Size(109, 17);
            this.chkUppercase.TabIndex = 8;
            this.chkUppercase.Text = "Uppercase letters";
            this.chkUppercase.UseVisualStyleBackColor = true;
            // 
            // chkDigits
            // 
            this.chkDigits.AutoSize = true;
            this.chkDigits.Location = new System.Drawing.Point(134, 230);
            this.chkDigits.Name = "chkDigits";
            this.chkDigits.Size = new System.Drawing.Size(52, 17);
            this.chkDigits.TabIndex = 9;
            this.chkDigits.Text = "Digits";
            this.chkDigits.UseVisualStyleBackColor = true;
            // 
            // chkSpecialChars
            // 
            this.chkSpecialChars.AutoSize = true;
            this.chkSpecialChars.Location = new System.Drawing.Point(134, 254);
            this.chkSpecialChars.Name = "chkSpecialChars";
            this.chkSpecialChars.Size = new System.Drawing.Size(168, 17);
            this.chkSpecialChars.TabIndex = 10;
            this.chkSpecialChars.Text = "Special characters (!@#$%^&*)";
            this.chkSpecialChars.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(272, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Generate Password";
            // 
            // txtGeneratedPassword
            // 
            this.txtGeneratedPassword.Location = new System.Drawing.Point(180, 384);
            this.txtGeneratedPassword.Name = "txtGeneratedPassword";
            this.txtGeneratedPassword.Size = new System.Drawing.Size(333, 20);
            this.txtGeneratedPassword.TabIndex = 13;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(127, 288);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(175, 23);
            this.btnGenerate.TabIndex = 14;
            this.btnGenerate.Text = "Generate Password";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // numPasswordLength
            // 
            this.numPasswordLength.Location = new System.Drawing.Point(259, 110);
            this.numPasswordLength.Name = "numPasswordLength";
            this.numPasswordLength.Size = new System.Drawing.Size(88, 20);
            this.numPasswordLength.TabIndex = 15;
            // 
            // Task4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 543);
            this.Controls.Add(this.numPasswordLength);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtGeneratedPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkSpecialChars);
            this.Controls.Add(this.chkDigits);
            this.Controls.Add(this.chkUppercase);
            this.Controls.Add(this.chkLowercase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Task4";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numPasswordLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkLowercase;
        private System.Windows.Forms.CheckBox chkUppercase;
        private System.Windows.Forms.CheckBox chkDigits;
        private System.Windows.Forms.CheckBox chkSpecialChars;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGeneratedPassword;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.NumericUpDown numPasswordLength;
    }
}