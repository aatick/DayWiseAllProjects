namespace BankApplication
{
    partial class BankApplicationUI
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
            this.entryGroupBox = new System.Windows.Forms.GroupBox();
            this.openingDateTextBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.accountNoTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.showButton = new System.Windows.Forms.Button();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.openingDateDisplayTextBox = new System.Windows.Forms.TextBox();
            this.emailDisplayTextBox = new System.Windows.Forms.TextBox();
            this.accountNoDisplayTextBox = new System.Windows.Forms.TextBox();
            this.nameDisplayTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.depositeButton = new System.Windows.Forms.Button();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.entryGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // entryGroupBox
            // 
            this.entryGroupBox.Controls.Add(this.openingDateTextBox);
            this.entryGroupBox.Controls.Add(this.createButton);
            this.entryGroupBox.Controls.Add(this.emailTextBox);
            this.entryGroupBox.Controls.Add(this.accountNoTextBox);
            this.entryGroupBox.Controls.Add(this.nameTextBox);
            this.entryGroupBox.Controls.Add(this.label4);
            this.entryGroupBox.Controls.Add(this.label3);
            this.entryGroupBox.Controls.Add(this.label2);
            this.entryGroupBox.Controls.Add(this.label1);
            this.entryGroupBox.Location = new System.Drawing.Point(12, 12);
            this.entryGroupBox.Name = "entryGroupBox";
            this.entryGroupBox.Size = new System.Drawing.Size(319, 184);
            this.entryGroupBox.TabIndex = 0;
            this.entryGroupBox.TabStop = false;
            this.entryGroupBox.Text = "Customer & Account Info";
            // 
            // openingDateTextBox
            // 
            this.openingDateTextBox.Location = new System.Drawing.Point(103, 126);
            this.openingDateTextBox.Name = "openingDateTextBox";
            this.openingDateTextBox.Size = new System.Drawing.Size(195, 20);
            this.openingDateTextBox.TabIndex = 1;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(223, 155);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 2;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(103, 53);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(195, 20);
            this.emailTextBox.TabIndex = 1;
            // 
            // accountNoTextBox
            // 
            this.accountNoTextBox.Location = new System.Drawing.Point(103, 96);
            this.accountNoTextBox.Name = "accountNoTextBox";
            this.accountNoTextBox.Size = new System.Drawing.Size(195, 20);
            this.accountNoTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(103, 23);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(195, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Opening Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Account No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.showButton);
            this.groupBox2.Controls.Add(this.balanceTextBox);
            this.groupBox2.Controls.Add(this.openingDateDisplayTextBox);
            this.groupBox2.Controls.Add(this.emailDisplayTextBox);
            this.groupBox2.Controls.Add(this.accountNoDisplayTextBox);
            this.groupBox2.Controls.Add(this.nameDisplayTextBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(349, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 217);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer & Account Info";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(107, 22);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(195, 23);
            this.showButton.TabIndex = 2;
            this.showButton.Text = "Show Me Details";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.BackColor = System.Drawing.Color.White;
            this.balanceTextBox.Location = new System.Drawing.Point(107, 184);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.ReadOnly = true;
            this.balanceTextBox.Size = new System.Drawing.Size(195, 20);
            this.balanceTextBox.TabIndex = 1;
            // 
            // openingDateDisplayTextBox
            // 
            this.openingDateDisplayTextBox.BackColor = System.Drawing.Color.White;
            this.openingDateDisplayTextBox.Location = new System.Drawing.Point(107, 156);
            this.openingDateDisplayTextBox.Name = "openingDateDisplayTextBox";
            this.openingDateDisplayTextBox.ReadOnly = true;
            this.openingDateDisplayTextBox.Size = new System.Drawing.Size(195, 20);
            this.openingDateDisplayTextBox.TabIndex = 1;
            // 
            // emailDisplayTextBox
            // 
            this.emailDisplayTextBox.BackColor = System.Drawing.Color.White;
            this.emailDisplayTextBox.Location = new System.Drawing.Point(107, 83);
            this.emailDisplayTextBox.Name = "emailDisplayTextBox";
            this.emailDisplayTextBox.ReadOnly = true;
            this.emailDisplayTextBox.Size = new System.Drawing.Size(195, 20);
            this.emailDisplayTextBox.TabIndex = 1;
            // 
            // accountNoDisplayTextBox
            // 
            this.accountNoDisplayTextBox.BackColor = System.Drawing.Color.White;
            this.accountNoDisplayTextBox.Location = new System.Drawing.Point(107, 126);
            this.accountNoDisplayTextBox.Name = "accountNoDisplayTextBox";
            this.accountNoDisplayTextBox.ReadOnly = true;
            this.accountNoDisplayTextBox.Size = new System.Drawing.Size(195, 20);
            this.accountNoDisplayTextBox.TabIndex = 1;
            // 
            // nameDisplayTextBox
            // 
            this.nameDisplayTextBox.BackColor = System.Drawing.Color.White;
            this.nameDisplayTextBox.Location = new System.Drawing.Point(107, 53);
            this.nameDisplayTextBox.Name = "nameDisplayTextBox";
            this.nameDisplayTextBox.ReadOnly = true;
            this.nameDisplayTextBox.Size = new System.Drawing.Size(195, 20);
            this.nameDisplayTextBox.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Balance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Opening Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Account No.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Customer Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.withdrawButton);
            this.groupBox3.Controls.Add(this.depositeButton);
            this.groupBox3.Controls.Add(this.amountTextBox);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(12, 202);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 79);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transaction";
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(223, 49);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(75, 23);
            this.withdrawButton.TabIndex = 2;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // depositeButton
            // 
            this.depositeButton.Location = new System.Drawing.Point(223, 17);
            this.depositeButton.Name = "depositeButton";
            this.depositeButton.Size = new System.Drawing.Size(75, 23);
            this.depositeButton.TabIndex = 2;
            this.depositeButton.Text = "Deposite";
            this.depositeButton.UseVisualStyleBackColor = true;
            this.depositeButton.Click += new System.EventHandler(this.depositeButton_Click);
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(98, 19);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(114, 20);
            this.amountTextBox.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Amount";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(364, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(287, 31);
            this.label10.TabIndex = 1;
            this.label10.Text = "Security Solution Bank";
            // 
            // BankApplicationUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 292);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.entryGroupBox);
            this.Name = "BankApplicationUI";
            this.Text = "Security Solution Bank";
            this.entryGroupBox.ResumeLayout(false);
            this.entryGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox entryGroupBox;
        private System.Windows.Forms.TextBox openingDateTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox accountNoTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.TextBox openingDateDisplayTextBox;
        private System.Windows.Forms.TextBox emailDisplayTextBox;
        private System.Windows.Forms.TextBox accountNoDisplayTextBox;
        private System.Windows.Forms.TextBox nameDisplayTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button depositeButton;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button createButton;
    }
}

