namespace StudentDepartmentWithDatabaseApp
{
    partial class SearchStudentsUI
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
            this.searchDeptNameComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.studentListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchByDeptNameButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchByCourseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchCourseNameComboBox = new System.Windows.Forms.ComboBox();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // searchDeptNameComboBox
            // 
            this.searchDeptNameComboBox.FormattingEnabled = true;
            this.searchDeptNameComboBox.Location = new System.Drawing.Point(455, 43);
            this.searchDeptNameComboBox.Name = "searchDeptNameComboBox";
            this.searchDeptNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.searchDeptNameComboBox.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(388, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Dept Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(81, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Student Id";
            // 
            // studentListView
            // 
            this.studentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.studentListView.GridLines = true;
            this.studentListView.Location = new System.Drawing.Point(82, 109);
            this.studentListView.Name = "studentListView";
            this.studentListView.Size = new System.Drawing.Size(580, 328);
            this.studentListView.TabIndex = 10;
            this.studentListView.UseCompatibleStateImageBehavior = false;
            this.studentListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 58;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 154;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "RegNo";
            this.columnHeader3.Width = 71;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Email";
            this.columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "DeptName";
            this.columnHeader5.Width = 97;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(140, 43);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(121, 20);
            this.searchTextBox.TabIndex = 9;
            // 
            // searchByDeptNameButton
            // 
            this.searchByDeptNameButton.Location = new System.Drawing.Point(587, 41);
            this.searchByDeptNameButton.Name = "searchByDeptNameButton";
            this.searchByDeptNameButton.Size = new System.Drawing.Size(75, 23);
            this.searchByDeptNameButton.TabIndex = 7;
            this.searchByDeptNameButton.Text = "Search";
            this.searchByDeptNameButton.UseVisualStyleBackColor = true;
            this.searchByDeptNameButton.Click += new System.EventHandler(this.searchByDeptNameButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(276, 41);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchByCourseButton
            // 
            this.searchByCourseButton.Location = new System.Drawing.Point(452, 78);
            this.searchByCourseButton.Name = "searchByCourseButton";
            this.searchByCourseButton.Size = new System.Drawing.Size(75, 23);
            this.searchByCourseButton.TabIndex = 8;
            this.searchByCourseButton.Text = "Search";
            this.searchByCourseButton.UseVisualStyleBackColor = true;
            this.searchByCourseButton.Click += new System.EventHandler(this.searchByCourseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Course Name";
            // 
            // searchCourseNameComboBox
            // 
            this.searchCourseNameComboBox.FormattingEnabled = true;
            this.searchCourseNameComboBox.Location = new System.Drawing.Point(314, 80);
            this.searchCourseNameComboBox.Name = "searchCourseNameComboBox";
            this.searchCourseNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.searchCourseNameComboBox.TabIndex = 13;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "CourseName";
            this.columnHeader6.Width = 101;
            // 
            // SearchStudentsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 452);
            this.Controls.Add(this.searchCourseNameComboBox);
            this.Controls.Add(this.searchDeptNameComboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.studentListView);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchByCourseButton);
            this.Controls.Add(this.searchByDeptNameButton);
            this.Controls.Add(this.searchButton);
            this.Name = "SearchStudentsUI";
            this.Text = "SearchStudentsUI";
            this.Load += new System.EventHandler(this.SearchStudentsUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox searchDeptNameComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView studentListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchByDeptNameButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button searchByCourseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox searchCourseNameComboBox;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}