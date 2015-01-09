namespace QueueManagementApp
{
    partial class QueueMgmtUI
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
            this.serialNoLabel = new System.Windows.Forms.Label();
            this.serialNoTextBox = new System.Windows.Forms.TextBox();
            this.waitingQueueGroupBox = new System.Windows.Forms.GroupBox();
            this.waitingQueueListView = new System.Windows.Forms.ListView();
            this.serialColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.complainColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.enqueueGroupBox.SuspendLayout();
            this.dequeueGroupBox.SuspendLayout();
            this.waitingQueueGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // enqueueGroupBox
            // 
            this.enqueueGroupBox.Controls.Add(this.enqueueButton);
            this.enqueueGroupBox.Controls.Add(this.complainTextBox);
            this.enqueueGroupBox.Controls.Add(this.nameTextBox);
            this.enqueueGroupBox.Controls.Add(this.complainLabel);
            this.enqueueGroupBox.Controls.Add(this.nameLabel);
            this.enqueueGroupBox.Location = new System.Drawing.Point(23, 12);
            this.enqueueGroupBox.Name = "enqueueGroupBox";
            this.enqueueGroupBox.Size = new System.Drawing.Size(379, 168);
            this.enqueueGroupBox.TabIndex = 0;
            this.enqueueGroupBox.TabStop = false;
            this.enqueueGroupBox.Text = "Enqueue Customer";
            // 
            // enqueueButton
            // 
            this.enqueueButton.Location = new System.Drawing.Point(265, 139);
            this.enqueueButton.Name = "enqueueButton";
            this.enqueueButton.Size = new System.Drawing.Size(75, 23);
            this.enqueueButton.TabIndex = 2;
            this.enqueueButton.Text = "Enqueue";
            this.enqueueButton.UseVisualStyleBackColor = true;
            this.enqueueButton.Click += new System.EventHandler(this.enqueueButton_Click);
            // 
            // complainTextBox
            // 
            this.complainTextBox.Location = new System.Drawing.Point(86, 56);
            this.complainTextBox.Multiline = true;
            this.complainTextBox.Name = "complainTextBox";
            this.complainTextBox.Size = new System.Drawing.Size(254, 63);
            this.complainTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(86, 25);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(177, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // complainLabel
            // 
            this.complainLabel.AutoSize = true;
            this.complainLabel.Location = new System.Drawing.Point(16, 59);
            this.complainLabel.Name = "complainLabel";
            this.complainLabel.Size = new System.Drawing.Size(50, 13);
            this.complainLabel.TabIndex = 0;
            this.complainLabel.Text = "Complain";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(16, 28);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // dequeueGroupBox
            // 
            this.dequeueGroupBox.Controls.Add(this.dequeueButton);
            this.dequeueGroupBox.Controls.Add(this.dequeueComplainTextBox);
            this.dequeueGroupBox.Controls.Add(this.serialNoTextBox);
            this.dequeueGroupBox.Controls.Add(this.dequeueNameTextBox);
            this.dequeueGroupBox.Controls.Add(this.dequeueComplainLabel);
            this.dequeueGroupBox.Controls.Add(this.serialNoLabel);
            this.dequeueGroupBox.Controls.Add(this.dequeueNameLabel);
            this.dequeueGroupBox.Location = new System.Drawing.Point(437, 12);
            this.dequeueGroupBox.Name = "dequeueGroupBox";
            this.dequeueGroupBox.Size = new System.Drawing.Size(379, 168);
            this.dequeueGroupBox.TabIndex = 0;
            this.dequeueGroupBox.TabStop = false;
            this.dequeueGroupBox.Text = "Dequeue Customer";
            // 
            // dequeueButton
            // 
            this.dequeueButton.Location = new System.Drawing.Point(265, 139);
            this.dequeueButton.Name = "dequeueButton";
            this.dequeueButton.Size = new System.Drawing.Size(75, 23);
            this.dequeueButton.TabIndex = 2;
            this.dequeueButton.Text = "Dequeue";
            this.dequeueButton.UseVisualStyleBackColor = true;
            this.dequeueButton.Click += new System.EventHandler(this.dequeueButton_Click);
            // 
            // dequeueComplainTextBox
            // 
            this.dequeueComplainTextBox.BackColor = System.Drawing.Color.White;
            this.dequeueComplainTextBox.Location = new System.Drawing.Point(86, 73);
            this.dequeueComplainTextBox.Multiline = true;
            this.dequeueComplainTextBox.Name = "dequeueComplainTextBox";
            this.dequeueComplainTextBox.ReadOnly = true;
            this.dequeueComplainTextBox.Size = new System.Drawing.Size(254, 63);
            this.dequeueComplainTextBox.TabIndex = 1;
            // 
            // dequeueNameTextBox
            // 
            this.dequeueNameTextBox.BackColor = System.Drawing.Color.White;
            this.dequeueNameTextBox.Location = new System.Drawing.Point(86, 46);
            this.dequeueNameTextBox.Name = "dequeueNameTextBox";
            this.dequeueNameTextBox.ReadOnly = true;
            this.dequeueNameTextBox.Size = new System.Drawing.Size(177, 20);
            this.dequeueNameTextBox.TabIndex = 1;
            // 
            // dequeueComplainLabel
            // 
            this.dequeueComplainLabel.AutoSize = true;
            this.dequeueComplainLabel.Location = new System.Drawing.Point(16, 77);
            this.dequeueComplainLabel.Name = "dequeueComplainLabel";
            this.dequeueComplainLabel.Size = new System.Drawing.Size(50, 13);
            this.dequeueComplainLabel.TabIndex = 0;
            this.dequeueComplainLabel.Text = "Complain";
            // 
            // dequeueNameLabel
            // 
            this.dequeueNameLabel.AutoSize = true;
            this.dequeueNameLabel.Location = new System.Drawing.Point(17, 49);
            this.dequeueNameLabel.Name = "dequeueNameLabel";
            this.dequeueNameLabel.Size = new System.Drawing.Size(35, 13);
            this.dequeueNameLabel.TabIndex = 0;
            this.dequeueNameLabel.Text = "Name";
            // 
            // serialNoLabel
            // 
            this.serialNoLabel.AutoSize = true;
            this.serialNoLabel.Location = new System.Drawing.Point(17, 20);
            this.serialNoLabel.Name = "serialNoLabel";
            this.serialNoLabel.Size = new System.Drawing.Size(53, 13);
            this.serialNoLabel.TabIndex = 0;
            this.serialNoLabel.Text = "Serial No.";
            // 
            // serialNoTextBox
            // 
            this.serialNoTextBox.Location = new System.Drawing.Point(86, 17);
            this.serialNoTextBox.Name = "serialNoTextBox";
            this.serialNoTextBox.Size = new System.Drawing.Size(177, 20);
            this.serialNoTextBox.TabIndex = 1;
            // 
            // waitingQueueGroupBox
            // 
            this.waitingQueueGroupBox.Controls.Add(this.waitingQueueListView);
            this.waitingQueueGroupBox.Location = new System.Drawing.Point(23, 207);
            this.waitingQueueGroupBox.Name = "waitingQueueGroupBox";
            this.waitingQueueGroupBox.Size = new System.Drawing.Size(793, 254);
            this.waitingQueueGroupBox.TabIndex = 1;
            this.waitingQueueGroupBox.TabStop = false;
            this.waitingQueueGroupBox.Text = "Waiting Queue";
            // 
            // waitingQueueListView
            // 
            this.waitingQueueListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.serialColumn,
            this.nameColumn,
            this.complainColumn});
            this.waitingQueueListView.GridLines = true;
            this.waitingQueueListView.Location = new System.Drawing.Point(19, 20);
            this.waitingQueueListView.Name = "waitingQueueListView";
            this.waitingQueueListView.Size = new System.Drawing.Size(768, 228);
            this.waitingQueueListView.TabIndex = 0;
            this.waitingQueueListView.UseCompatibleStateImageBehavior = false;
            this.waitingQueueListView.View = System.Windows.Forms.View.Details;
            // 
            // serialColumn
            // 
            this.serialColumn.Text = "Serial No.";
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Name";
            this.nameColumn.Width = 55;
            // 
            // complainColumn
            // 
            this.complainColumn.Text = "Complain";
            this.complainColumn.Width = 600;
            // 
            // QueueMgmtUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 473);
            this.Controls.Add(this.waitingQueueGroupBox);
            this.Controls.Add(this.dequeueGroupBox);
            this.Controls.Add(this.enqueueGroupBox);
            this.Name = "QueueMgmtUI";
            this.Text = "Customer Queue Management";
            this.Load += new System.EventHandler(this.QueueMgmtUI_Load);
            this.enqueueGroupBox.ResumeLayout(false);
            this.enqueueGroupBox.PerformLayout();
            this.dequeueGroupBox.ResumeLayout(false);
            this.dequeueGroupBox.PerformLayout();
            this.waitingQueueGroupBox.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox serialNoTextBox;
        private System.Windows.Forms.Label serialNoLabel;
        private System.Windows.Forms.GroupBox waitingQueueGroupBox;
        private System.Windows.Forms.ListView waitingQueueListView;
        private System.Windows.Forms.ColumnHeader serialColumn;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader complainColumn;
    }
}

