namespace StudentDepartmentWithDatabaseApp
{
    partial class DeptEntryUI
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
            this.deptnameTextBox = new System.Windows.Forms.TextBox();
            this.deptIdTextBox = new System.Windows.Forms.TextBox();
            this.deptSaveButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deptnameTextBox
            // 
            this.deptnameTextBox.Location = new System.Drawing.Point(141, 68);
            this.deptnameTextBox.Name = "deptnameTextBox";
            this.deptnameTextBox.Size = new System.Drawing.Size(121, 20);
            this.deptnameTextBox.TabIndex = 8;
            // 
            // deptIdTextBox
            // 
            this.deptIdTextBox.Location = new System.Drawing.Point(141, 40);
            this.deptIdTextBox.Name = "deptIdTextBox";
            this.deptIdTextBox.Size = new System.Drawing.Size(121, 20);
            this.deptIdTextBox.TabIndex = 9;
            // 
            // deptSaveButton
            // 
            this.deptSaveButton.Location = new System.Drawing.Point(187, 99);
            this.deptSaveButton.Name = "deptSaveButton";
            this.deptSaveButton.Size = new System.Drawing.Size(75, 23);
            this.deptSaveButton.TabIndex = 7;
            this.deptSaveButton.Text = "Add";
            this.deptSaveButton.UseVisualStyleBackColor = true;
            this.deptSaveButton.Click += new System.EventHandler(this.deptSaveButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Department";
            // 
            // DeptEntryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 145);
            this.Controls.Add(this.deptnameTextBox);
            this.Controls.Add(this.deptIdTextBox);
            this.Controls.Add(this.deptSaveButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Name = "DeptEntryUI";
            this.Text = "DeptEntryUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox deptnameTextBox;
        private System.Windows.Forms.TextBox deptIdTextBox;
        private System.Windows.Forms.Button deptSaveButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
    }
}