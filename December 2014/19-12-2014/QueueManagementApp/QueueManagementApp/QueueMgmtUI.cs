using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueueManagementApp
{
    public partial class QueueMgmtUI : Form
    {
        public QueueMgmtUI()
        {
            InitializeComponent();
        }

       
        private void enqueueButton_Click(object sender, EventArgs e)
        {
            ListViewItem item1=new ListViewItem();
            string serial = "";
            if (waitingQueueListView.Items.Count > 0)
            {
                item1 = waitingQueueListView.Items[waitingQueueListView.Items.Count - 1];
                serial = (int.Parse(item1.SubItems[0].Text) + 1).ToString();
            }
            else
                serial = "1";
            ListViewItem items=new ListViewItem(serial);
            items.SubItems.Add(nameTextBox.Text);
            items.SubItems.Add(complainTextBox.Text);
            waitingQueueListView.Items.Add(items);
            MessageBox.Show(nameTextBox.Text + "'s Serial No. is: " + serial);
        }

        private void QueueMgmtUI_Load(object sender, EventArgs e)
        {
           
        }

        private void dequeueButton_Click(object sender, EventArgs e)
        {
            ListViewItem dequeueList = new ListViewItem();
            if (waitingQueueListView.Items.Count > 0)
            {
                dequeueList = waitingQueueListView.Items[0];
                serialNoTextBox.Text = dequeueList.SubItems[0].Text;
                dequeueNameTextBox.Text = dequeueList.SubItems[1].Text;
                dequeueComplainTextBox.Text = dequeueList.SubItems[2].Text;
                waitingQueueListView.Items.Remove(dequeueList);
            }
            else
            {
                MessageBox.Show("There is no data record to Dequeue.");
            }
        }
    }
}
