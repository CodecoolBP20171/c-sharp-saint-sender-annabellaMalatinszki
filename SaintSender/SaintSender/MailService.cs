using Google.Apis.Gmail.v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaintSender
{
    class MailService
    {
        static Connector connector = new Connector();
        MessageHandler messageHandler = new MessageHandler();

        public GmailService service = connector.GetService();

        public void PopulateMessages()
        {
            // Populate messagesListView with all the messages.
        }

        public void LoadMessage()
        {
            // Load the selected message to the message RichTextBox.
        }
    }
}
