namespace TicketPriceCalculatorApp
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
            this.label2 = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.noOfTicketTextBox = new System.Windows.Forms.TextBox();
            this.CalculatePriceButton = new System.Windows.Forms.Button();
            this.DetailsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number Of Tickets";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(106, 12);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(124, 20);
            this.customerNameTextBox.TabIndex = 2;
            this.customerNameTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.customerNameTextBox_MouseClick);
            // 
            // noOfTicketTextBox
            // 
            this.noOfTicketTextBox.Location = new System.Drawing.Point(106, 58);
            this.noOfTicketTextBox.Name = "noOfTicketTextBox";
            this.noOfTicketTextBox.Size = new System.Drawing.Size(124, 20);
            this.noOfTicketTextBox.TabIndex = 2;
            this.noOfTicketTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.noOfTicketTextBox_MouseClick);
            // 
            // CalculatePriceButton
            // 
            this.CalculatePriceButton.Location = new System.Drawing.Point(45, 141);
            this.CalculatePriceButton.Name = "CalculatePriceButton";
            this.CalculatePriceButton.Size = new System.Drawing.Size(75, 23);
            this.CalculatePriceButton.TabIndex = 3;
            this.CalculatePriceButton.Text = "Ticket Price";
            this.CalculatePriceButton.UseVisualStyleBackColor = true;
            this.CalculatePriceButton.Click += new System.EventHandler(this.CalculatePriceButton_Click);
            // 
            // DetailsButton
            // 
            this.DetailsButton.Location = new System.Drawing.Point(155, 141);
            this.DetailsButton.Name = "DetailsButton";
            this.DetailsButton.Size = new System.Drawing.Size(75, 23);
            this.DetailsButton.TabIndex = 3;
            this.DetailsButton.Text = "Details";
            this.DetailsButton.UseVisualStyleBackColor = true;
            this.DetailsButton.Click += new System.EventHandler(this.DetailsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 205);
            this.Controls.Add(this.DetailsButton);
            this.Controls.Add(this.CalculatePriceButton);
            this.Controls.Add(this.noOfTicketTextBox);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(272, 244);
            this.MinimumSize = new System.Drawing.Size(272, 244);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseTicketApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox noOfTicketTextBox;
        private System.Windows.Forms.Button CalculatePriceButton;
        private System.Windows.Forms.Button DetailsButton;
    }
}

