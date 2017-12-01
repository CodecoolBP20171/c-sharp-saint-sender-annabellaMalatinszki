using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SaintSender
{
    public partial class Form1 : Form
    {
        MailService mailService;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mailService = new MailService();
            List<Email> emails = mailService.MessageHandler.Emails;

            timer.Start();
            PopulateMessages(emails);

            letterPicture.ImageLocation = "C:\\Users\\amala\\Documents\\Codecool\\C#\\TW_assignments\\c-sharp-saint-sender-annabellaMalatinszki\\SaintSender\\letter.png";
            letterPicture.SizeMode = PictureBoxSizeMode.StretchImage;

            messagePanel.Visible = false;
            newMessagePanel.Visible = false;
            notificationPanel.Visible = false;
            searchResultPanel.Visible = false;
            noContentPanel.Visible = true;
        }

        private void messagesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadEmail(messagesListView);
        }

        private void sentMessagesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadEmail(sentMessagesListView);
        }

        private void draftsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadEmail(draftsListView);
        }

        private void spamListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadEmail(spamListView);
        }

        private void trashListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadEmail(trashListView);
        }

        private void composeButton_Click(object sender, EventArgs e)
        {
            messagePanel.Visible = false;
            notificationPanel.Visible = false;
            noContentPanel.Visible = false;
            searchResultPanel.Visible = false;
            newMessagePanel.Visible = true;
            EmptyNewMessageTextBoxes();
        }

        private async void timer_Tick(object sender, EventArgs e)
        {
            var getEmails = mailService.MessageHandler.GetEmailsAsync();
            var emails = await getEmails;

            PopulateMessages(emails);
        }

        private void inboxReplyButton_Click(object sender, EventArgs e)
        {

        }

        private void inboxSpamButton_Click(object sender, EventArgs e)
        {

        }

        private void inboxDeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void draftEditButton_Click(object sender, EventArgs e)
        {

        }

        private void draftDiscardButton_Click(object sender, EventArgs e)
        {

        }

        private void spamInboxButton_Click(object sender, EventArgs e)
        {

        }

        private void spamDeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void sentDeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void trashDeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void trashInboxButton_Click(object sender, EventArgs e)
        {

        }
    }
}
