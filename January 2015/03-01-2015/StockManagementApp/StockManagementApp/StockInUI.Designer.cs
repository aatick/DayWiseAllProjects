﻿namespace StockManagementApp
{
    partial class StockInUI
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
            this.stockInButton = new System.Windows.Forms.Button();
            this.itemQuantityTextBox = new System.Windows.Forms.TextBox();
            this.itemIdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stockInButton);
            this.groupBox1.Controls.Add(this.itemQuantityTextBox);
            this.groupBox1.Controls.Add(this.itemIdTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock In Entry";
            // 
            // stockInButton
            // 
            this.stockInButton.Location = new System.Drawing.Point(151, 76);
            this.stockInButton.Name = "stockInButton";
            this.stockInButton.Size = new System.Drawing.Size(81, 29);
            this.stockInButton.TabIndex = 2;
            this.stockInButton.Text = "In";
            this.stockInButton.UseVisualStyleBackColor = true;
            this.stockInButton.Click += new System.EventHandler(this.stockInButton_Click);
            // 
            // itemQuantityTextBox
            // 
            this.itemQuantityTextBox.Location = new System.Drawing.Point(98, 50);
            this.itemQuantityTextBox.Name = "itemQuantityTextBox";
            this.itemQuantityTextBox.Size = new System.Drawing.Size(134, 20);
            this.itemQuantityTextBox.TabIndex = 1;
            // 
            // itemIdTextBox
            // 
            this.itemIdTextBox.Location = new System.Drawing.Point(98, 21);
            this.itemIdTextBox.Name = "itemIdTextBox";
            this.itemIdTextBox.Size = new System.Drawing.Size(134, 20);
            this.itemIdTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Id";
            // 
            // StockInUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 160);
            this.Controls.Add(this.groupBox1);
            this.Name = "StockInUI";
            this.Text = "Stock In";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button stockInButton;
        private System.Windows.Forms.TextBox itemQuantityTextBox;
        private System.Windows.Forms.TextBox itemIdTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}