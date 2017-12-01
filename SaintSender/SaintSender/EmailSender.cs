using System;
using System.Drawing;
using System.Windows.Forms;

namespace SaintSender
{
    public partial class Form1
    {
        private void sendButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(toTextBox.Text) || string.IsNullOrWhiteSpace(subjectTextBox.Text))
            {
                MessageBox.Show("Please add a recipient and subject.");
            }
            else
            {
                string newEmailTo = toTextBox.Text;
                string newEmailSubject = subjectTextBox.Text;
                string newEmailBody = newMessageRichTextBox.Text;

                messagePanel.Visible = false;
                newMessagePanel.Visible = false;
                searchResultPanel.Visible = false;
                noContentPanel.Visible = true;
                notificationPanel.Visible = true;

                bool success = mailService.MessageHandler.SendNewEmail(newEmailTo, newEmailSubject, newEmailBody);

                if (success)
                {
                    NotifySuccess("Email successfully sent.");
                }
                else
                {
                    NotifyFailure("Something went wrong.");
                }
            }
        }

        private void discardButton_Click(object sender, EventArgs e)
        {
            EmptyNewMessageTextBoxes();
            newMessagePanel.Visible = false;
            noContentPanel.Visible = true;
        }

        private void saveDraftButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(toTextBox.Text))
            {
                MessageBox.Show("Please add a recipient to save draft.");
            }
            else
            {
                string draftTo = toTextBox.Text;
                string draftSubject = subjectTextBox.Text;
                string draftBody = newMessageRichTextBox.Text;

                EmptyNewMessageTextBoxes();

                newMessagePanel.Visible = false;
                noContentPanel.Visible = true;
                notificationPanel.Visible = true;

                bool success = mailService.MessageHandler.CreateDraft(draftTo, draftSubject, draftBody);
                if (success)
                {
                    NotifySuccess("Draft saved");
                }
                else
                {
                    NotifyFailure("Something went wrong.");
                }
            }
        }
    }
}
