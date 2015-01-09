namespace ReadWriteFileApp
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
            this.customerInfoTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.viewBoxListBox = new System.Windows.Forms.ListBox();
            this.showButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Info";
            // 
            // customerInfoTextBox
            // 
            this.customerInfoTextBox.Location = new System.Drawing.Point(128, 10);
            this.customerInfoTextBox.Name = "customerInfoTextBox";
            this.customerInfoTextBox.Size = new System.Drawing.Size(230, 20);
            this.customerInfoTextBox.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(377, 8);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // viewBoxListBox
            // 
            this.viewBoxListBox.FormattingEnabled = true;
            this.viewBoxListBox.Location = new System.Drawing.Point(128, 65);
            this.viewBoxListBox.Name = "viewBoxListBox";
            this.viewBoxListBox.Size = new System.Drawing.Size(230, 316);
            this.viewBoxListBox.TabIndex = 3;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(364, 169);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(88, 45);
            this.showButton.TabIndex = 4;
            this.showButton.Text = "Show All";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 405);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.viewBoxListBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.customerInfoTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customerInfoTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ListBox viewBoxListBox;
        private System.Windows.Forms.Button showButton;
    }
}

