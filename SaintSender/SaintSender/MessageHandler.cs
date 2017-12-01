using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mail;
using System.Threading.Tasks;

namespace SaintSender
{
    class MessageHandler
    {
        private IList<Message> messages;

        private List<Email> emails = new List<Email>();
        public List<Email> Emails
        {
            get { return emails; }
        }

        public MessageHandler()
        {
            emails = GetEmails();
        }

        // Retrieve all emails of all labels.
        public List<Email> GetEmails()
        {
            List<Email> emails = new List<Email>();
            var labels = Enum.GetValues(typeof(MessageLabel));

            foreach (MessageLabel label in labels)
            {
                messages = ListMessages(MailService.Service, "me", label);
                foreach (Message message in messages)
                {
                    Email email = new Email(message, label);
                    emails.Add(email);
                }
            }

            return emails;
        }

        // Retrieve all emails of all labels asyncronously in oreder to keep the email list up do date continously.
        public async Task<List<Email>> GetEmailsAsync()
        {
            List<Email> emails = GetEmails();

            return emails;
        }

        // Send request for retrieving all emails of the given label with an optional search parameter.
        public static IList<Message> ListMessages(GmailService service, String userId, MessageLabel label, string query = null)
        {
            List<Message> result = new List<Message>();
            UsersResource.MessagesResource.ListRequest request = service.Users.Messages.List(userId);
            request.LabelIds = label.ToString();
            if (query != null)
            {
                request.Q = query;
            }

            do
            {
                try
                {
                    ListMessagesResponse response = request.Execute();
                    result.AddRange(response.Messages);
                }
                catch (Exception e)
                {
                    Console.WriteLine("An error occurred: " + e.Message);
                }
            } while (!String.IsNullOrEmpty(request.PageToken));

            return result;
        }

        // Create and send new MIME message object.
        public bool SendNewEmail(string to, string subject, string body)
        {
            Message email = CreateMessage(to, subject, body);

            try
            {
                var result = MailService.Service.Users.Messages.Send(email, "me").Execute();
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occured: {0}", e.Message);
                return false;
            }

            return true;
        }

        // Create a new draft email with optional recipient, subject and message body.
        public bool CreateDraft(string to = "", string subject = "", string body = "")
        {

            Message email = CreateMessage(to, subject, body);

            Draft draft = new Draft();
            draft.Message = email;

            try
            {
                var result = MailService.Service.Users.Drafts.Create(draft, "me").Execute();
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: {0}", e.Message);
                return false;
            }

            return true;
        }

        private Message CreateMessage(string to, string subject = "", string body = "")
        {
            var newEmail = new AE.Net.Mail.MailMessage
            {
                Subject = subject,
                Body = body,
                From = new MailAddress("gimmethefcknkeys@gmail.com", "Keyser Soze")
            };
            newEmail.To.Add(new MailAddress(to));
            newEmail.ReplyTo.Add(newEmail.From);
            var emailString = new StringWriter();
            newEmail.Save(emailString);
            Message email = new Message { Raw = Encoder.ConvertToBase64(emailString.ToString()) };

            return email;
        }

        // Retrieve all messages matching the given search expression.
        public List<Email> Search(string toSearch)
        {
            List<Email> searchResults = new List<Email>();
            var labels = Enum.GetValues(typeof(MessageLabel));

            foreach (MessageLabel label in labels)
            {
                IList<Message> searchResultMessages = ListMessages(MailService.Service, "me", label, toSearch);
                foreach (Message message in searchResultMessages)
                {
                    Email email = new Email(message, label);
                                    searchResults.Add(email);
                }
            }

            if (searchResults.Count > 0)
            {
                return searchResults;
            }
            else
            {
                return null;
            }
        }
    }
}
