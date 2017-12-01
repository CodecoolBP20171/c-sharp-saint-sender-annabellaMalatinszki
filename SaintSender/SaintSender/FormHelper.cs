using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaintSender
{
    public partial class Form1
    {
        // Change notification label to green with given message
        private void NotifySuccess(string notification)
        {
            notificationLabel.BackColor = Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            notificationLabel.ForeColor = Color.Green;
            notificationLabel.Text = notification;
        }

        // Change notifivation label to red with given message.
        private void NotifyFailure(string notification)
        {
            notificationLabel.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            notificationLabel.ForeColor = Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            notificationLabel.Text = notification;
        }

        // Empty textboxes of the new message panel.
        private void EmptyNewMessageTextBoxes()
        {
            toTextBox.Clear();
            subjectTextBox.Clear();
            newMessageRichTextBox.Clear();
        }

        // Select the control button panel corresponding to the message label.
        private void DisplayMessageControlButtons(MessageLabel label)
        {
            inboxControlPanel.Visible = false;
            sentControlPanel.Visible = false;
            draftControlPanel.Visible = false;
            spamControlPanel.Visible = false;
            trashControlPanel.Visible = false;

            if (label == MessageLabel.INBOX)
            {
                inboxControlPanel.Visible = true;
            }
            else if (label == MessageLabel.SENT)
            {
                sentControlPanel.Visible = true;
            }
            else if (label == MessageLabel.DRAFT)
            {
                draftControlPanel.Visible = true;
            }
            else if (label == MessageLabel.SPAM)
            {
                spamControlPanel.Visible = true;
            }
            else if (label == MessageLabel.TRASH)
            {
                trashControlPanel.Visible = true;
            }
        }
    }
}
