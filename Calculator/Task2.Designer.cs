namespace Calculator
{
    partial class Task2
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
            this.btnCelsiusToFahrenheit = new System.Windows.Forms.Button();
            this.btnFahrenheitToCelsius = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCelsiusToFahrenheit
            // 
            this.btnCelsiusToFahrenheit.Location = new System.Drawing.Point(259, 124);
            this.btnCelsiusToFahrenheit.Name = "btnCelsiusToFahrenheit";
            this.btnCelsiusToFahrenheit.Size = new System.Drawing.Size(209, 23);
            this.btnCelsiusToFahrenheit.TabIndex = 0;
            this.btnCelsiusToFahrenheit.Text = "Celsium to Farnheit";
            this.btnCelsiusToFahrenheit.UseVisualStyleBackColor = true;
            this.btnCelsiusToFahrenheit.Click += new System.EventHandler(this.btnCelsiusToFahrenheit_Click);
            // 
            // btnFahrenheitToCelsius
            // 
            this.btnFahrenheitToCelsius.Location = new System.Drawing.Point(259, 168);
            this.btnFahrenheitToCelsius.Name = "btnFahrenheitToCelsius";
            this.btnFahrenheitToCelsius.Size = new System.Drawing.Size(209, 23);
            this.btnFahrenheitToCelsius.TabIndex = 1;
            this.btnFahrenheitToCelsius.Text = "Farenheit to Celsium";
            this.btnFahrenheitToCelsius.UseVisualStyleBackColor = true;
            this.btnFahrenheitToCelsius.Click += new System.EventHandler(this.btnFahrenheitToCelsius_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Temperature";
            // 
            // txtTemperature
            // 
            this.txtTemperature.Location = new System.Drawing.Point(342, 73);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(126, 20);
            this.txtTemperature.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Result";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(342, 229);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(126, 20);
            this.txtResult.TabIndex = 5;
            // 
            // Task2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 450);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTemperature);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFahrenheitToCelsius);
            this.Controls.Add(this.btnCelsiusToFahrenheit);
            this.Name = "Task2";
            this.Text = "Task2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCelsiusToFahrenheit;
        private System.Windows.Forms.Button btnFahrenheitToCelsius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResult;
    }
}