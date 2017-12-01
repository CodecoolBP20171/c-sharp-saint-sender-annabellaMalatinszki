using System.Collections.Generic;
using System.Windows.Forms;

namespace SaintSender
{
    public partial class Form1
    {
        // Populate ListViews with the messages of the corresponding labels.
        private void PopulateMessages(List<Email> emails)
        {
            ListViewItem item = null;

            messagesListView.Clear();
            sentMessagesListView.Clear();
            draftsListView.Clear();
            spamListView.Clear();
            trashListView.Clear();

            foreach (Email email in emails)
            {
                item = new ListViewItem(email.Sender + " " + email.EmailSubject);
                item.Tag = email;

                if (email.EmailLabel == MessageLabel.INBOX)
                {
                    messagesListView.Items.Add(item);
                }
                else if (email.EmailLabel == MessageLabel.SENT)
                {
                    sentMessagesListView.Items.Add(item);
                }
                else if (email.EmailLabel == MessageLabel.DRAFT)
                {
                    draftsListView.Items.Add(item);
                }
                else if (email.EmailLabel == MessageLabel.SPAM)
                {
                    spamListView.Items.Add(item);
                }
                else if (email.EmailLabel == MessageLabel.TRASH)
                {
                    trashListView.Items.Add(item);
                }
            }
        }

        // Load the message selected from the ListView to the message webbrowser.
        public void LoadEmail(ListView listView)
        {
            notificationPanel.Visible = false;

            if (listView.SelectedItems != null && listView.SelectedItems.Count > 0)
            {
                var selectedEmail = listView.SelectedItems[0].Tag as Email;

                messagePanel.Visible = true;
                noContentPanel.Visible = false;
                newMessagePanel.Visible = false;
                searchResultPanel.Visible = false;

                if (selectedEmail != null)
                {
                    messageWebBrowser.DocumentText = selectedEmail.EmailBodyHTML;
                    subjectContentLabel.Text = selectedEmail.EmailSubject;
                    fromContentLabel.Text = selectedEmail.Sender;
                    toContentLabel.Text = selectedEmail.Receiver;
                    dateContentLabel.Text = selectedEmail.EmailDate;
                    labelLabel.Text = selectedEmail.EmailLabel.ToString();
                    DisplayMessageControlButtons(selectedEmail.EmailLabel);
                }
            }
        }
    }
}
