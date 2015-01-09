namespace HashTableProject
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
            this.firstView = new System.Windows.Forms.ListBox();
            this.secondView = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstView
            // 
            this.firstView.FormattingEnabled = true;
            this.firstView.Location = new System.Drawing.Point(12, 28);
            this.firstView.Name = "firstView";
            this.firstView.Size = new System.Drawing.Size(120, 212);
            this.firstView.TabIndex = 0;
            // 
            // secondView
            // 
            this.secondView.FormattingEnabled = true;
            this.secondView.Location = new System.Drawing.Point(152, 28);
            this.secondView.Name = "secondView";
            this.secondView.Size = new System.Drawing.Size(120, 212);
            this.secondView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "HashTable";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondView);
            this.Controls.Add(this.firstView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox firstView;
        private System.Windows.Forms.ListBox secondView;
        private System.Windows.Forms.Label label1;
    }
}

