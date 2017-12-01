using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SaintSenderConsoleApp
{
    class Program
    {
        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/gmail-dotnet-quickstart.json
        static string[] Scopes = { GmailService.Scope.GmailReadonly };
        static string ApplicationName = "Gmail API .NET Quickstart";

        static void Main(string[] args)
        {
            UserCredential credential;

            using (var stream =
                new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/gmail-dotnet-quickstart.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            // Create Gmail API service.
            var service = new GmailService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            // Define parameters of request.
            UsersResource.MessagesResource.ListRequest request = service.Users.Messages.List("me");

            /*
            // List labels.
            IList<Label> labels = request.Execute().Labels;
            Console.WriteLine("Labels:");
            if (labels != null && labels.Count > 0)
            {
                foreach (var labelItem in labels)
                {
                    Console.WriteLine("{0}", labelItem.Name);
                }
            }
            else
            {
                Console.WriteLine("No labels found.");
            }
             */

            // List messages
            IList<Message> messages = ListMessages(service, "me");
            Console.WriteLine("Messages: ");
            if (messages != null && messages.Count > 0)
            {
                foreach (Message message in messages)
                {
                    UsersResource.MessagesResource.GetRequest asd = service.Users.Messages.Get("me", message.Id);
                    string messageSnippet = asd.Execute().Snippet;
                    var messagePayload = asd.Execute().Payload;
                    string sender = messagePayload.Headers[6].Value;
                    var parts = messagePayload.Parts;
                    Console.WriteLine("From: " + sender);

                    if (!string.IsNullOrWhiteSpace(parts[0].Body.Data))
                    {
                        string InputStr = parts[0].Body.Data.Replace("-", "+").Replace("_", "/");
                        string decodedString = Encoding.UTF8.GetString(Convert.FromBase64String(InputStr));
                        Console.WriteLine("Body: " + decodedString);
                    }
                    else
                    {
                        Console.WriteLine("Well that didn't work out, did it?");
                    }
                }
            }
            else
            {
                Console.WriteLine("No messages found");
            }

           Console.Read();

        }

        public static List<Message> ListMessages(GmailService service, String userId)
        {
            List<Message> result = new List<Message>();
            UsersResource.MessagesResource.ListRequest request = service.Users.Messages.List(userId);
            // request.Q = query;

            do
            {
                try
                {
                    ListMessagesResponse response = request.Execute();
                    result.AddRange(response.Messages);
                    request.PageToken = response.NextPageToken;
                }
                catch (Exception e)
                {
                    Console.WriteLine("An error occurred: " + e.Message);
                }
            } while (!String.IsNullOrEmpty(request.PageToken));

            return result;
        }

    }
}
