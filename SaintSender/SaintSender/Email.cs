using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using System;
using System.Collections.Generic;

namespace SaintSender
{
    class Email
    {
        GmailService service = MailService.Service;

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

        private string emailBody;
        public string EmailBody
        {
            get { return emailBody; }
        }

        private string emailBodyHTML;
        public string EmailBodyHTML
        {
            get { return emailBodyHTML; }
        }

        private MessageLabel emailLabel;
        public MessageLabel EmailLabel
        {
            get { return emailLabel; }
        }


        public Email(Message message, MessageLabel label)
        {
            GmailService service = MailService.Service;
            MessagePart messagePayload = GetEmailDetails(message);

            foreach (var payloadHeader in messagePayload.Headers)
            {
                if (payloadHeader.Name == "Message-ID")
                {
                    emailId = payloadHeader.Value;
                }
                else if (payloadHeader.Name == "Subject")
                {
                    emailSubject = payloadHeader.Value;
                }
                else if (payloadHeader.Name == "From")
                {
                    sender = payloadHeader.Value;
                }
                else if (payloadHeader.Name == "To")
                {
                    receiver = payloadHeader.Value;
                }
                else if (payloadHeader.Name == "Date")
                {
                    emailDate = payloadHeader.Value;
                }
            }
            emailBody = GetEmailBody(messagePayload.Parts, "plain");
            emailBodyHTML = GetEmailBody(messagePayload.Parts, "html");
            emailLabel = label;
        }

        // Retrieve the message payload.
        private MessagePart GetEmailDetails(Message message)
        {
            UsersResource.MessagesResource.GetRequest singleMessage = service.Users.Messages.Get("me", message.Id);

            MessagePart messagePayload = singleMessage.Execute().Payload;

            return messagePayload;
        }

        // Retrieve the body of the message in both plain text and html format from the message payload.
        private string GetEmailBody(IList<MessagePart> messageParts, string textType)
        {
            string decodedBody = null;

            try
            {
                if (!string.IsNullOrWhiteSpace(messageParts[0].Body.Data))
                {
                    if (textType == "plain")
                    {
                        decodedBody = Encoder.ConvertFromBase64(messageParts[0].Body.Data);
                    }
                    else if (textType == "html")
                    {
                        decodedBody = Encoder.ConvertFromBase64(messageParts[1].Body.Data);
                    }
                }
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Well, shit happens: {0}", e.StackTrace);
            }

            return decodedBody;
        }
    }
}
