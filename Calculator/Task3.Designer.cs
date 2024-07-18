namespace Calculator
{
    partial class Task3
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
            this.txtWord = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtTranslation = new System.Windows.Forms.TextBox();
            this.txtDefinition = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(191, 105);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(264, 20);
            this.txtWord.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(191, 143);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(264, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtTranslation
            // 
            this.txtTranslation.Location = new System.Drawing.Point(191, 183);
            this.txtTranslation.Name = "txtTranslation";
            this.txtTranslation.Size = new System.Drawing.Size(264, 20);
            this.txtTranslation.TabIndex = 2;
            // 
            // txtDefinition
            // 
            this.txtDefinition.Location = new System.Drawing.Point(191, 209);
            this.txtDefinition.Name = "txtDefinition";
            this.txtDefinition.Size = new System.Drawing.Size(264, 20);
            this.txtDefinition.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Translation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Definition";
            // 
            // Task3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDefinition);
            this.Controls.Add(this.txtTranslation);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtWord);
            this.Name = "Task3";
            this.Text = "Task3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtTranslation;
        private System.Windows.Forms.TextBox txtDefinition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}