using Google.Apis.Gmail.v1;

namespace SaintSender
{
    class MailService
    {
        static Connector connector;

        private MessageHandler messageHandler;
        public MessageHandler MessageHandler
        {
            get { return messageHandler; }
        }

        private static GmailService service;
        public static GmailService Service
        {
            get { return service; }
        }

        public MailService()
        {
            connector = new Connector();
            connector.Connect();
            service = connector.Service;
            messageHandler = new MessageHandler();
        }
    }
}
