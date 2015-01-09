namespace HashTableExample
{
    partial class BookInfoUI
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
            this.isbnLabel = new System.Windows.Forms.Label();
            this.isbnTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.authorLabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.retrieveIsbnLabel = new System.Windows.Forms.Label();
            this.retrieveTitleLabel = new System.Windows.Forms.Label();
            this.retrieveAuthorLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.retrieveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // isbnLabel
            // 
            this.isbnLabel.AutoSize = true;
            this.isbnLabel.Location = new System.Drawing.Point(48, 30);
            this.isbnLabel.Name = "isbnLabel";
            this.isbnLabel.Size = new System.Drawing.Size(32, 13);
            this.isbnLabel.TabIndex = 0;
            this.isbnLabel.Text = "ISBN";
            // 
            // isbnTextBox
            // 
            this.isbnTextBox.Location = new System.Drawing.Point(128, 27);
            this.isbnTextBox.Name = "isbnTextBox";
            this.isbnTextBox.Size = new System.Drawing.Size(124, 20);
            this.isbnTextBox.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(48, 63);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(27, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(128, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(124, 20);
            this.textBox2.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(177, 125);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(48, 92);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(38, 13);
            this.authorLabel.TabIndex = 0;
            this.authorLabel.Text = "Author";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(128, 89);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(124, 20);
            this.textBox3.TabIndex = 1;
            // 
            // retrieveIsbnLabel
            // 
            this.retrieveIsbnLabel.AutoSize = true;
            this.retrieveIsbnLabel.Location = new System.Drawing.Point(391, 34);
            this.retrieveIsbnLabel.Name = "retrieveIsbnLabel";
            this.retrieveIsbnLabel.Size = new System.Drawing.Size(32, 13);
            this.retrieveIsbnLabel.TabIndex = 0;
            this.retrieveIsbnLabel.Text = "ISBN";
            // 
            // retrieveTitleLabel
            // 
            this.retrieveTitleLabel.AutoSize = true;
            this.retrieveTitleLabel.Location = new System.Drawing.Point(396, 130);
            this.retrieveTitleLabel.Name = "retrieveTitleLabel";
            this.retrieveTitleLabel.Size = new System.Drawing.Size(27, 13);
            this.retrieveTitleLabel.TabIndex = 0;
            this.retrieveTitleLabel.Text = "Title";
            // 
            // retrieveAuthorLabel
            // 
            this.retrieveAuthorLabel.AutoSize = true;
            this.retrieveAuthorLabel.Location = new System.Drawing.Point(391, 96);
            this.retrieveAuthorLabel.Name = "retrieveAuthorLabel";
            this.retrieveAuthorLabel.Size = new System.Drawing.Size(38, 13);
            this.retrieveAuthorLabel.TabIndex = 0;
            this.retrieveAuthorLabel.Text = "Author";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(471, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(471, 128);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(124, 20);
            this.textBox4.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(471, 93);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(124, 20);
            this.textBox5.TabIndex = 1;
            // 
            // retrieveButton
            // 
            this.retrieveButton.Location = new System.Drawing.Point(520, 58);
            this.retrieveButton.Name = "retrieveButton";
            this.retrieveButton.Size = new System.Drawing.Size(75, 23);
            this.retrieveButton.TabIndex = 2;
            this.retrieveButton.Text = "Retrieve";
            this.retrieveButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 168);
            this.Controls.Add(this.retrieveButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.isbnTextBox);
            this.Controls.Add(this.retrieveAuthorLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.retrieveTitleLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.retrieveIsbnLabel);
            this.Controls.Add(this.isbnLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label isbnLabel;
        private System.Windows.Forms.TextBox isbnTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label retrieveIsbnLabel;
        private System.Windows.Forms.Label retrieveTitleLabel;
        private System.Windows.Forms.Label retrieveAuthorLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button retrieveButton;
    }
}

