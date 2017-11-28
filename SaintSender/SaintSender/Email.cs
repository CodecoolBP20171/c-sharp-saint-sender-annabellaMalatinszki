using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaintSender
{
    class Email
    {
        GmailService service = MailService.Service;

        // Some properties might be better off as not strings, review later.
        private string emailId;

        public string EmailId
        {
            get { return emailId; }
        }

        private string emailSubject;

        public string EmailSubject
        {
            get { return emailSubject; }
        }

        private string  sender;

        public string Sender
        {
            get { return sender; }
        }

        private string receiver;

        public string Receiver
        {
            get { return receiver; }
        }

        private string emailDate;

        public string EmailDate
        {
            get { return emailDate; }
        }

        private string received;

        public string Received
        {
            get { return received; }
        }

        private string emailBody;

        public string EmailBody
        {
            get { return emailBody; }
        }

        public Email(Message message)
        {
            GmailService service = MailService.Service;
            MessagePart messagePayload = GetEmailDetails(message);
            if (messagePayload != null)
            {
                emailId = messagePayload.Headers[4].Value;
                emailSubject = messagePayload.Headers[5].Value;
                sender = messagePayload.Headers[6].Value;
                receiver = messagePayload.Headers[7].Value;
                emailDate = messagePayload.Headers[3].Value;
                received = messagePayload.Headers[2].Value;
                emailBody = GetEmailBody(messagePayload.Parts);
            }
            else
            {
                //Handle here if messagePayload is empty.
            }
        }

        private MessagePart GetEmailDetails(Message message)
        {
            UsersResource.MessagesResource.GetRequest singleMessage = service.Users.Messages.Get("me", message.Id);
            MessagePart messagePayload = singleMessage.Execute().Payload;
            return messagePayload;
        }

        private string GetEmailBody(IList<MessagePart> messageParts)
        {
            string decodedBody;
            if (!string.IsNullOrWhiteSpace(messageParts[0].Body.Data))
            {
                string InputStr = messageParts[0].Body.Data.Replace("-", "+").Replace("_", "/");
                decodedBody = Encoding.UTF8.GetString(Convert.FromBase64String(InputStr));
                return decodedBody;
            }
            else
            {
                return null;
            }
        }
    }
}
