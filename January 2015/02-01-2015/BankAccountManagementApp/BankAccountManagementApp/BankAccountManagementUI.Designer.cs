using System.Security.AccessControl;

namespace BankAccountManagementApp
{
    partial class BankAccountManagementUI
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
            this.customerSaveButton = new System.Windows.Forms.Button();
            this.customerAddressTextBox = new System.Windows.Forms.TextBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.customerMobileTextBox = new System.Windows.Forms.TextBox();
            this.nationalIdTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.accountCustomerComboBox = new System.Windows.Forms.ComboBox();
            this.accountTypeComboBox = new System.Windows.Forms.ComboBox();
            this.accountSaveButton = new System.Windows.Forms.Button();
            this.accountNumberTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.transactionCustomerComboBox = new System.Windows.Forms.ComboBox();
            this.transactionAccountComboBox = new System.Windows.Forms.ComboBox();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.depositButton = new System.Windows.Forms.Button();
            this.transactionAmountTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.reportCustomerComboBox = new System.Windows.Forms.ComboBox();
            this.showButton = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.customerSaveButton);
            this.groupBox1.Controls.Add(this.customerAddressTextBox);
            this.groupBox1.Controls.Add(this.customerNameTextBox);
            this.groupBox1.Controls.Add(this.customerMobileTextBox);
            this.groupBox1.Controls.Add(this.nationalIdTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 198);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Innformation";
            // 
            // customerSaveButton
            // 
            this.customerSaveButton.Location = new System.Drawing.Point(221, 169);
            this.customerSaveButton.Name = "customerSaveButton";
            this.customerSaveButton.Size = new System.Drawing.Size(75, 23);
            this.customerSaveButton.TabIndex = 2;
            this.customerSaveButton.Text = "Save";
            this.customerSaveButton.UseVisualStyleBackColor = true;
            this.customerSaveButton.Click += new System.EventHandler(this.customerSaveButton_Click);
            // 
            // customerAddressTextBox
            // 
            this.customerAddressTextBox.Location = new System.Drawing.Point(104, 106);
            this.customerAddressTextBox.Multiline = true;
            this.customerAddressTextBox.Name = "customerAddressTextBox";
            this.customerAddressTextBox.Size = new System.Drawing.Size(192, 56);
            this.customerAddressTextBox.TabIndex = 1;
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(104, 53);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(192, 20);
            this.customerNameTextBox.TabIndex = 1;
            // 
            // customerMobileTextBox
            // 
            this.customerMobileTextBox.Location = new System.Drawing.Point(104, 80);
            this.customerMobileTextBox.Name = "customerMobileTextBox";
            this.customerMobileTextBox.Size = new System.Drawing.Size(192, 20);
            this.customerMobileTextBox.TabIndex = 1;
            // 
            // nationalIdTextBox
            // 
            this.nationalIdTextBox.Location = new System.Drawing.Point(104, 27);
            this.nationalIdTextBox.Name = "nationalIdTextBox";
            this.nationalIdTextBox.Size = new System.Drawing.Size(192, 20);
            this.nationalIdTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Present Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phone/Mobile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "National Id";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.accountCustomerComboBox);
            this.groupBox3.Controls.Add(this.accountTypeComboBox);
            this.groupBox3.Controls.Add(this.accountSaveButton);
            this.groupBox3.Controls.Add(this.accountNumberTextBox);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(12, 217);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(308, 132);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Account Information";
            // 
            // accountCustomerComboBox
            // 
            this.accountCustomerComboBox.FormattingEnabled = true;
            this.accountCustomerComboBox.Location = new System.Drawing.Point(104, 80);
            this.accountCustomerComboBox.MaxDropDownItems = 100;
            this.accountCustomerComboBox.Name = "accountCustomerComboBox";
            this.accountCustomerComboBox.Size = new System.Drawing.Size(192, 21);
            this.accountCustomerComboBox.Sorted = true;
            this.accountCustomerComboBox.TabIndex = 3;
            this.accountCustomerComboBox.Text = "--Select--";
            // 
            // accountTypeComboBox
            // 
            this.accountTypeComboBox.BackColor = System.Drawing.Color.White;
            this.accountTypeComboBox.FormattingEnabled = true;
            this.accountTypeComboBox.Location = new System.Drawing.Point(104, 54);
            this.accountTypeComboBox.Name = "accountTypeComboBox";
            this.accountTypeComboBox.Size = new System.Drawing.Size(192, 21);
            this.accountTypeComboBox.Sorted = true;
            this.accountTypeComboBox.TabIndex = 3;
            this.accountTypeComboBox.Text = "--Select--";
            this.accountTypeComboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.accountTypeComboBox_MouseClick);
            // 
            // accountSaveButton
            // 
            this.accountSaveButton.Location = new System.Drawing.Point(221, 105);
            this.accountSaveButton.Name = "accountSaveButton";
            this.accountSaveButton.Size = new System.Drawing.Size(75, 23);
            this.accountSaveButton.TabIndex = 2;
            this.accountSaveButton.Text = "Save";
            this.accountSaveButton.UseVisualStyleBackColor = true;
            this.accountSaveButton.Click += new System.EventHandler(this.accountSaveButton_Click);
            // 
            // accountNumberTextBox
            // 
            this.accountNumberTextBox.Location = new System.Drawing.Point(104, 27);
            this.accountNumberTextBox.Name = "accountNumberTextBox";
            this.accountNumberTextBox.Size = new System.Drawing.Size(192, 20);
            this.accountNumberTextBox.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Customer";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Type";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Account Number";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.transactionCustomerComboBox);
            this.groupBox4.Controls.Add(this.transactionAccountComboBox);
            this.groupBox4.Controls.Add(this.withdrawButton);
            this.groupBox4.Controls.Add(this.depositButton);
            this.groupBox4.Controls.Add(this.transactionAmountTextBox);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(352, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(308, 141);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Transaction in Account";
            // 
            // transactionCustomerComboBox
            // 
            this.transactionCustomerComboBox.FormattingEnabled = true;
            this.transactionCustomerComboBox.Location = new System.Drawing.Point(104, 27);
            this.transactionCustomerComboBox.Name = "transactionCustomerComboBox";
            this.transactionCustomerComboBox.Size = new System.Drawing.Size(192, 21);
            this.transactionCustomerComboBox.Sorted = true;
            this.transactionCustomerComboBox.TabIndex = 3;
            this.transactionCustomerComboBox.Text = "--Select--";
            this.transactionCustomerComboBox.SelectedIndexChanged += new System.EventHandler(this.transactionCustomerComboBox_SelectedIndexChanged);
            this.transactionCustomerComboBox.SelectionChangeCommitted += new System.EventHandler(this.transactionCustomerComboBox_SelectionChangeCommitted);
            this.transactionCustomerComboBox.TextChanged += new System.EventHandler(this.transactionCustomerComboBox_TextChanged);
            this.transactionCustomerComboBox.Click += new System.EventHandler(this.transactionCustomerComboBox_Click);
            this.transactionCustomerComboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.transactionCustomerComboBox_MouseClick);
            // 
            // transactionAccountComboBox
            // 
            this.transactionAccountComboBox.FormattingEnabled = true;
            this.transactionAccountComboBox.Location = new System.Drawing.Point(104, 53);
            this.transactionAccountComboBox.Name = "transactionAccountComboBox";
            this.transactionAccountComboBox.Size = new System.Drawing.Size(192, 21);
            this.transactionAccountComboBox.Sorted = true;
            this.transactionAccountComboBox.TabIndex = 3;
            this.transactionAccountComboBox.Text = "--Select--";
            this.transactionAccountComboBox.SelectedIndexChanged += new System.EventHandler(this.transactionAccountComboBox_SelectedIndexChanged);
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(207, 109);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(75, 23);
            this.withdrawButton.TabIndex = 2;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(104, 109);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(75, 23);
            this.depositButton.TabIndex = 2;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // transactionAmountTextBox
            // 
            this.transactionAmountTextBox.Location = new System.Drawing.Point(104, 80);
            this.transactionAmountTextBox.Name = "transactionAmountTextBox";
            this.transactionAmountTextBox.Size = new System.Drawing.Size(104, 20);
            this.transactionAmountTextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Amount";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Account";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Customer";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.reportCustomerComboBox);
            this.groupBox5.Controls.Add(this.showButton);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Location = new System.Drawing.Point(353, 160);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(308, 89);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Report";
            // 
            // reportCustomerComboBox
            // 
            this.reportCustomerComboBox.FormattingEnabled = true;
            this.reportCustomerComboBox.Location = new System.Drawing.Point(104, 29);
            this.reportCustomerComboBox.Name = "reportCustomerComboBox";
            this.reportCustomerComboBox.Size = new System.Drawing.Size(192, 21);
            this.reportCustomerComboBox.Sorted = true;
            this.reportCustomerComboBox.TabIndex = 3;
            this.reportCustomerComboBox.Text = "--Select--";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(190, 57);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(106, 23);
            this.showButton.TabIndex = 2;
            this.showButton.Text = "Show Account Info";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Customer";
            // 
            // BankAccountManagementUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 357);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "BankAccountManagementUI";
            this.Text = "Bank Account Management";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button customerSaveButton;
        private System.Windows.Forms.TextBox customerAddressTextBox;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox customerMobileTextBox;
        private System.Windows.Forms.TextBox nationalIdTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button accountSaveButton;
        private System.Windows.Forms.TextBox accountNumberTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox accountCustomerComboBox;
        private System.Windows.Forms.ComboBox accountTypeComboBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox transactionAccountComboBox;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.TextBox transactionAmountTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox reportCustomerComboBox;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox transactionCustomerComboBox;
    }
}

