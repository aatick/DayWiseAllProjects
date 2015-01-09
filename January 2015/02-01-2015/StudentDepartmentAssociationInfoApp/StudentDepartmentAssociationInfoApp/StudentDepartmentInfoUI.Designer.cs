namespace StudentDepartmentAssociationInfoApp
{
    partial class StudentDepartmentInfoUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deptSaveButton = new System.Windows.Forms.Button();
            this.deptNameTextBox = new System.Windows.Forms.TextBox();
            this.deptCodeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.studentDeptComboBox = new System.Windows.Forms.ComboBox();
            this.studentSaveButton = new System.Windows.Forms.Button();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.studentEmailTextBox = new System.Windows.Forms.TextBox();
            this.studentRegNoTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.selectDeptComboBox = new System.Windows.Forms.ComboBox();
            this.showButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.deptSaveButton);
            this.groupBox1.Controls.Add(this.deptNameTextBox);
            this.groupBox1.Controls.Add(this.deptCodeTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Department Info";
            // 
            // deptSaveButton
            // 
            this.deptSaveButton.Location = new System.Drawing.Point(382, 78);
            this.deptSaveButton.Name = "deptSaveButton";
            this.deptSaveButton.Size = new System.Drawing.Size(75, 23);
            this.deptSaveButton.TabIndex = 2;
            this.deptSaveButton.Text = "Save";
            this.deptSaveButton.UseVisualStyleBackColor = true;
            this.deptSaveButton.Click += new System.EventHandler(this.deptSaveButton_Click);
            // 
            // deptNameTextBox
            // 
            this.deptNameTextBox.Location = new System.Drawing.Point(97, 52);
            this.deptNameTextBox.Name = "deptNameTextBox";
            this.deptNameTextBox.Size = new System.Drawing.Size(360, 20);
            this.deptNameTextBox.TabIndex = 1;
            // 
            // deptCodeTextBox
            // 
            this.deptCodeTextBox.Location = new System.Drawing.Point(97, 23);
            this.deptCodeTextBox.Name = "deptCodeTextBox";
            this.deptCodeTextBox.Size = new System.Drawing.Size(121, 20);
            this.deptCodeTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.studentDeptComboBox);
            this.groupBox2.Controls.Add(this.studentSaveButton);
            this.groupBox2.Controls.Add(this.studentNameTextBox);
            this.groupBox2.Controls.Add(this.studentEmailTextBox);
            this.groupBox2.Controls.Add(this.studentRegNoTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(13, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(466, 141);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student Info";
            // 
            // studentDeptComboBox
            // 
            this.studentDeptComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studentDeptComboBox.FormattingEnabled = true;
            this.studentDeptComboBox.Location = new System.Drawing.Point(97, 107);
            this.studentDeptComboBox.Name = "studentDeptComboBox";
            this.studentDeptComboBox.Size = new System.Drawing.Size(267, 21);
            this.studentDeptComboBox.TabIndex = 3;
            // 
            // studentSaveButton
            // 
            this.studentSaveButton.Location = new System.Drawing.Point(382, 105);
            this.studentSaveButton.Name = "studentSaveButton";
            this.studentSaveButton.Size = new System.Drawing.Size(75, 23);
            this.studentSaveButton.TabIndex = 2;
            this.studentSaveButton.Text = "Save";
            this.studentSaveButton.UseVisualStyleBackColor = true;
            this.studentSaveButton.Click += new System.EventHandler(this.studentSaveButton_Click);
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.Location = new System.Drawing.Point(97, 52);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(360, 20);
            this.studentNameTextBox.TabIndex = 1;
            // 
            // studentEmailTextBox
            // 
            this.studentEmailTextBox.Location = new System.Drawing.Point(97, 78);
            this.studentEmailTextBox.Name = "studentEmailTextBox";
            this.studentEmailTextBox.Size = new System.Drawing.Size(360, 20);
            this.studentEmailTextBox.TabIndex = 1;
            // 
            // studentRegNoTextBox
            // 
            this.studentRegNoTextBox.Location = new System.Drawing.Point(97, 23);
            this.studentRegNoTextBox.Name = "studentRegNoTextBox";
            this.studentRegNoTextBox.Size = new System.Drawing.Size(121, 20);
            this.studentRegNoTextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Department";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Reg No.";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.selectDeptComboBox);
            this.groupBox3.Controls.Add(this.showButton);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(14, 272);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(465, 51);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Student List";
            // 
            // selectDeptComboBox
            // 
            this.selectDeptComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectDeptComboBox.FormattingEnabled = true;
            this.selectDeptComboBox.Location = new System.Drawing.Point(96, 23);
            this.selectDeptComboBox.Name = "selectDeptComboBox";
            this.selectDeptComboBox.Size = new System.Drawing.Size(267, 21);
            this.selectDeptComboBox.TabIndex = 3;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(381, 21);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 2;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Department";
            // 
            // StudentDepartmentInfoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 333);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "StudentDepartmentInfoUI";
            this.Text = "Student & Department Info";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deptSaveButton;
        private System.Windows.Forms.TextBox deptNameTextBox;
        private System.Windows.Forms.TextBox deptCodeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox studentDeptComboBox;
        private System.Windows.Forms.Button studentSaveButton;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.TextBox studentEmailTextBox;
        private System.Windows.Forms.TextBox studentRegNoTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox selectDeptComboBox;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label label8;
    }
}

