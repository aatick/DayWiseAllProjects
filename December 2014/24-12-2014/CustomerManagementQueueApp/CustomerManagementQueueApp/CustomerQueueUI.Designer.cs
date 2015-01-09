namespace CustomerManagementQueueApp
{
    partial class CustomerQueueUI
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
            this.enqueueGroupBox = new System.Windows.Forms.GroupBox();
            this.enqueueButton = new System.Windows.Forms.Button();
            this.complainTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.complainLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.dequeueGroupBox = new System.Windows.Forms.GroupBox();
            this.dequeueButton = new System.Windows.Forms.Button();
            this.dequeueComplainTextBox = new System.Windows.Forms.TextBox();
            this.dequeueNameTextBox = new System.Windows.Forms.TextBox();
            this.dequeueComplainLabel = new System.Windows.Forms.Label();
            this.dequeueNameLabel = new System.Windows.Forms.Label();
            this.waitingGroupBox = new System.Windows.Forms.GroupBox();
            this.waitingCustomerListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.enqueueGroupBox.SuspendLayout();
            this.dequeueGroupBox.SuspendLayout();
            this.waitingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // enqueueGroupBox
            // 
            this.enqueueGroupBox.Controls.Add(this.enqueueButton);
            this.enqueueGroupBox.Controls.Add(this.complainTextBox);
            this.enqueueGroupBox.Controls.Add(this.nameTextBox);
            this.enqueueGroupBox.Controls.Add(this.complainLabel);
            this.enqueueGroupBox.Controls.Add(this.nameLabel);
            this.enqueueGroupBox.Location = new System.Drawing.Point(12, 12);
            this.enqueueGroupBox.Name = "enqueueGroupBox";
            this.enqueueGroupBox.Size = new System.Drawing.Size(309, 153);
            this.enqueueGroupBox.TabIndex = 0;
            this.enqueueGroupBox.TabStop = false;
            this.enqueueGroupBox.Text = "Enqueue Customer";
            // 
            // enqueueButton
            // 
            this.enqueueButton.Location = new System.Drawing.Point(222, 121);
            this.enqueueButton.Name = "enqueueButton";
            this.enqueueButton.Size = new System.Drawing.Size(75, 23);
            this.enqueueButton.TabIndex = 6;
            this.enqueueButton.Text = "Enqueue";
            this.enqueueButton.UseVisualStyleBackColor = true;
            this.enqueueButton.Click += new System.EventHandler(this.enqueueButton_Click);
            // 
            // complainTextBox
            // 
            this.complainTextBox.Location = new System.Drawing.Point(68, 60);
            this.complainTextBox.Multiline = true;
            this.complainTextBox.Name = "complainTextBox";
            this.complainTextBox.Size = new System.Drawing.Size(229, 52);
            this.complainTextBox.TabIndex = 4;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(68, 27);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(229, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // complainLabel
            // 
            this.complainLabel.AutoSize = true;
            this.complainLabel.Location = new System.Drawing.Point(18, 63);
            this.complainLabel.Name = "complainLabel";
            this.complainLabel.Size = new System.Drawing.Size(50, 13);
            this.complainLabel.TabIndex = 2;
            this.complainLabel.Text = "Complain";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(18, 30);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name";
            // 
            // dequeueGroupBox
            // 
            this.dequeueGroupBox.Controls.Add(this.dequeueButton);
            this.dequeueGroupBox.Controls.Add(this.dequeueComplainTextBox);
            this.dequeueGroupBox.Controls.Add(this.dequeueNameTextBox);
            this.dequeueGroupBox.Controls.Add(this.dequeueComplainLabel);
            this.dequeueGroupBox.Controls.Add(this.dequeueNameLabel);
            this.dequeueGroupBox.Location = new System.Drawing.Point(451, 12);
            this.dequeueGroupBox.Name = "dequeueGroupBox";
            this.dequeueGroupBox.Size = new System.Drawing.Size(309, 153);
            this.dequeueGroupBox.TabIndex = 0;
            this.dequeueGroupBox.TabStop = false;
            this.dequeueGroupBox.Text = "Dequeue GroupBox";
            // 
            // dequeueButton
            // 
            this.dequeueButton.Location = new System.Drawing.Point(222, 130);
            this.dequeueButton.Name = "dequeueButton";
            this.dequeueButton.Size = new System.Drawing.Size(75, 23);
            this.dequeueButton.TabIndex = 6;
            this.dequeueButton.Text = "Dequeue";
            this.dequeueButton.UseVisualStyleBackColor = true;
            this.dequeueButton.Click += new System.EventHandler(this.dequeueButton_Click);
            // 
            // dequeueComplainTextBox
            // 
            this.dequeueComplainTextBox.BackColor = System.Drawing.Color.White;
            this.dequeueComplainTextBox.ForeColor = System.Drawing.Color.Black;
            this.dequeueComplainTextBox.Location = new System.Drawing.Point(68, 60);
            this.dequeueComplainTextBox.Multiline = true;
            this.dequeueComplainTextBox.Name = "dequeueComplainTextBox";
            this.dequeueComplainTextBox.ReadOnly = true;
            this.dequeueComplainTextBox.Size = new System.Drawing.Size(229, 52);
            this.dequeueComplainTextBox.TabIndex = 4;
            // 
            // dequeueNameTextBox
            // 
            this.dequeueNameTextBox.BackColor = System.Drawing.Color.White;
            this.dequeueNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.dequeueNameTextBox.Location = new System.Drawing.Point(68, 27);
            this.dequeueNameTextBox.Name = "dequeueNameTextBox";
            this.dequeueNameTextBox.ReadOnly = true;
            this.dequeueNameTextBox.Size = new System.Drawing.Size(229, 20);
            this.dequeueNameTextBox.TabIndex = 5;
            // 
            // dequeueComplainLabel
            // 
            this.dequeueComplainLabel.AutoSize = true;
            this.dequeueComplainLabel.Location = new System.Drawing.Point(18, 63);
            this.dequeueComplainLabel.Name = "dequeueComplainLabel";
            this.dequeueComplainLabel.Size = new System.Drawing.Size(50, 13);
            this.dequeueComplainLabel.TabIndex = 2;
            this.dequeueComplainLabel.Text = "Complain";
            // 
            // dequeueNameLabel
            // 
            this.dequeueNameLabel.AutoSize = true;
            this.dequeueNameLabel.Location = new System.Drawing.Point(18, 30);
            this.dequeueNameLabel.Name = "dequeueNameLabel";
            this.dequeueNameLabel.Size = new System.Drawing.Size(35, 13);
            this.dequeueNameLabel.TabIndex = 3;
            this.dequeueNameLabel.Text = "Name";
            // 
            // waitingGroupBox
            // 
            this.waitingGroupBox.Controls.Add(this.waitingCustomerListView);
            this.waitingGroupBox.Location = new System.Drawing.Point(12, 189);
            this.waitingGroupBox.Name = "waitingGroupBox";
            this.waitingGroupBox.Size = new System.Drawing.Size(748, 265);
            this.waitingGroupBox.TabIndex = 1;
            this.waitingGroupBox.TabStop = false;
            this.waitingGroupBox.Text = "Waiting Customers";
            // 
            // waitingCustomerListView
            // 
            this.waitingCustomerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.waitingCustomerListView.GridLines = true;
            this.waitingCustomerListView.Location = new System.Drawing.Point(7, 20);
            this.waitingCustomerListView.Name = "waitingCustomerListView";
            this.waitingCustomerListView.Size = new System.Drawing.Size(729, 237);
            this.waitingCustomerListView.TabIndex = 0;
            this.waitingCustomerListView.UseCompatibleStateImageBehavior = false;
            this.waitingCustomerListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Serial No.";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Complain";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Status";
            // 
            // CustomerQueueUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 452);
            this.Controls.Add(this.waitingGroupBox);
            this.Controls.Add(this.dequeueGroupBox);
            this.Controls.Add(this.enqueueGroupBox);
            this.Name = "CustomerQueueUI";
            this.Text = "CustomerQueueUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerQueueUI_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.enqueueGroupBox.ResumeLayout(false);
            this.enqueueGroupBox.PerformLayout();
            this.dequeueGroupBox.ResumeLayout(false);
            this.dequeueGroupBox.PerformLayout();
            this.waitingGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox enqueueGroupBox;
        private System.Windows.Forms.Button enqueueButton;
        private System.Windows.Forms.TextBox complainTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label complainLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.GroupBox dequeueGroupBox;
        private System.Windows.Forms.Button dequeueButton;
        private System.Windows.Forms.TextBox dequeueComplainTextBox;
        private System.Windows.Forms.TextBox dequeueNameTextBox;
        private System.Windows.Forms.Label dequeueComplainLabel;
        private System.Windows.Forms.Label dequeueNameLabel;
        private System.Windows.Forms.GroupBox waitingGroupBox;
        private System.Windows.Forms.ListView waitingCustomerListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;

    }
}

