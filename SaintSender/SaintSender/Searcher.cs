using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SaintSender
{
    public partial class Form1
    {
        private void searchButton_Click(object sender, EventArgs e)
        {
            string toSearch = searchTextBox.Text;
            searchResultContentLabel.Text = toSearch;
            List<Email> searchResults = mailService.MessageHandler.Search(toSearch);

            searchTextBox.Clear();

            notificationPanel.Visible = false;
            messagePanel.Visible = false;
            newMessagePanel.Visible = false;
            noContentPanel.Visible = false;
            searchResultPanel.Visible = true;

            if (searchResults != null)
            {
                noResultPanel.Visible = false;
                resultListView.Visible = true;
                PopulateSearchResults(searchResults);
            }
            else
            {
                resultListView.Visible = false;
                noResultPanel.Visible = true;
            }
        }
        
        // List messages matching the search query. 
        private void PopulateSearchResults(List<Email> searchResults)
        {
            ListViewItem item = null;

            resultListView.Clear();

            foreach (Email email in searchResults)
            {
                item = new ListViewItem(email.EmailLabel.ToString() + " " +email.Sender + " " + email.EmailSubject);
                item.Tag = email;
                resultListView.Items.Add(item);
            }
        }

        private void resultListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadEmail(resultListView);
        }
    }
}
