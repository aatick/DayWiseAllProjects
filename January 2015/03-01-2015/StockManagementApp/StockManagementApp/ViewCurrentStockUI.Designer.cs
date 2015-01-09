namespace StockManagementApp
{
    partial class ViewCurrentStockUI
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
            this.currentStockListView = new System.Windows.Forms.ListView();
            this.itemIdColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemQuantityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.currentStockListView);
            this.groupBox1.Location = new System.Drawing.Point(12, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 249);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Stock";
            // 
            // currentStockListView
            // 
            this.currentStockListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemIdColumn,
            this.itemQuantityColumn});
            this.currentStockListView.GridLines = true;
            this.currentStockListView.Location = new System.Drawing.Point(14, 24);
            this.currentStockListView.Name = "currentStockListView";
            this.currentStockListView.Size = new System.Drawing.Size(284, 207);
            this.currentStockListView.TabIndex = 0;
            this.currentStockListView.UseCompatibleStateImageBehavior = false;
            this.currentStockListView.View = System.Windows.Forms.View.Details;
            // 
            // itemIdColumn
            // 
            this.itemIdColumn.Text = "Item Id";
            this.itemIdColumn.Width = 101;
            // 
            // itemQuantityColumn
            // 
            this.itemQuantityColumn.Text = "Quantity";
            this.itemQuantityColumn.Width = 99;
            // 
            // ViewCurrentStockUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 280);
            this.Controls.Add(this.groupBox1);
            this.Name = "ViewCurrentStockUI";
            this.Text = "View Current Stock";
            this.Load += new System.EventHandler(this.ViewCurrentStockUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView currentStockListView;
        private System.Windows.Forms.ColumnHeader itemIdColumn;
        private System.Windows.Forms.ColumnHeader itemQuantityColumn;
    }
}